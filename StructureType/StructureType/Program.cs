using System;

namespace StructureType
{

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }


        public static decimal Monthlypayments(decimal rate,
        decimal price,
        int years)
            {
            return rate * price * years / 12;
            }
    }

    public class WebSite
    {
        const string http = "http://";
        string SiteName;
        string url;
        string description;

        //public WebSite(string siteName, string url, string desc)
        //{
        //    this.SiteName = siteName;
        //    this.url =ValidateUrl(url);
        //    this.description = desc;
                   
        //}

        //protected string ValidateUrl(string url)
        //{
        //   if(!(url.StartsWith(http)))
        //    {
        //        return http + url;
               
        //    }
        //    return url;

        
        //}

        //public string ValidateUrlu(ref string url)
        //{
        //    if (!(url.StartsWith(http)))
        //    {
        //        url = http + url;
        //        Console.WriteLine("Within the Validation Url:{0}", url);
        //        return  url;


        //    }
        //    return url;


        //}

        
        public string ValiDateurl(string inUrl, out string outUrl)
        {
            outUrl = inUrl;

            if (!(outUrl.StartsWith(http)))
            {
                outUrl = http + inUrl;
                Console.WriteLine("within validate url:{0}", outUrl);
            }
            return outUrl;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //int i =10;
            //  decimal k = 87993;
            //  string s = "lal";

            //  Customer c1 = new Customer();
            //  c1.ID = 101;
            //  c1.Name = "lala";

            //  Console.WriteLine("Customer Id {0} and  Name {1}", c1.ID, c1.Name);
            //  Console.ReadLine();

            //  Customer c2 = c1;

            //  c2.Name = "Fonseka";

            //  Console.WriteLine("Customer Id {0} and  Name {1}", c2.ID, c2.Name);
            //  Console.ReadLine();

            //  Console.WriteLine("Customer Id {0} and  Name {1}", c1.ID, c1.Name);
            //  Console.ReadLine();

            //  decimal ttlAmt = Customer.Monthlypayments(4, 4000, 12);


            //  Console.WriteLine("total Amount is {0)", ttlAmt);

            //  Console.ReadLine();
            //WebSite Mysite = new WebSite("Cargills", "cargills.com", "CCL");

            //WebSite TopSite = new WebSite("Ceylinco", "http://Ceylinco.com", "cey");
            string url = "www.newsite.com";
            string outUrl;
            WebSite Mysite = new WebSite();
            Console.WriteLine("Before Validate URl:{0}", url);
            string v = Mysite.ValiDateurl(url, out outUrl);
            Console.WriteLine("After Validate URl:{0}", outUrl);
            Console.ReadLine();
                  





        }
    }
}

