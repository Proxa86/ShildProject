namespace Inheritance_page_329
{
    public class IncompatibleRef
    {
        public void Page_351()
        {
            X x = new X(10);
            X x2;
            Y y = new Y(5);
            x2 = x;
            //x2 = y;
        }
    }
}