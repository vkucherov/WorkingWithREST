using RestSharp;
using System.Text.Json;
using WorkingWithREST;





MedicalRecordsAPI api = new MedicalRecordsAPI();

Console.WriteLine($"Total Records Fetched: {api.AllRecords.Count}");

foreach (var record in api.AllRecords.Select(f => f.UserName).Distinct().Order().ToList())
{
    Console.WriteLine(record);
}

Console.ReadKey(); 