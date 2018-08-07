namespace Interface_struct_enum_page_375
{
    public class PacketDemo
    {
        public void Page_396()
        {
            Transaction transaction1 =  new Transaction("31243", -100.12);
            Transaction transaction2 =  new Transaction("AB4655", 345.24);
            Transaction transaction3 = new Transaction("8475-09", 9800.00);
            
            transaction1.SendTransaction();
            transaction2.SendTransaction();
            transaction3.SendTransaction();
        }
    }
}