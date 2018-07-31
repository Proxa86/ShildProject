using System.Runtime.Serialization.Formatters;

namespace Exception_page_403
{
    public class RangeArray
    {
        private int[] a;
        private int lowerBound;
        private int upperBound;
       
        public int Length { get; set; }

        public RangeArray(int low, int high)
        {
            high++;
            if(high <= low)
                throw new RangeArrayException("Low index can not be less high index.");
            a =  new int[high-low];
            Length = high - low;
            lowerBound = low;
            upperBound = --high;
        }

        public int this[int index]
        {
            get
            {
                if (Ok(index))
                    return a[index - lowerBound];
                else
                {
                    throw new RangeArrayException("Error outside bounds.");
                }
            }
            set
            {
                if (Ok(index))
                    a[index - lowerBound] = value;
                else
                {
                    throw new RangeArrayException("Error outside bounds");
                }
            }
        }

        private bool Ok(int index)
        {
            if (index >= lowerBound & index <= upperBound) return true;
            else return false;
        }
        
    }
}