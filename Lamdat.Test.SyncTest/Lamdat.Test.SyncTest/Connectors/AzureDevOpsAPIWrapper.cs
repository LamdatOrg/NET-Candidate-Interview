using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections;
using System.Net.Http;

namespace Lamdat.Test.SyncTest.Connectors
{
    public class TfsClientApi<SyncEntity>
    {
        private readonly string _uriCollection;
        private readonly string _credentials;
        private readonly string _apiVersion = "3.0";
        private readonly bool _isAllowedSelfSignedCertificate;


        public TfsClientApi(string uriCollection, string username, string password, bool isAllowedSelfSignedCertificate, string apiVersion)
        {
            _uriCollection = uriCollection;
            _isAllowedSelfSignedCertificate = isAllowedSelfSignedCertificate;

            _credentials = Convert.ToBase64String(
                System.Text.Encoding.ASCII.GetBytes(string.Format("{0}:{1}", username, password)));

            if (!string.IsNullOrEmpty(apiVersion))
                _apiVersion = apiVersion;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="wiql"></param>
        /// <returns></returns>
        public async Task<List<SyncEntity>> GetWorkItems(string wiqlStr)
        {
            var results = new List<SyncEntity>();
            HttpClientHandler handler = new HttpClientHandler();
            if (_isAllowedSelfSignedCertificate)
                handler.ServerCertificateCustomValidationCallback = (s, c, h, e) => true;

            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(_uriCollection);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _credentials);
                client.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=1");
                                
                var wiql = new { query = wiqlStr };
                var postValue = new StringContent(JsonConvert.SerializeObject(wiql), Encoding.UTF8, "application/json"); //mediaType needs to be application/json for a post call
                                
                var method = new HttpMethod("POST");
                var httpRequestMessage = new HttpRequestMessage(method, string.Format("{0}/_apis/wit/wiql?api-version={1}", _uriCollection, _apiVersion)) { Content = postValue };
                var httpResponseMessage = await client.SendAsync(httpRequestMessage);

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    //************************************************
                    //TODO: 2. Add here code to convert the result to SyncEntity Entity, ID and URL fields should be set into this entity
                    var data = await httpResponseMessage.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<dynamic>(data);                    
                     
                    // add new entity to results
                }

            }

            return results;

        }

    }
}
