using System;
using System.Linq;
using Xunit;

namespace SheetsLibrary.Test
{
    public class SheetsTests
    {
        [Fact]
        public void ICanReadResults()
        {
            SheetsLibrary.Sheets sheetsService = new SheetsLibrary.Sheets("https://drive.google.com/open?id=16QE-m2Xgo7PiiFXwIrwWh9jr2Adf6-UJTtD2iuDA7Jw");
            var result = sheetsService.GetRow("A");
            Assert.True(result.Any());
        }

        [Fact]
        public void ICanReadResultsFromSharedUrl()
        {
            SheetsLibrary.Sheets sheetsService = new SheetsLibrary.Sheets("https://docs.google.com/spreadsheets/d/16QE-m2Xgo7PiiFXwIrwWh9jr2Adf6-UJTtD2iuDA7Jw/edit?usp=sharing");
            var result = sheetsService.GetRow("A");
            Assert.True(result.Any());
        }
    }
}
