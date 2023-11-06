using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProjMul
{
    public class WebSite
    {
        const string http = "http://";
        //string siteInfo;
        //string url;
        //string description;

        public WebSite(params string[][] siteInfo)
        {


            Console.WriteLine("Site Name     {0}",siteInfo[0][0]);
            Console.WriteLine("URL           {0}",siteInfo[0][1]);
            Console.WriteLine("Description   {0}",siteInfo[0][2]);
            Console.WriteLine();

            Console.WriteLine("Site Name     {0}",siteInfo[1][0]);
            Console.WriteLine("URL           {0}",siteInfo[1][1]);
            Console.WriteLine("Description   {0}",siteInfo[1][2]);


            Console.ReadKey();

        }

        public static void Main()
        {
            string[][] siteInfomy = new string[2][];

            siteInfomy[0] = new string[]

            { "A data Site",
                "www.datastewards.com",
                "Data Analysis"};

            siteInfomy[1] = new string[]

                { "Foreign",
                "www.travellers.com",
                "travel"};

            WebSite mysite = new WebSite(siteInfomy);


        }

    }


}
