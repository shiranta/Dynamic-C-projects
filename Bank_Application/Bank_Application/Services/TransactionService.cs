using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application.Services
{
    public class TransactionService
    {
        //Method is used to transfer the fund 
        public bool TransferProcess(uint fromacc ,uint toacc ,uint amt)
        {
            //GetTransactionInterface is interface but Real name is Facade 
            uint trnid = Database.Instance.GetTransactionInterface().CreateTransaction();
            Database.Instance.GetTransactionInterface().SetRecvr(fromacc);
            Database.Instance.GetTransactionInterface().SetSendr(toacc);
            Database.Instance.GetTransactionInterface().SetAmount(amt);
            
            return true;

        }

    }
}
