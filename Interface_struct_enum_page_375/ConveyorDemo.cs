using System;

namespace Interface_struct_enum_page_375
{
    public class ConveyorDemo
    {
        public void Page_400()
        {
            ConveyorControl c =  new ConveyorControl();
            c.Conveyor(ConveyorControl.Action.Start);
            c.Conveyor(ConveyorControl.Action.Stop);
            c.Conveyor(ConveyorControl.Action.Forward);
            c.Conveyor(ConveyorControl.Action.Reverse);
            c.Conveyor(3);
        }
    }
}