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
            uint trnid = DbService.Instance.GetTransactionInterface().CreateTransaction();
            DbService.Instance.GetTransactionInterface().SetRecvr(fromacc);
            DbService.Instance.GetTransactionInterface().SetSendr(toacc);
            DbService.Instance.GetTransactionInterface().SetAmount(amt);
            
            return true;

        }

    }
}
