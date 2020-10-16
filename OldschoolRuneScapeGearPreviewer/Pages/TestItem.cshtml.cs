using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using OSGPLogic;

namespace OSGPView.Pages
{
    /// <summary>
    /// This is a test page so test the following functions:
    /// Database connection
    /// Getting an item out of the database
    /// Converting the DataTable to an item object
    /// Showing the item stats in the view
    /// </summary>
    public class TestItemModel : PageModel
    {
        public Item item = new Item();

        public void OnGet()
        {
            ItemContainer itemContainer = new ItemContainer();

            item = itemContainer.getItemByName("Helm of Neitiznot");

            Console.WriteLine(item);
        }
    }
}