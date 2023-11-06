using System;

namespace DerivedClass
{
    public class WebSite
    {
        public string SiteName;
        public string URL;
        public string Description;

        public WebSite()
        { }
        public WebSite(string strSiteName, string strURL, string strDescription)
        {
            SiteName = strSiteName;
            URL = strURL;
            Description = strDescription;
        }
    }

    abstract public class Contact
    {
        protected string name;
        public Contact()
        { 
            //Initiliaze the Code
        }
        public abstract string generateReport();
        abstract public string Name
        {
            get;
            set;
        }
    }

    public class SiteOwner : Contact
    {
        int siteHits;
        WebSite mySite;
        public SiteOwner()
        {
            mySite = new WebSite();
            siteHits = 0;
        }
        public SiteOwner(string aName, WebSite aSite)
        {
            mySite = new WebSite(aSite.SiteName, aSite.URL, aSite.Description);
                Name = aName;
        
        }
        public override string generateReport()
        {
            return this.ToString();    
        }
        public override string Name
        {
            get
            {
                siteHits++;
                return name;
            }
            set
            {
                name = value;
                siteHits = 0;
            }
        }

        public override string ToString()
        {
            return "["              +
                    Name            +
                    ", "            +
                    siteHits.ToString()+"]";
        }

        public override bool Equals(object anOwner)
        {
            return this.ToString().Equals(anOwner.ToString());
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public SiteOwner Clone()
        {
            return (SiteOwner)this.MemberwiseClone();
        
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            WebSite mySite = new WebSite("Srilal Fonseka", "www.google.com", "Human Resources Site");

            SiteOwner firstOwner = new SiteOwner("Fonseka", mySite);
            SiteOwner secondOwner = firstOwner.Clone();
            Console.WriteLine("Report     :       {0}",
                            firstOwner.generateReport());
            Console.WriteLine("To String  :       {0}",
                            firstOwner.Clone());

            Console.WriteLine("Hash Code  :       {0}",
                           firstOwner.GetHashCode());

            Console.WriteLine("Report     :       {0}",
                            secondOwner.generateReport());
            Console.WriteLine("To String  :       {0}",
                            secondOwner.Clone());

            Console.WriteLine("Hash Code  :       {0}",
                          secondOwner.GetHashCode());

            Console.WriteLine(
                "1st Owner :{0} equals: {1} 2nd owner :{2}.",
                firstOwner.Name,
                firstOwner.Equals(secondOwner),
                secondOwner.Name);

            Console.WriteLine(
                "2nd Equality Check :{0}",
                firstOwner.Equals(secondOwner));

            Console.WriteLine("Report:   {0}",
                firstOwner.generateReport());
            Console.WriteLine("To String :  {0}",
                firstOwner.ToString());
            Console.WriteLine("Hash code   :{0}",
                firstOwner.GetHashCode());

            Console.WriteLine("Report:   {0}",
                secondOwner.generateReport());
            Console.WriteLine("To String :  {0}",
                 secondOwner.ToString());
            Console.WriteLine("Hash code   :{0}",
                 secondOwner.GetHashCode());

            Console.ReadLine();


        }
    }
}
