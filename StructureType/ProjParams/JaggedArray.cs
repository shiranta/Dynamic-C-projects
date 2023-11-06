using System;

namespace ProjParams
{

    public class WebSite
    {
        const string http = "http://";

        string siteName;
        string url;
        string description;

        public WebSite(params string[] siteInfo)
        {
            siteName=siteInfo[0];
            url = siteInfo[1];
            description = siteInfo[2];

            Console.WriteLine("Site Name:            {0}", siteName);
            Console.WriteLine("URL:            {0}", url);
            Console.WriteLine("Description:            {0}", description);
            Console.ReadLine();
         }
        



    }
    class JaggedArray
    {
        static void Main(string[] args)
        {
            string[] siteInfo = new string[3]
            {

                "A new Site",
                 "www.newsite.com",
                  "The Newst site on the web"
            };

            WebSite webSite = new WebSite(siteInfo);
        
        }
    }
}
