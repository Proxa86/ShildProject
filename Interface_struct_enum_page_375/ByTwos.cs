using System.Runtime.Remoting.Messaging;

namespace Interface_struct_enum_page_375
{
    public class ByTwos:ISeries
    {
        private int _start;
        private int _val;
        private int _prev;

        public ByTwos()
        {
            _start = 0;
            _val = 0;
            _prev = -2;
        }
        
        public int GetNext()
        {
            _prev = _val;
            _val += 2;
            return _val;
        }

        public void Reset()
        {
            _val = _start;
            _prev = _start = -2;
        }

        public void SetStart(int x)
        {
            _start = x;
            _val = _start;
            _prev = _val - 2;
        }

        public int GetPrevious()
        {
            return _prev;
        }
    }
}