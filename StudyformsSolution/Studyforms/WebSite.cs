using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studyforms
{
    public class WebSite
    {
        string SiteName;
        string URL;
        string Description;

        public WebSite()
            : this("No Site", "No URL", "No Description") { }
        public WebSite(string newSite)
            : this(newSite, "No URL", "No Description") { }

        public WebSite(string newSite,string newURL)
            : this(newSite, newURL, "No Description") { }
        public WebSite(string newSite,string newURL,string newDesc)
        {
            SiteName = newSite;
            URL = newURL;
            Description = newDesc;


        }
    }
}
