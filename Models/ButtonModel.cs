using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOP_Ships_Project.Models
{
    public class ButtonModel
    {
        public int State { get; set; }

        public ButtonModel(int state)
        {
            State = state;
        }

    }
    public class ShipsModel
    {
        public int CurrentStanding { get; set; }
        public ShipsModel(int state)
        {
            CurrentStanding = state;
        }
    }
}