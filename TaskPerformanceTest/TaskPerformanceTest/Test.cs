using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.Http;

namespace TaskPerformanceTest
{
    public class Test
    {
        public async Task<List<string>> Get(List<Uri> uris)
        {
            List<Task<string>> tasks = new List<Task<string>>();
            List<string> output = new List<string>();

            Stopwatch watch = new Stopwatch();
            watch.Start();

            foreach (var uri in uris)
            {
                tasks.Add(GetJsonAsync(uri));
            }

            var result = await Task.WhenAll(tasks);

            watch.Stop();

            // adds individual results
            output.AddRange(result.ToList());
            // adds overall time for this task
            output.Add(watch.Elapsed.ToString());

            return output;
        }

        public async Task<string> GetJsonAsync(Uri uri)
        {
            var watch = new Stopwatch();

            using (var client = new HttpClient())
            {
                watch.Start();
                var jsonString = await client.GetStringAsync(uri);
                watch.Stop();
                return watch.Elapsed.ToString();
            }

        }

    }
}
