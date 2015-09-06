using System.IO;
using System.Collections.Generic;
using System.Xml;
using System;
using System.Text.RegularExpressions;
using System.Collections;
namespace Document_Explorer
{
    public static class Global
    {

        public static List<DirectoryInfo> DocumentDirectoryList; //This will load from Config.xml by method ReloadConfig().
        public static List<DocumentInfo> DocumentList; //This will load according to DocumentDirectoryList by method RefreshList().
        public static List<DocumentType> DocumentTypeList; //This will load from Config.xml by method ReloadConfig().
        public static List<string> TagList; //This will load by method RefreshList().
        public static List<string> SelectedTagList; //This will be updated by Form.cs.
        public static XmlDocument Config; //This indicates Config.xml.
        public static Regex NameSpliter; //This is used to split tags from names.
        public static void Initialize()
        {
            NameSpliter = new Regex(@"\[(?<Tag>.*?)\] *", RegexOptions.Compiled);
            ReloadConfig();
            RefreshList();
        }

        public static void AddTag(DocumentInfo doc, string tag)
        {
            if (!doc.Tags.Contains(tag))
            {
                doc.Tags.Add(tag);
            }
            if (!TagList.Contains(tag))
            {
                TagList.Add(tag);
            }
        }

        public static DocumentType GetDocumentType(string extension)
        {
            foreach (DocumentType type in DocumentTypeList)
            {
                if (type.HasExtension(extension))
                {
                    return type;
                }
            }
            return null;
        }

        public static void ReloadConfig()
        {
            DocumentDirectoryList = new List<DirectoryInfo>();
            DocumentTypeList = new List<DocumentType>();
            Config = new XmlDocument();
            Config.Load("Config.xml");
            foreach (XmlNode documentDirectoryNode in Config.DocumentElement.SelectNodes("/Config/DocumentDirectoryList/ListItem"))
            {
                DirectoryInfo newDir = new DirectoryInfo(documentDirectoryNode.InnerText);
                if (newDir.Exists)
                {
                    DocumentDirectoryList.Add(newDir);
                }
                else
                {
                    Console.WriteLine("Failed to load directory " + newDir.FullName + ".");
                }
            }
            foreach (XmlNode documentTypeNode in Config.DocumentElement.SelectNodes("/Config/DocumentTypeList/ListItem"))
            {
                DocumentType newType = new DocumentType();
                newType.Name = documentTypeNode.SelectSingleNode("Name").InnerText;
                foreach (XmlNode extensionNode in documentTypeNode.SelectNodes("ExtensionList/ListItem"))
                {
                    newType.Extensions.Add(extensionNode.InnerText);
                }
                DocumentTypeList.Add(newType);
            }
        }

        public static void RefreshList()
        {
            DocumentList = new List<DocumentInfo>();
            TagList = new List<string>();
            foreach (DirectoryInfo dir in DocumentDirectoryList)
            {
                foreach (FileInfo file in dir.GetFiles())
                {
                    DocumentType type = GetDocumentType(file.Extension.Substring(1));
                    if (type != null)
                    {
                        DocumentInfo newDoc = new DocumentInfo();
                        newDoc.File = file;
                        newDoc.Type = type;
                        newDoc.FullName = file.Name;
                        MatchCollection tagMatches = NameSpliter.Matches(newDoc.FullName);
                        foreach (Match tagMatch in tagMatches)
                        {
                            string tag = tagMatch.Groups["Tag"].ToString();
                            AddTag(newDoc, tag);
                        }
                        AddTag(newDoc, file.Extension.ToLower());
                        newDoc.Name = NameSpliter.Replace(newDoc.FullName, "");
                        DocumentList.Add(newDoc);
                    }
                }
            }
            TagList.Sort();
        }
    }
}
