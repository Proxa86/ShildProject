namespace Interface_struct_enum_page_375
{
    public class ByTwos3
    {
        private int _val;

        public ByTwos3()
        {
            _val = 0;
        }

        public int Next
        {
            get => _val += 2;
            set => _val = value;
        }

        public int this[int index]
        {
            get
            {
                _val = 0;
                for (int i = 0; i < index; i++)
                    _val += 2;
                return _val;
            }
        }
    }
}