using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tweetinvi;
using TwitterResponder.Models;

namespace TwitterResponder.Controllers
{
    public class HomeController : Controller
    {
        //anasayfa
        public ActionResult Index()
        {
            var searchParameter = Search.CreateTweetSearchParameter("akp");
            searchParameter.MaximumNumberOfResults = 100;
            searchParameter.Since= new DateTime(2015, 4, 1);
            searchParameter.Until = new DateTime(2015, 4, 5);
            ViewBag.tweets = Search.SearchTweets(searchParameter); 
            
            return View();
        }
        //get search results
        public JsonResult GetSearchResults(mdlSearch tmp)
        {
            var searchParameter = Search.CreateTweetSearchParameter(tmp.searchText);
            searchParameter.MaximumNumberOfResults = tmp.searchLimit;
            searchParameter.Since= tmp.searchStartDate;
            searchParameter.Until = tmp.searchEndDate;
            ViewBag.tweets = Search.SearchTweets(searchParameter); 
            return Json("");
        }
    }
}