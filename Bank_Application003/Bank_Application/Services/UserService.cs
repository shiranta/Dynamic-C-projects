using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Bank_Application.Services
{
    [Serializable()]
    public class UserService : MarshalByRefObject
    {

        //static BankDB.BankDB db = new BankDB.BankDB();
        //Genarate the  DB instance is dificult frequently .There fore it serves as Service 
        //public int sum(int a, int b)
        //{
        //    return a + b;
        //}    
        // Due to errors add a small function check the behavior
        //Create Bank user method is used to create users

        public uint CreateBankUser(User user)
        {
            //GetUserAccess() is interface but Real name is Facade 
            uint userId = DbService.Instance.GetUserAccess().CreateUser();
            DbService.Instance.SaveToDisk();
            DbService.Instance.GetUserAccess().SelectUser(userId);
            DbService.Instance.GetUserAccess().SetUserName(user.FirstName, user.LastName);
            DbService.Instance.SaveToDisk();

            return userId;

        }
        //GetBankuser method is used to find concatanate of First ane and last name
         public String GetBankUser(uint uid)
        {

            DbService.Instance.GetUserAccess().SelectUser(uid);
            string fname, lname;
            DbService.Instance.GetUserAccess().GetUserName(out fname, out lname);
            return fname + " " + lname;
        }
        //GetAllUsers return the valid user in the DB
        public List<uint> GetAllUsers()
        {

            return DbService.Instance.GetUserAccess().GetUsers();

        }
    
    }
}
