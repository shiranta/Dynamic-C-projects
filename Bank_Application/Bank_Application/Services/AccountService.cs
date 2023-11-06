using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank_Application.Services
{
    public class AccountService: MarshalByRefObject
    {
       
        public uint CreateBankAccount(uint UserId)
        {
            //GetAccountInterface() is interface but Real name is Facade 
            uint AccountId = Database.Instance.GetAccountInterface().CreateAccount(UserId) ;
            Database.Instance.SaveToDisk();
            return AccountId;

        }
        //This method is used to Deposit money the Account
        public void DepositCash(uint amount, uint accid)
        {
            //GetAccountInterface() is interface but Real name is Facade 
            Database.Instance.GetAccountInterface().SelectAccount(accid);
            Database.Instance.GetAccountInterface().Deposit(amount);
            Database.Instance.SaveToDisk();
         
        }
        //This method is used to cash withdraw from the account
        public void WithdrawMoney(uint amount, uint accid)
        {
            Database.Instance.GetAccountInterface().SelectAccount(accid);
            Database.Instance.GetAccountInterface().Withdraw(amount);
            Database.Instance.SaveToDisk();

        }
        //DispAllAccBelongToUser Method is used to find the all Account assciate to the Person
        public List<uint> DispAllAccBelongToUser(uint userid)
        {
           return  Database.Instance.GetAccountInterface().GetAccountIDsByUser(userid);

        }
        //DispBalBlongToUserAcc method is used to check the balance amount in the Account

        public uint DispBalBlongToUserAcc(uint accid)
        {
            Database.Instance.GetAccountInterface().SelectAccount(accid);
            uint balamt= Database.Instance.GetAccountInterface().GetBalance();
            return balamt;
        }
        //DispAccOwnerUserID is used find the the owner of the Account
        public uint DispAccOwnerUserID(uint accid)
        {
            Database.Instance.GetAccountInterface().SelectAccount(accid);
            return Database.Instance.GetAccountInterface().GetOwner();

        }






    }
}
