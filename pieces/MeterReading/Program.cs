using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

namespace MeterReading
{
    class Program
    {
        static void Main(string[] args)
        {
            Processor pro = new Processor();
            SheetsLibrary.Sheets sheetsService = new SheetsLibrary.Sheets("https://docs.google.com/spreadsheets/d/1SsL0tblZi5itS9gZfygdM-NrgOJVkVIoKMzUts88lLM/edit?usp=sharing");
            var result = sheetsService.GetRows("A:G","Form Responses 1");
            result.RemoveAt(0);
            pro.Add(result);
            sheetsService = new SheetsLibrary.Sheets("https://docs.google.com/spreadsheets/d/1rvKbuWs04cECTrnJWVj8qwSYn9lA2a6o1Mv7YF_53PE/edit?usp=sharing");
            result = sheetsService.GetRows("A:G", "Form Responses 1");
            result.RemoveAt(0);
            pro.Add(result); sheetsService = new SheetsLibrary.Sheets("https://docs.google.com/spreadsheets/d/1A3nQpuwcolTbOgFmR5uW0NRAlwDpgU2U4byY46snTKs/edit?usp=sharing");
            result = sheetsService.GetRows("A:G", "Form Responses 1");
            result.RemoveAt(0);
            pro.Add(result);

            Writter writer = new Writter(pro._readings);
            writer.WriteToCsv();
        }
    }

    public class Writter
    {
        private List<UserMeterReading> _readings = new List<UserMeterReading>();
        private StreamWriter _writer = new StreamWriter(@"C:\SourceCode\pieces\MeterReading\bin\Debug\netcoreapp3.1\readings.csv");
        public Writter(List<UserMeterReading> readings)
        {
            _readings = readings;
        }
        public void WriteToCsv()
        {
            WriteToCsv("Minerva", 9);
            WriteToCsv("Janus", 11);
            WriteToCsv("Vesta", 5);
            WriteToCsv("Esquiline", 8);
            WriteToCsv("Juno", 6);
            WriteToCsv("Jupiter", 18);
            WriteToCsv("Juliet", 15);
            WriteToCsv("Lear", 29); 
            WriteToCsv("Venice", 25); 
            WriteToCsv("Verona", 44);
            _writer.Close();
        }

        public void WriteToCsv(string blockName, int numUnits)
        {
            WriteHeader();
            for (int i = 1; i < numUnits + 1; i++)
            {
                var userReading = _readings.FirstOrDefault(x => x.Block == blockName && x.FlatNumber == i);
                if (userReading == null)
                {
                    _writer.WriteLine(UserMeterReading.ToEmptyCsv(blockName,i));
                }
                else
                {
                    _writer.WriteLine(userReading.ToCsv());
                }
            }
        }

        private void WriteHeader()
        {
            _writer.WriteLine(",,,,,");
            _writer.WriteLine("Timestamp,Email Address,Name,Block,Flat number,Meter reading,More information");
        }
    }

    public class Processor
    {
        public List<UserMeterReading> _readings = new List<UserMeterReading>();
        internal void Add(List<List<string>> readings)
        {
            foreach (var singleRead in readings)
            {
                _readings.Add(new UserMeterReading()
                {
                    Timestamp = singleRead[0],
                    Email = singleRead[1],
                    Name = singleRead[2],
                    Block = singleRead[3].ToLower().FirstCharToUpper().Replace(" house",""),
                    FlatNumber = int.Parse(singleRead[4]),
                    Reading = int.Parse(singleRead[5]),
                    MoreInformation = singleRead.Count >6? singleRead[6]:string.Empty
                });
            }
        }
    }

    public class UserMeterReading
    {
        public string Timestamp { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Block { get; set; }
        public int FlatNumber { get; set; }
        public int Reading { get; set; }
        public string MoreInformation { get; set; }

        public string ToCsv()
        {
            return $"{Timestamp},{Email},{Name},{Block.ToLower().FirstCharToUpper()},{FlatNumber},{Reading},{MoreInformation}";
        }

        public static string ToEmptyCsv(string block, int flatNumber)
        {
            return $",CHARGE10,,{block.ToLower().FirstCharToUpper()},{flatNumber},,";
        }
    }
}
