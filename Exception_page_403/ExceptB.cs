namespace Exception_page_403
{
    public class ExceptB: ExceptA
    {

        public ExceptB(string str) : base(str)
        {
        }

        public override string ToString()
        {
            return Message;
        }
    }
}