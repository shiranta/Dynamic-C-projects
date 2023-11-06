using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProj
{
    public class WebSite
    {
        const string http= "http://";
        string siteName;
        string url;
        string description;

        public WebSite(params string[] siteInfo)
        {
            siteName = siteInfo[0];
            url = siteInfo[1];
            description = siteInfo[2];

            Console.WriteLine("Site Name     {0}", siteName);
            Console.WriteLine("URL           {0}", url);
            Console.WriteLine("Description   {0}", description);
            Console.ReadKey();

        }

        public static void Main()
        {
            string[] siteInfomy = new string[3]
            { "A data Site",
                "www.datastewards.com",
                "Data Analysis"};
            WebSite mysite = new WebSite(siteInfomy);


        }

    }

    
}
