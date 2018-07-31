using System;

namespace Exception_page_403
{
    public class ExceptA : Exception
    {
        public ExceptA(string str) : base(str)
        {
        }

        public override string ToString()
        {
            return Message;
        }
    }
}