namespace Inheritance_page_329
{
    public class MyClass
    {
        private static int count = 0;
        private int id;

        public MyClass()
        {
            id = count;
            count++;
        }

        public override string ToString()
        {
            return "Object # " + id + " type MyClass";
        }
    }
}