using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OSGPLogic;
using System.Text.Json;
using System.Diagnostics;
using OSGPAPI;
using Google.Protobuf.WellKnownTypes;

namespace OldschoolRuneScapeGearPreviewer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// AJAX call result to get items to show in the dropdown menu
        /// </summary>
        /// <param name="Type"></param>
        /// <returns></returns>
        public JsonResult OnGetItems(string Type)
        {
            ItemContainer itemContainer = new ItemContainer();
            List<Item> itemList = itemContainer.getItemsFromType(Type);

            return new JsonResult(JsonSerializer.Serialize(itemList));
        }

        /// <summary>
        /// AJAX call to get the price and imagelink for an item
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public JsonResult OnGetItem(string name)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            APIReturn apiReturn = APIContainer.GetInfoItem(name.ToLower());

            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed);

            return new JsonResult(JsonSerializer.Serialize(apiReturn));
        }

        public void OnGet()
        {

        }
    }
}
