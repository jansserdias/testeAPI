using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var newsApiClient = new NewsApiClient("0b2aa7e245034bbb9a111ca517a278f7");
            var response = newsApiClient.GetEverything(new EverythingRequest
            {
                SortBy = SortBys.Popularity,                
            });
            if (response.Status == Statuses.Ok)
            {
                foreach (var article in response.Articles)
                {
                    // title
                    Console.WriteLine(article.Title);
                    // author
                    Console.WriteLine(article.Author);
                    // description
                    Console.WriteLine(article.Description);
                }
            }
            Console.ReadLine();
        }
    }
}