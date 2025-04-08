using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PostmanCloneUI
{
    public class ApiAccess:IApiAccess
    {

        private readonly HttpClient client = new();


        public async Task<string> CallApiAsync(string url,bool formatOutput=true,
            HttpAction action =HttpAction.GET)
        {
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var jsonEle=JsonSerializer.Deserialize<JsonElement>(json);
                string pretyJson=JsonSerializer.Serialize(jsonEle
                    ,new JsonSerializerOptions { WriteIndented = true });
                return pretyJson;
            }
            else
            {
                return $"error :{response.StatusCode}";
            }
        }





        public bool IsValidUrl(string url) { 

            if (string.IsNullOrEmpty(url)) return false;

            bool output=Uri.TryCreate(url, UriKind.Absolute,out Uri uriOutput)&&
                (uriOutput.Scheme== Uri.UriSchemeHttps
                );
            
            return output;
        }


    }
}
