using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MeterReadings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Reading> readings = new List<Reading>();
            string withoutVeniceVeronaUrl = "https://docs.google.com/spreadsheets/d/1petRmBsGkzoB9-uwzR0GAff2MAG4djPKE_zseP_tJ_g/edit?usp=sharing";
            ReadFromUrl(readings, withoutVeniceVeronaUrl);
            string veniceVeronaUrl = "https://docs.google.com/spreadsheets/d/1yLziiRkOWGC9dWH8Q6sVg1XgVOm58Ficy3cVUnTZZls/edit?usp=sharing";
            ReadFromUrl(readings, veniceVeronaUrl);
            string nothingHillUrl = "https://docs.google.com/spreadsheets/d/1petRmBsGkzoB9-uwzR0GAff2MAG4djPKE_zseP_tJ_g/edit?usp=sharing";
            ReadFromUrl(readings, nothingHillUrl);

            using (var file = File.CreateText("AllReadings.csv"))
            {
                WriteReading(readings, file, "Minerva", 9);
                WriteReading(readings, file, "Janus", 11);
                WriteReading(readings, file, "Vesta", 5); 
                WriteReading(readings, file, "Juno", 6);
                WriteReading(readings, file, "Jupiter", 18);
                WriteReading(readings, file, "Juliet", 15);
                WriteReading(readings, file, "Lear", 29);
                WriteReading(readings, file, "Venice", 24);
                WriteReading(readings, file, "Verona", 44);
            }
        }

        private static void WriteReading(List<Reading> readings, StreamWriter file, string blockName, int numFlats)
        {
            file.WriteLine(",,,,,,");
            file.WriteLine("Timestamp,Email Address,Name,Block,Flat number,Meter reading,More information");
            for (int i = 1; i <= numFlats; i++)
            {
                var reading =
                    readings.FirstOrDefault(x => x.Block.ToLower() == blockName.ToLower() && x.FlatNumber == i);
                if (reading == null)
                {
                    reading = new Reading()
                    {
                        Block = blockName,
                        FlatNumber = i,
                        Email = "CHARGE10"
                    };
                }
                else
                {
                    reading.Block = blockName;
                }
                file.WriteLine(reading.ToLineString());
            }
        }

        private static void ReadFromUrl(List<Reading> Readings, string url)
        {
            SheetsLibrary.Sheets sheetsService = new SheetsLibrary.Sheets(url);
            var values = sheetsService.GetRows("A:G", "Form Responses 1");

            if (values[0][0] == "Timestamp")
            {
                values.RemoveAt(0);
            }

            foreach (var row in values)
            {
                Readings.Add(new Reading(row));
            }
        }
    }

    public class Reading
    {
        public Reading()
        { }
        public Reading(List<string> data)
        {
            TimeStamp = data[0];
            Email = data[1];
            Name = data[2];
            Block = data[3].Replace("House","").Replace(" ","");
            FlatNumber = int.Parse(data[4]);
            MeterReading = int.Parse(data[5]);
            MoreInfo = data.Count > 6 ? data[6] : string.Empty;
        }

        public string TimeStamp { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Block { get; set; }
        public int FlatNumber { get; set; }
        public int MeterReading { get; set; }
        public string MoreInfo { get; set; }

        public string ToLineString()
        {
            return $"{TimeStamp},{Email},{Name},{Block},{FlatNumber},{MeterReading},{MoreInfo}";
        }
    }
}
