using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace OSGPAPI
{
    public static class APIContainer
    {
        private static string APIString = "https://secure.runescape.com/m=itemdb_oldschool/api/catalogue/items.json";

        private static string URLParameters = "?page=1&category=1&alpha=";

        private static HttpClient pClient = new HttpClient();

        /// <summary>
        /// Retrieves the API result and converts it to a usable class
        /// </summary>
        /// <returns></returns>
        public static APIReturn GetInfoItem(string itemName)
        {
            //
            // NOTE: The API adds a very noticable load delay to the application.
            // The delay is generally half a second. Will look into ways to speed it up.
            //

            // Create an empty APIReturn so we can fill it

            // The old way, sometimes very slow???? but it functions

            HttpResponseMessage response = pClient.GetAsync(APIString + URLParameters + itemName).Result;
            var dataObjects = response.Content.ReadAsStringAsync();

            // Convert dataObjects.Result to a JSON string
            JObject json = JObject.Parse(dataObjects.Result);

            //Console.WriteLine(json.GetValue("items").First);

            // Get the value of the "items" array and call .First to make sure we're actually in the array
            // Deserialize it into a APIReturn object and fill APIreturn with the result
            return JsonConvert.DeserializeObject<APIReturn>(json.GetValue("items").First.ToString());
        }
    }
}
