using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace OSGPAPI
{
    public class APIContainer
    {
        private string APIString = "https://secure.runescape.com/m=itemdb_oldschool/api/catalogue/items.json";

        private string URLParameters = "?page=1&category=1&alpha=";

        /// <summary>
        /// Retrieves the API result and converts it to a usable class
        /// </summary>
        /// <returns></returns>
        public APIReturn GetInfoItem(string itemName)
        {
            // Create an empty APIReturn so we can fill it
            APIReturn APIreturn = new APIReturn();

            using (HttpClient uClient = new HttpClient())
            {
                uClient.BaseAddress = new Uri(APIString);

                HttpResponseMessage response = uClient.GetAsync(URLParameters + itemName.Replace(" ", "%20")).Result;
                var dataObjects = response.Content.ReadAsStringAsync();

                // Convert dataObjects.Result to a JSON string
                JObject json = JObject.Parse(dataObjects.Result);

                //Console.WriteLine(json.GetValue("items").First);

                // Get the value of the "items" array and call .First to make sure we're actually in the array
                // Deserialize it into a APIReturn object and fill APIreturn with the result
                APIreturn = JsonConvert.DeserializeObject<APIReturn>(json.GetValue("items").First.ToString());
            }

            return APIreturn;
        }
    }
}
