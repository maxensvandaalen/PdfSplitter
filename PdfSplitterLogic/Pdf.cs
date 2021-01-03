using System;
using System.IO;
using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.IO;

namespace PdfSplitterLogic
{
    public class Pdf
    {
        public static void Load(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Input PDF does not exist.");
            }

            PdfDocument inputDocument = PdfReader.Open(path, PdfDocumentOpenMode.ReadOnly);
        }
    }
}
