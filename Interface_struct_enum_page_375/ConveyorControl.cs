using System;
using System.ComponentModel;

namespace Interface_struct_enum_page_375
{
    public class ConveyorControl
    {
        public enum Action{Start, Stop, Forward, Reverse}

        public void Conveyor(Action com)
        {
            switch (com)
            {
                    case Action.Start:
                        Console.WriteLine("Start container.");
                        break;
                    case Action.Stop:
                        Console.WriteLine("Stop container.");
                        break;
                    case Action.Forward:
                        Console.WriteLine("Move container forward.");
                        break;
                    case Action.Reverse:
                        Console.WriteLine("Move conteiner reverse.");
                        break;                       
            }

        }

        public void Conveyor(int n)
        {
            switch (n)
            {
                    case 3:
                        Console.WriteLine((Action)3);
                        break;
            }
        }
    }
}