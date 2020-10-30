using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OSGPLogic;
using System.Text.Json;

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

            foreach(Item item in itemList)
            {
                Console.WriteLine(item.name);
            }

            return new JsonResult(JsonSerializer.Serialize(itemList));
        }

        public void OnGet()
        {

        }
    }
}
