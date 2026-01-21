using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DesignPatterns
{
    public class PdfDocument:IDocument
    {
        public string GetDocumentType()
        {
            return "PDF Document";
        }
    }
}
