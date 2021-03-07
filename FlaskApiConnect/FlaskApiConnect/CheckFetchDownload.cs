using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Windows.Forms;

namespace FlaskApiConnect
{
    class CheckFetchDownload
    {

        public static bool ping(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = 1500;
            request.Method = "HEAD";
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    return response.StatusCode == HttpStatusCode.OK;
                }
            }
            catch (WebException)
            {
                return false;
            }
        }

        public static string fetchInfo(string url)
        {
            string finalUrl = ($"http://your.IP/apiRequestInfo?url={url}");
            var json = "";

            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                    client.Headers.Add("User-Agent: Mozilla/ 5.0(Windows NT 10.0; Win64; x64; rv: 79.0) Gecko/20100101 Firefox/79.0");

                    json = client.DownloadString(finalUrl);
                }
            }
            catch
            {
                MessageBox.Show("Look like you have entered a wrong url or the api is not online");
            }
            return json;

        }

        public static void downloadMedia(string url, bool? video, string downloadDestination, string title)
        {
            string type = "";
            string fileFormat = "";

            if (video == true) type = "video";
            else if (video != true) type = "audio";

            if (type == "video") fileFormat = ".mp4";
            else if (type == "audio") fileFormat = ".mp3";

            if (title == "...")
            {
                title = fetchInfo(url);
            }

            string finalPath = ($"{downloadDestination}\\{title}" + fileFormat);

            using (var client = new WebClient())
            {
                string fullUrl = "http://your.IP/apiRequestDownload?url=" + url + "&type=" + type;
                Console.WriteLine(finalPath);
                Console.WriteLine(fullUrl);
                client.DownloadFile(fullUrl, finalPath);
            }

           
        }
    }
}
