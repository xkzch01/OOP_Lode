using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI.WebControls;

namespace OOP_Ships
{
    public class DetermineField
    {
        public int x_Coordination { get;}
        public int y_Coordination { get;}
        //public string whichSector { get;}

        public DetermineField(string x_Coord, string y_Coord)
        {
            x_Coordination = convertCharacter(x_Coord);
            y_Coordination = Convert.ToInt32(y_Coord);
            //this.whichSector = whichSector;
        }

        

        /* Function that converts Character to number according to sector */
        private int convertCharacter(string s)
        {
            switch(s)
            {
                case "A":
                    return 1;
                case "B":
                    return 2;
                case "C":
                    return 3;
                case "D":
                    return 4;
                case "E":
                    return 5;
                case "F":
                    return 6;
                case "G":
                    return 7;
                case "H":
                    return 8;
                case "I":
                    return 9;
                case "J":
                    return 10;
                default:
                    break;
            }
            return 0;
        }
    }
}