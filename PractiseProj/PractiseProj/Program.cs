using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProj
{
    class Program
    {
        public class WebSite
        {
            const string http = "http://";

            //Recived parameter as Value
            //public string Validateurl(string url)

            //Recived parameter as Reference 
            public string Validateurl(ref string url)
            { 
                if(!(url.StartsWith(http)))
                {
                    url = http + url;
                    Console.WriteLine("Within validate url:{0}", url);

                }
                return url;
                            
            
            
            }
        
        
        }
        static void Main(string[] args)
        {
            string url = "www.datastewards.com";
            WebSite mySite = new WebSite();

            Console.WriteLine("Before validate URL:{0}", url);
            //passed parameter as Value
            //mySite.Validateurl(url);

            //passed parameter as Reference
            mySite.Validateurl(ref url);

            Console.WriteLine("After validate URL:{0}", url);
            Console.ReadKey();

        }
    }
}
