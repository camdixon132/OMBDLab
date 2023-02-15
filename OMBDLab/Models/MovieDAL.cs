using Newtonsoft.Json;
using System.Net;

namespace OMBDLab.Models
{
	public class MovieDAL
	{
            public static MovieModel MovieSearchResults(string movie)//adjust here
            {
                //Adjust here
                //Setup
                string url = $"https://www.omdbapi.com/?t={movie}&apikey=737c6f71";

                //request
                HttpWebRequest request = WebRequest.CreateHttp(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                //Convert it to JSON
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string JSON = reader.ReadToEnd();

                //Adjust here
                //Convert to C#
                MovieModel result = JsonConvert.DeserializeObject<MovieModel>(JSON);
                return result;
            }
    }
}

