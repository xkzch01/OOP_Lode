﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;


namespace OOP_Ships
{
    public class SectorA
    {
        public int X_Coord { get; set; }
        public int Y_Coord { get; set; }
        public string[,] sectorA = new string [10, 10];

        // constructor, each time button is clicked,
        // generate this field, since I dont find better
        // solution how to store data like in function main
        //button click always ends and new one begins
        public SectorA()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(shipsPositions(i, j))
                    {
                        sectorA[i, j] = "X";
                    }
                    else
                    sectorA[i, j] = "O";
                }
            }
        }

        // Player B manually sets the position of his ships in sectorA
        public bool shipsPositions(int i, int j)
        {
            if (i == 0 && j == 0)
            { return true; }
            if (i == 1 && j == 1)
            { return true; }
            if (i == 2 && j == 2)
            { return true; }
            if (i == 3 && j == 3)
            { return true; }
            if (i == 4 && j == 4)
            { return true; }
            return false;
        }

        //determine if the given coords hit the ship or not
        public bool attackShip(int x, int y)
        {
            x = x - 1;
            y = y - 1;
            if (sectorA[x, y] == "X")
            { return true; }
            else
            { return false; }
        }
    }
}