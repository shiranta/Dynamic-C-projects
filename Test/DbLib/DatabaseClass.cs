using DbLib;
using System;
using System.Collections.Generic;

namespace DbLib
{
    public class DatabaseClass
    {
        List<DataStruct> dataStruct;
        public DatabaseClass()
        {
            dataStruct = new List<DataStruct>();

            //generate 10 records
            for (int i = 0; i < 10; i++)
            {
                //-- Get Data from Generated Record
                uint argpin, argacctNo;
                string argfirstName, arglastName;
                int argbalance;
                new DataGenerator().GetNextAccount(out argpin, out argacctNo, out argfirstName, out arglastName, out argbalance);

                //---------Create a record and to array ----//
                DataStruct dataRecord = new DataStruct();
                dataRecord.firstName = argfirstName;
                dataRecord.lastName = arglastName;
                dataRecord.acctNo = argacctNo;
                dataRecord.pin = argpin;
                dataRecord.balance = argbalance;

                dataStruct.Add(dataRecord); //Add to array

                //---------------------------------------//

                //-- Single line solution for above "Create a record"
                //dataStruct.Add(new DataStruct { pin = argpin, firstName = argfirstName, lastName = arglastName, acctNo = argacctNo, balance = argbalance });
            }
            dataStruct.ForEach(x => Console.WriteLine("Name=" +x.firstName+","+x.lastName + ", Account=" + x.acctNo + ", Pin=" + x.pin + ", Balance=" + x.balance ));
            Console.ReadLine();
        }

        public uint GetAcctNoByIndex(int index)
        {
            //return index < GetNumRecords()-1 ? dataStruct[index].acctNo : (uint)0;
            return dataStruct[index].acctNo;
        }
        public uint GetPINByIndex(int index)
        {
            return dataStruct[index].acctNo;
        }
        public string GetFirstNameByIndex(int index)
        {
            return dataStruct[index].firstName;
        }
        public string GetLastNameByIndex(int index)
        {
            return dataStruct[index].lastName;
        }
        public int GetBalanceByIndex(int index)
        {
            return dataStruct[index].balance;
        }
        public int GetNumRecords()
        {
            return dataStruct.Count;
        }

    }
}
