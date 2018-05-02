using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GPRTCommon
{
    public class WebHandler
    {
        private HttpClient client = new HttpClient();

        public async Task<List<Level>> GetLevels()
        {
            const string path = "http://localhost:49832/api/default";
            List<Level> levels = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                levels = await response.Content.ReadAsAsync<List<Level>>();
            }
            return levels;
        }

        public async void RemoveModule(string levelName, string moduleTitle)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(levelName + ":" + moduleTitle);
            var payload = System.Convert.ToBase64String(plainTextBytes);

            string path = "http://localhost:49832/api/default/" + payload;
            HttpResponseMessage response = await client.DeleteAsync(path);
        }

        public async Task<Uri> SaveLevels(List<Level> levels)
        {
            const string path = "http://localhost:49832/api/default";
            HttpResponseMessage response = await client.PostAsJsonAsync(path, levels);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }
    }
}
