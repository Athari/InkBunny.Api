using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    public class InkBunnyClient : IDisposable
    {
        public static readonly Uri BaseUri = new Uri("https://inkbunny.net/");

        private string _userAgentName;
        private string _userAgentVersion;
        private string _sid;
        private IWebProxy _proxy;

        private readonly HttpClient _httpClient;

        public InkBunnyClient()
        {
            var httpClientHandler = new HttpClientHandler {
                AllowAutoRedirect = true,
                AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip,
                Proxy = _proxy,
                UseProxy = _proxy != null,
            };
            _httpClient = new HttpClient(httpClientHandler) {
                BaseAddress = BaseUri,
                DefaultRequestHeaders = {
                    Referrer = BaseUri,
                    UserAgent = {
                        new ProductInfoHeaderValue(_userAgentName, _userAgentVersion),
                        new ProductInfoHeaderValue("through Alba.InkBunny.Api"),
                    }
                }
            };
        }

        private async Task<T> Request<T>(string api, IEnumerable<KeyValuePair<string, string>> arguments)
        {
            using (var request = new MultipartFormDataContent()) {
                foreach (KeyValuePair<string, string> argument in arguments.Where(a => a.Value != null))
                    request.Add(new StringContent(argument.Value), argument.Key);
                using (HttpResponseMessage response = await _httpClient.PostAsync($"/api_{api}.php", request)) {
                    response.EnsureSuccessStatusCode();
                    return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
                }
            }
        }


        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}