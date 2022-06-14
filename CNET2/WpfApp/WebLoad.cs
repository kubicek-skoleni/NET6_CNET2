using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    public static class WebLoad
    {
        public static int LoadUrl(string url)
        {
            HttpClient httpClient = new HttpClient();

            var content = httpClient.GetStringAsync(url).Result;

            return content.Length;
        }
    }
}
