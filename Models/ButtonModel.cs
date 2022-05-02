using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOP_Ships_Project.Models
{
    public class DataModel
    {
        public int State { get; set; }

        public DataModel(int state)
        {
            State = state;
        }

    }
}