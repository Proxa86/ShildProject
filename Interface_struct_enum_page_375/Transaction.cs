using System;
using System.Globalization;

namespace Interface_struct_enum_page_375
{
    public class Transaction
    {
        private static uint _transacNum = 0;
        private PacketHeader _ph;
        private string _accountNum;
        private double _amount;

        public Transaction(string acc, double val)
        {
            _ph.PackNum = _transacNum++;
            _ph.PackLen = 512;
            _accountNum = acc;
            _amount = val;
        }

        public void SendTransaction()
        {
            Console.WriteLine("Packet #: "+_ph.PackNum+
                              ", Length: "+ _ph.PackLen+
                              ",\n Score: "+ _accountNum+
                              ", Sum: {0:C}\n",_amount);
        }
    }
}