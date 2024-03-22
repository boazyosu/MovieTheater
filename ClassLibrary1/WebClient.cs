using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class WebClient<T> : IWebClient<T>
    {
        public string Server { get; set; }

        public string Controller { get; set; }

        public string Method { get; set; }

        HttpRequestMessage request;
        HttpResponseMessage response;
        HttpClient client;
       
        public WebClient()
        {
            this.client = new HttpClient();
            this.request = new HttpRequestMessage();
            this.keyValues = new Dictionary<string, string>();
        }

        Dictionary<string, string> keyValues;
        public void AddKeyValue(string key, string value)
        {
            this.keyValues.Add(key, value);
        }

        public void ClearKeyValue(string key, string value)
        {
            this.keyValues.Clear();
        }
        public T Get()
        {
            this.request.Method = HttpMethod.Get;
            string url = $"{this.Server}/api/{this.Controller}/{this.Method}/";
            foreach(KeyValuePair<string, string> keyValue in this.keyValues)
            {
                url = url + $"{keyValue.Key}={keyValue.Value}&";
            }
            this.request.RequestUri = new Uri(url);
            this.response = this.client.SendAsync(this.request).Result;
            if(this.response.IsSuccessStatusCode==true)
            {
                return response.Content.ReadAsAsync<T>().Result;
            }
            return default(T);
        }

        public async Task<T> GetAsync()
        {
            this.request.Method = HttpMethod.Get;
            string url = $"{this.Server}/api/{this.Controller}/{this.Method}/";
            foreach (KeyValuePair<string, string> keyValue in this.keyValues)
            {
                url = url + $"{keyValue.Key}={keyValue.Value}&";
            }
            this.request.RequestUri = new Uri(url);
            this.response = await this.client.SendAsync(this.request);
            if (this.response.IsSuccessStatusCode == true)
            {
                return await response.Content.ReadAsAsync<T>();
            }
            return default(T);
        }

        public bool Post(T model)
        {
            this.request.Method = HttpMethod.Post;
            string url = $"{this.Server}/api/{this.Controller}/{this.Method}/";
            this.request.RequestUri = new Uri(url);
            this.request.Content = new ObjectContent(typeof(T), model, new JsonMediaTypeFormatter());
            this.response = this.client.SendAsync(this.request).Result;
            if (this.response.IsSuccessStatusCode == true)
            {
                return response.Content.ReadAsAsync<bool>().Result;
            }
            return false;
        }

        public bool Post(T model, string fileName)
        {
            this.request.Method = HttpMethod.Post;
            string url = $"{this.Server}/api/{this.Controller}/{this.Method}/";
            this.request.RequestUri = new Uri(url);
            MultipartContent multipartContent = new MultipartContent();
            multipartContent.Add(new ObjectContent(typeof(T), model, new JsonMediaTypeFormatter()));
            multipartContent.Add(new StreamContent(File.OpenRead(fileName)));
            this.response.Content = multipartContent;

            this.response = this.client.SendAsync(this.request).Result;
            if (this.response.IsSuccessStatusCode == true)
            {
                return response.Content.ReadAsAsync<bool>().Result;
            }
            return false;
        }

        public bool Post(T model, List<string> files)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> PostAsync(T model)
        {
            this.request.Method = HttpMethod.Post;
            string url = $"{this.Server}/api/{this.Controller}/{this.Method}/";
            this.request.RequestUri = new Uri(url);
            this.request.Content = new ObjectContent(typeof(T), model, new JsonMediaTypeFormatter());
            this.response = this.client.SendAsync(this.request).Result;
            if (this.response.IsSuccessStatusCode == true)
            {
                return await response.Content.ReadAsAsync<bool>();
            }
            return false;
        }

        public async Task<bool> PostAsync(T model, string fileName)
        {
            this.request.Method = HttpMethod.Post;
            string url = $"{this.Server}/api/{this.Controller}/{this.Method}/";
            this.request.RequestUri = new Uri(url);
            MultipartContent multipartContent = new MultipartContent();
            multipartContent.Add(new ObjectContent(typeof(T), model, new JsonMediaTypeFormatter()));
            multipartContent.Add(new StreamContent(File.OpenRead(fileName)));
            this.response.Content = multipartContent;

            this.response = await this.client.SendAsync(this.request);
            if (this.response.IsSuccessStatusCode == true)
            {
                return await response.Content.ReadAsAsync<bool>();
            }
            return false;
        }

        public Task<bool> PostAsync(T model, List<string> files)
        {
            throw new NotImplementedException();
        }
    }
}
