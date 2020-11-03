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
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI;
using Microsoft.AspNetCore.Http;

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

        public JsonResult OnGetRegister(string email, string username, string password)
        {
            UserContainer userContainer = new UserContainer();

            string registerUser = userContainer.createUser(email, username, password);

            return new JsonResult(registerUser);
        }

        /// <summary>
        /// Handle login related stuff
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public IActionResult OnGetLogin(string email, string password)
        {
            UserContainer userContainer = new UserContainer();
            string resultString = "";

            User user = userContainer.login(email);


            if (user.checkPassword(password))
            {
                // user has succesfully logged in.
                // Set some session stuff
                HttpContext.Session.SetString("Email", user.email);
                HttpContext.Session.SetString("Username", user.userName);
                HttpContext.Session.SetInt32("Admin", Convert.ToInt32(user.admin));
                HttpContext.Session.SetInt32("LoggedIn", 1);

                resultString = "Success";
            }
            else
            {
                resultString = "Fail";
            }

            return new JsonResult(resultString);
        }

        /// <summary>
        /// Always called when the page loads
        /// </summary>
        public void OnGet()
        {
            // This does not function yet

            // Due to this method always being called when the page loads we can do some ViewData stuff
            if (BitConverter.ToBoolean(HttpContext.Session.Get("LoggedIn")))
            {
                ViewData["LoggedIn"] = 1;
                ViewData["Username"] = HttpContext.Session.GetString("Username");
            }
            else
            {
                ViewData["LoggedIn"] = 0;
            }
        }
    }
}
