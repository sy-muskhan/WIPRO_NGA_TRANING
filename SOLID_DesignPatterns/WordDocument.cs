using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DesignPatterns
{
    public class WordDocument:IDocument
    {
        public string GetDocumentType()
        {
            return "Word Document";
        }
    }
}
