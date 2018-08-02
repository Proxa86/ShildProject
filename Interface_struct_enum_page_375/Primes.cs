namespace Interface_struct_enum_page_375
{
    public class Primes: ISeries
    {
        private int _start;
        private int _val;

        public Primes()
        {
            _start = 2;
            _val = 2;
        }

        public int GetNext()
        {
            bool isprime;
            _val++;
            
            for (int i = _val; i < 1000000; i++)
            {
                isprime = true;
                for (int j = 2; j <= i / j; j++)
                {
                    if ((i % j) == 0)
                    {
                        isprime = false;
                        break;
                    }
                }

                if (isprime)
                {
                    _val = i;
                    break;
                }
            }

            return _val;
        }

        public void Reset()
        {
            _val = _start;
        }

        public void SetStart(int x)
        {
            _start = x;
            _val = _start;
        }
    }
}