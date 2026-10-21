using System;
using System.Collections.Generic;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace SheetsLibrary
{
    public class Sheets
    {
        private readonly string _sheetUrl;
        static string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        static string ApplicationName = "Google Sheets API .NET Quickstart";
        public Sheets(string sheetUrl)
        {
            _sheetUrl = sheetUrl;
        }

        public List<string> GetRow(string column = "A", string tabName = "Hoja 1")
        {
            List<string> result = new List<string>();
            GoogleCredential credential;

            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(Scopes);
            }

            // Create Google Sheets API service.
           var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define request parameters.
            String spreadsheetId = GetIdFromUrl(_sheetUrl);
            String range = $"{tabName}!A:B";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, range);

           
            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    result.Add(row[0].ToString());
                }
            }
            return result;
        }

        public Dictionary<string,string> Get2Rows(string columnRange = "A:B", string tabName = "Hoja 1")
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            GoogleCredential credential;

            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(Scopes);
            }

            // Create Google Sheets API service.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define request parameters.
            String spreadsheetId = GetIdFromUrl(_sheetUrl);
            String range = $"{tabName}!{columnRange}";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                service.Spreadsheets.Values.Get(spreadsheetId, range);


            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    result.Add(row[0].ToString(),row[1].ToString());
                }
            }
            return result;
        }

        public List<List<string>> GetRows(string columnRange = "A:B", string tabName = "Hoja 1")
        {
            List<List<string>> result = new List<List<string>>();
            GoogleCredential credential;

            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(Scopes);
            }

            // Create Google Sheets API service.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define request parameters.
            String spreadsheetId = GetIdFromUrl(_sheetUrl);
            String range = $"{tabName}!{columnRange}";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                service.Spreadsheets.Values.Get(spreadsheetId, range);


            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    result.Add(row.Select(x => x.ToString()).ToList());
                }
            }
            return result;
        }

        public string GetIdFromUrl(string url)
        {
            var urlParts = url.Split("/");
            var idField = urlParts.OrderByDescending(x => x.Length).First();
            if (!idField.Contains("="))
            {
                return idField;
            }
            return idField.Split("=")[1];
        }
    }
}
