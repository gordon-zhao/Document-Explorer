using System.IO;
using System.Collections.Generic;
using System;
namespace Document_Explorer
{
    public class DocumentInfo
    {
        public FileInfo File;
        public string FullName;
        public string Name;
        public DocumentType Type;
        public List<string> Tags;
        public DocumentInfo()
        {
            File = null;
            Tags = new List<string>();
        }
        public bool MatchTag(List<string> tags)
        {
            foreach (string tag in tags)
            {
                if (!Tags.Contains(tag))
                {
                    Console.Write(tag);
                    return false;
                }
            }
            return true;
        }
    }
}
