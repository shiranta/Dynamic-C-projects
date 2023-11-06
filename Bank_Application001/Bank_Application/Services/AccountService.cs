using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank_Application.Services
{
    public class AccountService: MarshalByRefObject
    {
        //static BankDB.BankDB db = new BankDB.BankDB();
        public uint CreateBankAccount(uint UserId)
        {
            //GetUserAccess() is interface but Real name is Facade 
            uint AccountId = DbService.Instance.GetAccountInterface().CreateAccount(UserId) ;
            DbService.Instance.SaveToDisk();
                   

            return AccountId;

        }

        public void DepositCash(uint amount, uint accid)
        {
            //GetUserAccess() is interface but Real name is Facade 
            DbService.Instance.GetAccountInterface().SelectAccount(accid);
            DbService.Instance.GetAccountInterface().Deposit(amount);
            DbService.Instance.SaveToDisk();
            



            //return AccountId;

        }


    }
}
