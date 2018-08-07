namespace Interface_struct_enum_page_375
{
    public class MyClass2:IEven
    {
        // Явная реализация, private и указывается имя интерфейса явно 
        
        bool IEven.IsOdd(int x)
        {
            if ((x % 2) != 0) return true;
            else return false;
        }

        // Не явная реализация, создаем ссылку на интерфейс и указываем текущий класс
        // Через данную сслыку мы можем обратиться к любому методу определенному в 
        // этом интерфейсе
        
        public bool IsEven(int x)
        {
            IEven o = this;
            return !o.IsOdd(x);
        }
    }
}