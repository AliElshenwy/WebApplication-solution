using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class MovieController : Controller
    {
        // Action ==> Public NOn Static Func ==> Movie/ GetMovie
        public IActionResult  MovieGet(int id)
        {
            //ContentResult result = new ContentResult();
            //result.Content= $"Movie With Id = {id}";
            //result.ContentType = "object/pdf";
            //return result;

            return Content($"Movie With id ={id}", " text/html");
        }

        public RedirectResult Index() 
            {
            //RedirectResult redirectResult = new RedirectResult("https://localhost:5001/Movie/GetMovie/10");
            //return redirectResult;

            return  Redirect("https://localhost:5001/Movie/GetMovie/10" );

            }


        public ViewResult Hamada() 
        {
        return View();
        }
    }
}
