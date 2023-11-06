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
        //Bank Account create for the User
        public uint CreateBankAccount(uint UserId)
        {
            //GetAccountInterface() is interface but Real name is Facade 
            uint AccountId = DbService.Instance.GetAccountInterface().CreateAccount(UserId) ;
            DbService.Instance.SaveToDisk();
            return AccountId;

        }
        //This method is used to Deposit money the Account
        public void DepositCash(uint amount, uint accid)
        {
            //GetAccountInterface() is interface but Real name is Facade 
            DbService.Instance.GetAccountInterface().SelectAccount(accid);
            DbService.Instance.GetAccountInterface().Deposit(amount);
            DbService.Instance.SaveToDisk();
         
        }
        //This method is used to cash withdraw from the account
        public void WithdrawMoney(uint amount, uint accid)
        {
            DbService.Instance.GetAccountInterface().SelectAccount(accid);
            DbService.Instance.GetAccountInterface().Withdraw(amount);
            DbService.Instance.SaveToDisk();

        }
        //DispAllAccBelongToUser Method is used to find the all Account assciate to the Person
        public List<uint> DispAllAccBelongToUser(uint userid)
        {
           return  DbService.Instance.GetAccountInterface().GetAccountIDsByUser(userid);

        }
        //DispBalBlongToUserAcc method is used to check the balance amount in the Account

        public uint DispBalBlongToUserAcc(uint accid)
        {
            DbService.Instance.GetAccountInterface().SelectAccount(accid);
            uint balamt= DbService.Instance.GetAccountInterface().GetBalance();
            return balamt;
        }
        //DispAccOwnerUserID is used find the the owner of the Account
        public uint DispAccOwnerUserID(uint accid)
        {
            DbService.Instance.GetAccountInterface().SelectAccount(accid);
            return DbService.Instance.GetAccountInterface().GetOwner();

        }






    }
}
