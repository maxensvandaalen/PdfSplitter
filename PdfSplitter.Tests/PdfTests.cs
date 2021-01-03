using System;
using Xunit;
using FluentAssertions;
using PdfSplitterLogic;
using System.IO;

namespace PdfSplitter.Tests
{
    public class PdfTests
    {
        [Fact]
        public void MissingInputFileThrowsException()
        {
            Action act = () => Pdf.Load("fakepath");

            act.Should().Throw<FileNotFoundException>().WithMessage("Input PDF does not exist.");
        }

      
    }
}
