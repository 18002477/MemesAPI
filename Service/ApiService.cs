using MemeViewer.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MemeViewer.Service
{
    public class ApiService
    {
        private static string baseUrl = "https://api.imgflip.com/";


        public static async Task<Meme> getMemeAsync()
        {
            Meme singleMeme = new Meme();

            string tmepUrl = baseUrl + "get_memes";

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(tmepUrl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync(tmepUrl);

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var MemeResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    singleMeme = JsonConvert.DeserializeObject<Meme>(MemeResponse);

                }

                return singleMeme;
            }
        }
    }
}
