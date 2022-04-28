using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOP_Ships.Ships
{
    public class Drawing
    {
        // set up character which shows sank ship
        public string markAsSank()
        {
            return "X";
            
        }

       /* public string colorOfSank()
        {
            return "System.Drawing.Color.Red";
        }*/

        // set up character which shows only water
        public string markAsClear()
        {
            return "O";
        }
    }
}