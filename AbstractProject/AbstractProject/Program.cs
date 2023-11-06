using System;

namespace AbstractProject
{
    public class WebSite
    {
        public string SiteName;
        public string URL;
        public string Description;

        public WebSite()
        { }
        public WebSite(string strSiteName,string strURL,string strDescription)
        {
            SiteName = strSiteName;
            URL = strURL;
            Description = strDescription;
        }
    }

    abstract public class Contact
    {
        public string name;
        public Contact()
        { }
        public abstract string generateReport();

        abstract public string Name
        {
            get;
            set;
        }
    }

        public class SiteOwner:Contact
        {
            int siteHits;
            WebSite mySite;
            public SiteOwner()
            {
                mySite = new WebSite();
                siteHits = 0;
                           
            }
           public SiteOwner(string aName,WebSite aSite)
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
            return "[" +
                    Name + "  "+
                    siteHits.ToString() +
                    "]";
                
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
            WebSite mySite = new WebSite("Data Stewards", "www.datastewards.com", "Training and Development");

            SiteOwner firstOwner = new SiteOwner("lal", mySite);
            SiteOwner seconowner = firstOwner.Clone();

            Console.WriteLine("Report             {0}", firstOwner.generateReport());
            Console.WriteLine("To String :{0}", firstOwner.ToString());
            Console.WriteLine("Hash Code :{0}", firstOwner.GetHashCode());

            Console.ReadLine();



        
        }
    }
}
