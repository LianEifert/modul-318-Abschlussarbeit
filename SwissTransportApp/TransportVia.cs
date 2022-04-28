using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport.Core;
using SwissTransport.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace SwissTransportApp
{
    public class TransportVia : IDisposable
    {
        private const string WebApiHost = "https://transport.opendata.ch/v1/";

        private readonly HttpClient httpClient = new HttpClient();


        public ConnectionsVia GetConnectionsVia(string fromStation, string toStation, string via)
        {
            if (string.IsNullOrEmpty(fromStation))
            {
                throw new ArgumentNullException(nameof(fromStation));
            }

            if (string.IsNullOrEmpty(toStation))
            {
                throw new ArgumentNullException(nameof(toStation));
            }
            if (string.IsNullOrEmpty(via))
            {
                throw new ArgumentNullException(nameof(toStation));
            }

            var uri = new Uri($"{WebApiHost}connections?from={fromStation}&to={toStation}&via[]={via}");
       
            return this.GetObject<ConnectionsVia>(uri);
        }
        private T GetObject<T>(Uri uri)
        {
            HttpResponseMessage response = this.httpClient
                .GetAsync(uri)
                .GetAwaiter()
                .GetResult();
            string content = response.Content
                .ReadAsStringAsync()
                .GetAwaiter()
                .GetResult();

            return JsonConvert.DeserializeObject<T>(content);
        }





        public void Dispose()
        {
            this.httpClient?.Dispose();
        }

    }
}
