using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application.Services
{
    public sealed  class DbService
    {
        //static BankDB.BankDB db = new BankDB.BankDB();
        //Above mentioned function replaced by Static read only fn
        private static readonly BankDB.BankDB instance =new BankDB.BankDB();
        static DbService()
        {
        }
        private DbService()
        {
        }
        public static BankDB.BankDB Instance
        {
            get
            {
                return instance;
            }
        }
    }


}
