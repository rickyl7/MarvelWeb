using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MarvelWeb.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MarvelWeb.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }
        public IEnumerable<Character> Characters { get; private set; }
        public bool GetCharactersError { get; private set; }
        private readonly IHttpClientFactory _clientFactory;

        public AboutModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task OnGet()
        {
            //var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44350/api/Characters/");
            var request = new HttpRequestMessage(HttpMethod.Get, "https://marvelwebapi.azurewebsites.net/api/Characters/");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                Characters = await response.Content.ReadAsAsync<IEnumerable<Character>>();
            }
            else
            {
                GetCharactersError = true;
                Characters = Array.Empty<Character>();
            }
        }
    }
}
