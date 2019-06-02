using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BamBot.Services
{
    public class PictureService
    {
        private readonly HttpClient _http;

        private readonly string[] _reminder = new string[]
        {
            "https://www.youtube.com/watch?v=SbddcXk5aSA\n👖👖👖👖👖",  // 👖👖👖👖👖
            "https://www.youtube.com/watch?v=64ixCkz4kJ0", // Cockroaches
            "https://www.youtube.com/watch?v=DaXYaiyqGd0", // Two shots of Vodka
            "https://www.youtube.com/watch?v=cltFarQSPLA", // Situati♂n
            "https://www.youtube.com/watch?v=rvrZJ5C_Nwg&feature=youtu.be&t=2m22s", // Cowboys in the sky
            "https://www.youtube.com/watch?v=-KhxoL3TvHo :regional_indicator_d::regional_indicator_e::regional_indicator_a::regional_indicator_d::regional_indicator_a::regional_indicator_s::regional_indicator_s:" // Deadass Pizza
        };

        private Random _rand = new Random();


        public PictureService(HttpClient http)
            => _http = http;

        public async Task<String> GetCatPictureAsync()
        {
            var resp = await _http.GetAsync("https://api.thecatapi.com/v1/images/search?");
            JArray jsonArray = JArray.Parse(await resp.Content.ReadAsStringAsync());
            dynamic data = JObject.Parse(jsonArray[0].ToString());

            return (string)data["url"];
        }

        public async Task<String> GetDogPictureAsync()
        {
            var resp = await _http.GetAsync("https://dog.ceo/api/breeds/image/random");
            JObject obj = JObject.Parse(await resp.Content.ReadAsStringAsync());

            return (string)obj["message"];
        }

        public string GetReminder()
        {
            int randomIndex = _rand.Next(_reminder.Length);
            return _reminder[randomIndex];
        }
    }
}