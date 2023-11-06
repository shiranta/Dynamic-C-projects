using System;

namespace DbLib
{
    internal class DataGenerator
    {
        
        private string GetFirstname()
        {
            string[] fname = new string[] { "Sam", "Mark", "Frank", "Tom", "Dana", "Ellen", "Christy" }; //First Name array to be used to generat names
            return fname[new Random().Next(fname.Length-1)]; //returns one name from the list
        }
        private string GetLastname()
        {
            string[] lname = new string[] { "Smith", "Brown", "Taylor", "Williams" , "Jones", "Davies" }; //First Name array to be used to generat names
            return lname[new Random().Next(lname.Length - 1)]; //returns one name from the list
        }
        private uint GetPIN()
        {
            return (uint) new Random().Next(1000,9999); // returns a value between 1000 - 9999
        }
        private uint GetAcctNo()
        {
            return (uint)new Random().Next(100000, 999999); // returns a value between 100000 - 999999
        }
        private int GetBalance()
        {
            return new Random().Next(100, 999999); // returns a int value between 100 - 999999
        }
        public void GetNextAccount(out uint pin, out uint acctNo, out string firstName, out string lastName, out int balance)
        {
            pin = GetPIN();
            acctNo = GetAcctNo();
            firstName = GetFirstname();
            lastName = GetLastname();
            balance = GetBalance();
        }
    }
}
