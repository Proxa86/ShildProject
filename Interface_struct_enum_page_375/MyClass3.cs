namespace Interface_struct_enum_page_375
{
    public class MyClass3: IMyIF_A, IMyIF_B
    {
        // private
        int IMyIF_A.Meth(int x)
        {
            return x + x;
        }
        
        // private
        int IMyIF_B.Meth(int x)
        {
            return x * x;
        }

        // Мы делаем открытые методы, чтобы через них вызывать закрытые (явная реализация)
        // интерфейсов
        
        public int MathA(int x)
        {
            IMyIF_A aOb = this;
            return aOb.Meth(x);
        }

        public int MathB(int x)
        {
            IMyIF_B bOb = this;
            return bOb.Meth(x);
        }
    }
}