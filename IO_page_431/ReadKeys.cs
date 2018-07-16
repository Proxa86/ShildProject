using System;

namespace IO_page_431
{
    public class ReadKeys
    {
        private ConsoleKeyInfo keyPress;

        public void Page_439()
        {
            Console.WriteLine("Enter muily charts, when you end enter Q");
            do
            {

                keyPress = Console.ReadKey();
                Console.WriteLine("\nYou enter key : "+ keyPress.KeyChar);
                if((ConsoleModifiers.Alt & keyPress.Modifiers) != 0)
                {
                    Console.WriteLine("\nYou key press ALT");
                }
                if ((ConsoleModifiers.Control & keyPress.Modifiers) != 0)
                {
                    Console.WriteLine("\nYou key press CONTROL");
                }
                if ((ConsoleModifiers.Shift & keyPress.Modifiers) != 0)
                {
                    Console.WriteLine("\nYou key press SHIFT");
                }
            } while (keyPress.KeyChar != 'Q');
        }
    }
}