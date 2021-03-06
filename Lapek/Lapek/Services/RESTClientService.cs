﻿using System.Net.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lapek.Services
{
    public class RESTClientService<T>
    {
        public async Task<List<T>> GetListAsync(string DataUri)
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync(DataUri);
            var list = JsonConvert.DeserializeObject<List<T>>(json);
            return list;
        }

        public async Task<T> GetSingleAsync(string DataUri)
        {
            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(DataUri);

            var single = JsonConvert.DeserializeObject<T>(json);

            return single;
        }

        public async Task<bool> PostAsync(string DataUri,T t)
        {
            var httpClient = new HttpClient();

            var json = JsonConvert.SerializeObject(t);

            HttpContent httpContent = new StringContent(json);

            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var result = await httpClient.PostAsync(DataUri, httpContent);
            var x = result.Content;
            return result.IsSuccessStatusCode;
        }
    }
}
