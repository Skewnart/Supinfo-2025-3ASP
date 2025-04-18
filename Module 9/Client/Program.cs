using DAL.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await GetStudents();
        }

        public static async Task GetStudents()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5215");

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("/api/classrooms");
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    List<Classroom>? classes = JsonConvert.DeserializeObject<List<Classroom>>(content);

                    Console.WriteLine(string.Join("\n\n", classes));
                }
            }
        }

    }
}
