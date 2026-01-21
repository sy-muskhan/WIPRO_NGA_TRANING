using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DesignPatterns
{
    public class DocumentFactory
    {
        public IDocument CreateDocument(string type)
        {
            if(type == "PDF")
            {
                return new PdfDocument();
            }
            else if(type == "WORD")
            {
                return new WordDocument();
            }
            else
            {
                return null;
            }
            
        }
    }
}
