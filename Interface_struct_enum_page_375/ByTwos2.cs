namespace Interface_struct_enum_page_375
{
    public class ByTwos2: ISeries2
    {
        private int _val;
        
        public ByTwos2()
        {
            _val = 0;
        }
        
        public int Next {
            get => _val +=2;
            set => _val = value;
        }
    }
}