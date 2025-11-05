using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace WorkingWithREST
{
    public class MedicalRecordsAPI
    {
        protected int userId = 1;
        protected int page = 1;
        protected string URL = "https://jsonmock.hackerrank.com/api/medical_records";
        protected HttpClient http = new HttpClient();
        public int totalPages;
        public List<MedicalRecord> AllRecords;

        public MedicalRecordsAPI()
        {
            URL = string.Format(URL, userId, page);
            AllRecords = new List<MedicalRecord>();
            initializeAllRecords().GetAwaiter().GetResult();
        }

        protected async Task initializeAllRecords()
        {
            do
            {
                var json = await http.GetStringAsync(URL);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var response = JsonSerializer.Deserialize<ApiResponse<MedicalRecord>>(json, options);
                totalPages = response.TotalPages;
                AllRecords.AddRange(response.Data);
                page++;
            } while (page <= totalPages);
        }


        // todo: the URL accepts userId and page as parameters
        // we can also add ability to fetch records for a specific userId instead of all users



    }


    // Using System.Net.Http;
    /* using var http = new HttpClient();
    var resp = await http.GetAsync(URL);
    resp.EnsureSuccessStatusCode();
    string json = await resp.Content.ReadAsStringAsync();
    Console.WriteLine(json); */

    // Using RestSharp;
    /* var options = new RestClientOptions(URL);
    var client = new RestClient(options);
    var request = new RestRequest();
    var response = await client.GetAsync(request);
    Console.WriteLine(response.Content); */
}
