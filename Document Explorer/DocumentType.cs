using System.Collections.Generic;
namespace Document_Explorer
{
    public class DocumentType
    {
        public string Name;
        public List<string> Extensions;
        public DocumentType()
        {
            Name = "";
            Extensions = new List<string>();
        }
        public bool HasExtension(string str)
        {
            return Extensions.Contains(str);
        }
    }
}
