using Microsoft.AspNetCore.Mvc;

namespace MVC_day05_lab.Controllers
{
    public class StateManagmentController : Controller
    {

        #region TempData
        /// <summary>
        /// TempData is a dictionary that stores data temporarily.
        /// It is used to pass data from one action to another,
        /// typically during a redirect. TempData uses session
        /// state to store the data, but it is designed to be
        /// short-lived and is automatically cleared ""after it is read.""
        /// This makes it ideal for scenarios where you need to pass data between
        /// actions without persisting it for the entire user session.
        /// stored in Cookies and is available for the next request, but it is automatically cleared after that.
        /// expired after 20 min or after the first read, whichever comes first.
        /// </summary>

        //public IActionResult SetTempData()
        //{
        //    TempData["Message"] = "This is a message from TempData.";
        //    return Content("Temp Data Saved Successfully");
        //}

        //public IActionResult GetTempData1()
        //{
        //    // normal read of TempData, it will be cleared after this read
        //    //var message = TempData["Message"] as string;

        //    // peek method allows you to read the value without marking it for deletion, can recall it multiple times until it is explicitly removed or expires 
        //    //var message = TempData.Peek("Message") as string;

        //    // keep method allows you to read the value and mark it for deletion, but it will be available for the next request as well, until it is explicitly removed or expires
        //    var message = TempData["Message"]as string;
        //    TempData.Keep("Message");
        //    return Content(message ?? "No message found in TempData. 1");
        //}

        //public IActionResult GetTempData2()
        //{
        //    //var message = TempData["Message"] as string;
        //    var message = TempData.Peek(key: "Message") as string;

        //    return Content(message ?? "No message found in TempData. 2");
        //}
        #endregion

        #region Session
        /// <summary>
        /// Stores in server memory and is available for the entire user session
        /// exist until the session expires or is explicitly cleared.
        /// sensitve data that should not be stored on the client side, such as user authentication information or shopping cart contents, should be stored in session rather than cookies.
        /// </summary>


        //public IActionResult SetSession()
        //{
        //    HttpContext.Session.SetString("Message", "This is a message from Session.");
        //    HttpContext.Session.SetInt32("Age", 42);
        //    return Content("Session Data Saved Successfully");
        //}

        //public IActionResult GetSession()
        //{
        //    string? message = HttpContext.Session.GetString("Message");
        //    int? age = HttpContext.Session.GetInt32("Age");
        //    return Content($"message: {message}, Age:{age}");
        //}


        #endregion

        #region Cookies
        /// <summary>
        /// Server side state mangement dirctly stored in the client browser, and is sent to the server with each request.
        /// not like Seesion i create it in server side then send it to client browser
        /// we use cookie if i need items to be exist in client browser for long time and i need to access it in multiple sessions, but if i need to store data for short time and only for one session i will use session
        /// all cookies are stored in the client browser, and they are sent to the server with each request. This means that cookies can be accessed by both the client and the server, making them suitable for storing data that needs to persist across multiple sessions or that needs to be accessed by client-side scripts.
        /// cookies affects performance because they are sent with every request, so it's important to keep them small and only use them for necessary data. Additionally, cookies can be a security risk if they contain sensitive information, so it's important to use secure cookies and consider encrypting the data stored in them.(200 cookies)
        /// we have two types of cookies
        /// 1=> session cookies: which are temporary and are deleted when the browser is closed. They do not have an expiration date set.
        /// 2=> persistent cookies: which are stored on the user's device and remain there until they expire or are deleted by the user. They have an expiration date set, which can be a specific date or a duration (e.g., 30 days).
        /// </summary>

        public IActionResult SetCookie()
        {
            // set cookies with Respose as it set in client browser
            Response.Cookies.
                Append("Message", "This is a message from Cookies.", new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddMinutes(1) // Set the cookie to expire in 1 minute
                });
            Response.Cookies.Append("Age", "42");
            return Content("Cookie Data Saved Successfully");

        }

        public IActionResult GetCookie()
        {
            // get cookies with Request as it get from client browser
            string? message = Request.Cookies["Message"];
            string? age = Request.Cookies["Age"];
            return Content($"message: {message}, Age:{age}");
        }

        #endregion
    }
}