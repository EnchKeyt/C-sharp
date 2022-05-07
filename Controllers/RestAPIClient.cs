using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class RestAPIClient<T>
    {

        private const string MainWebServiceUrl = "http://itb.lrmk.ru:8001/"; // Put your main host url here
        private const string LoginWebServiceUrl = MainWebServiceUrl + "api/Sotrudnikis/"; // put your api extension url/uri here

        // This code matches the HTTP Request that we included in our api controller
        public async Task<bool> checkLogin(int id, string password)
        {
            var httpClient = new HttpClient();
            // http://itb.lrmk.ru:8001/api/Sotrudnikis/Id=foo/FIO=foo. The api value and response value should match in order to return a true status code. 
            var response = await httpClient.GetAsync(LoginWebServiceUrl + "Id=" + id + "/" + "FIO=" + password);

            return response.IsSuccessStatusCode; // return either true or false

        }
    }
}