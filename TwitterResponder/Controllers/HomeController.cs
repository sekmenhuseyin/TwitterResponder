using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tweetinvi;

namespace TwitterResponder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var searchParameter = Search.CreateTweetSearchParameter("akp");
            searchParameter.MaximumNumberOfResults = 100;
            searchParameter.Since= new DateTime(2015, 4, 1);
            searchParameter.Until = new DateTime(2015, 4, 5);
            ViewBag.tweets = Search.SearchTweets(searchParameter); 
            
            return View();
        }

    }
}