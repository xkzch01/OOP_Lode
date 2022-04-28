using OOP_Ships.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace OOP_Ships
{
    public partial class Grid : System.Web.UI.Page
    {
        /* for setting position of ships go to method shipsPositions() in sectorA-B */
        
        private int X_Coord;
        private int Y_Coord;
        //private string whichSector;
        Drawing draw = new Drawing();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void PlayerA_Attack(object sender, EventArgs e)
        {
            
            SectorA sectorA = new SectorA();

            /* determine one single field */
            DetermineField attack = new DetermineField(txtbox_Coordination_X_PlayerA.Text.ToUpper(), txtbox_Coordination_Y_PlayerA.Text);

            /* saves coords locally */
            X_Coord = attack.x_Coordination;
            Y_Coord = attack.y_Coordination;
            //whichSector = attack.whichSector;

            /* determine if the given coords hit the ship or not */
            bool attackSuccess = sectorA.attackShip(X_Coord, Y_Coord);

            /* THE HORRIBLE switch which updates players grid, I dont find better solution since
               I dont know how to store data in this web app, all atempts failed, data was always reseted

               collapse each X_coord case for better view on code */
            switch (X_Coord)
            {
                case 1: // Button AA1 - AA10
                    {
                        switch (Y_Coord)
                        {
                            case 1:
                                {   if (attackSuccess == true)
                                         { ButtonAA1.Text = draw.markAsSank();
                                           ButtonAA1.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAA1.Text = draw.markAsClear();
                                           ButtonAA1.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 2:
                                {   if (attackSuccess == true)
                                         { ButtonAA2.Text = draw.markAsSank();
                                           ButtonAA2.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAA2.Text = draw.markAsClear();
                                           ButtonAA2.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 3:
                                {   if (attackSuccess == true)
                                         { ButtonAA3.Text = draw.markAsSank();
                                           ButtonAA3.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAA3.Text = draw.markAsClear();
                                           ButtonAA3.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 4:
                                {   if (attackSuccess == true)
                                         { ButtonAA4.Text = draw.markAsSank();
                                           ButtonAA4.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAA4.Text = draw.markAsClear();
                                           ButtonAA4.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 5:
                                {   if (attackSuccess == true)
                                         { ButtonAA5.Text = draw.markAsSank();
                                           ButtonAA5.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAA5.Text = draw.markAsClear();
                                           ButtonAA5.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 6:
                                {   if (attackSuccess == true)
                                         { ButtonAA6.Text = draw.markAsSank();
                                           ButtonAA6.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAA6.Text = draw.markAsClear();
                                           ButtonAA6.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 7:
                                {   if (attackSuccess == true)
                                         { ButtonAA7.Text = draw.markAsSank();
                                           ButtonAA7.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAA7.Text = draw.markAsClear();
                                           ButtonAA7.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 8:
                                {   if (attackSuccess == true)
                                         { ButtonAA8.Text = draw.markAsSank();
                                           ButtonAA8.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAA8.Text = draw.markAsClear();
                                           ButtonAA8.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 9:
                                {   if (attackSuccess == true)
                                         { ButtonAA9.Text = draw.markAsSank();
                                           ButtonAA9.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAA9.Text = draw.markAsClear();
                                           ButtonAA9.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 10:
                                {   if (attackSuccess == true)
                                         { ButtonAA10.Text = draw.markAsSank();
                                           ButtonAA10.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAA10.Text = draw.markAsClear();
                                           ButtonAA10.BackColor = System.Drawing.Color.Aqua; } break; }
                            default:
                                break;
                        }
                        break;
                    }
                case 2: // Button AB1 - AB10
                    {
                        switch (Y_Coord)
                        {
                            case 1:
                                {   if (attackSuccess == true)
                                         { ButtonAB1.Text = draw.markAsSank();
                                           ButtonAB1.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAB1.Text = draw.markAsClear();
                                           ButtonAB1.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 2:
                                {   if (attackSuccess == true)
                                         { ButtonAB2.Text = draw.markAsSank();
                                           ButtonAB2.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAB2.Text = draw.markAsClear();
                                           ButtonAB2.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 3:
                                {   if (attackSuccess == true)
                                         { ButtonAB3.Text = draw.markAsSank();
                                           ButtonAB3.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAB3.Text = draw.markAsClear();
                                           ButtonAB3.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 4:
                                {   if (attackSuccess == true)
                                         { ButtonAB4.Text = draw.markAsSank();
                                           ButtonAB4.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAB4.Text = draw.markAsClear();
                                           ButtonAB4.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 5:
                                {   if (attackSuccess == true)
                                         { ButtonAB5.Text = draw.markAsSank();
                                           ButtonAB5.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAB5.Text = draw.markAsClear();
                                           ButtonAB5.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 6:
                                {   if (attackSuccess == true)
                                         { ButtonAB6.Text = draw.markAsSank();
                                           ButtonAB6.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAB6.Text = draw.markAsClear();
                                           ButtonAB6.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 7:
                                {   if (attackSuccess == true)
                                         { ButtonAB7.Text = draw.markAsSank();
                                           ButtonAB7.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAB7.Text = draw.markAsClear();
                                           ButtonAB7.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 8:
                                {   if (attackSuccess == true)
                                         { ButtonAB8.Text = draw.markAsSank();
                                           ButtonAB8.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAB8.Text = draw.markAsClear();
                                           ButtonAB8.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 9:
                                {   if (attackSuccess == true)
                                         { ButtonAB9.Text = draw.markAsSank();
                                           ButtonAB9.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAB9.Text = draw.markAsClear();
                                           ButtonAB9.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 10:
                                {   if (attackSuccess == true)
                                         { ButtonAB10.Text = draw.markAsSank();
                                           ButtonAB10.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAB10.Text = draw.markAsClear();
                                           ButtonAB10.BackColor = System.Drawing.Color.Aqua; } break; }
                            default:
                                break;
                        }
                        break;
                    }
                case 3: // Button AC1 - AC10
                    {
                        switch (Y_Coord)
                        {
                            case 1:
                                {   if (attackSuccess == true)
                                         { ButtonAC1.Text = draw.markAsSank();
                                           ButtonAC1.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAC1.Text = draw.markAsClear();
                                           ButtonAC1.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 2:
                                {   if (attackSuccess == true)
                                         { ButtonAC2.Text = draw.markAsSank();
                                           ButtonAC2.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAC2.Text = draw.markAsClear();
                                           ButtonAC2.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 3:
                                {   if (attackSuccess == true)
                                         { ButtonAC3.Text = draw.markAsSank();
                                           ButtonAC3.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAC3.Text = draw.markAsClear();
                                           ButtonAC3.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 4:
                                {   if (attackSuccess == true)
                                         { ButtonAC4.Text = draw.markAsSank();
                                           ButtonAC4.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAC4.Text = draw.markAsClear();
                                           ButtonAC4.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 5:
                                {   if (attackSuccess == true)
                                         { ButtonAC5.Text = draw.markAsSank();
                                           ButtonAC5.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAC5.Text = draw.markAsClear();
                                           ButtonAC5.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 6:
                                {   if (attackSuccess == true)
                                         { ButtonAC6.Text = draw.markAsSank();
                                           ButtonAC6.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAC6.Text = draw.markAsClear();
                                           ButtonAC6.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 7:
                                {   if (attackSuccess == true)
                                         { ButtonAC7.Text = draw.markAsSank();
                                           ButtonAC7.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAC7.Text = draw.markAsClear();
                                           ButtonAC7.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 8:
                                {   if (attackSuccess == true)
                                         { ButtonAC8.Text = draw.markAsSank();
                                           ButtonAC8.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAC8.Text = draw.markAsClear();
                                           ButtonAC8.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 9:
                                {   if (attackSuccess == true)
                                         { ButtonAC9.Text = draw.markAsSank();
                                           ButtonAC9.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAC9.Text = draw.markAsClear();
                                           ButtonAC9.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 10:
                                {   if (attackSuccess == true)
                                         { ButtonAC10.Text = draw.markAsSank();
                                           ButtonAC10.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAC10.Text = draw.markAsClear();
                                           ButtonAC10.BackColor = System.Drawing.Color.Aqua; } break; }
                            default:
                                break;
                        }
                        break;
                    }
                case 4: // Button AD1 - AD10
                    {
                        switch (Y_Coord)
                        {
                            case 1:
                                {   if (attackSuccess == true)
                                         { ButtonAD1.Text = draw.markAsSank();
                                           ButtonAD1.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAD1.Text = draw.markAsClear();
                                           ButtonAD1.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 2:
                                {   if (attackSuccess == true)
                                         { ButtonAD2.Text = draw.markAsSank();
                                           ButtonAD2.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAD2.Text = draw.markAsClear();
                                           ButtonAD2.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 3:
                                {   if (attackSuccess == true)
                                         { ButtonAD3.Text = draw.markAsSank();
                                           ButtonAD3.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAD3.Text = draw.markAsClear();
                                           ButtonAD3.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 4:
                                {   if (attackSuccess == true)
                                         { ButtonAD4.Text = draw.markAsSank();
                                           ButtonAD4.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAD4.Text = draw.markAsClear();
                                           ButtonAD4.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 5:
                                {   if (attackSuccess == true)
                                         { ButtonAD5.Text = draw.markAsSank();
                                           ButtonAD5.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAD5.Text = draw.markAsClear();
                                           ButtonAD5.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 6:
                                {   if (attackSuccess == true)
                                         { ButtonAD6.Text = draw.markAsSank();
                                           ButtonAD6.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAD6.Text = draw.markAsClear();
                                           ButtonAD6.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 7:
                                {   if (attackSuccess == true)
                                         { ButtonAD7.Text = draw.markAsSank();
                                           ButtonAD7.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAD7.Text = draw.markAsClear();
                                           ButtonAD7.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 8:
                                {   if (attackSuccess == true)
                                         { ButtonAD8.Text = draw.markAsSank();
                                           ButtonAD8.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAD8.Text = draw.markAsClear();
                                           ButtonAD8.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 9:
                                {   if (attackSuccess == true)
                                         { ButtonAD9.Text = draw.markAsSank();
                                           ButtonAD9.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAD9.Text = draw.markAsClear();
                                           ButtonAD9.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 10:
                                {   if (attackSuccess == true)
                                         { ButtonAD10.Text = draw.markAsSank();
                                           ButtonAD10.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAD10.Text = draw.markAsClear();
                                           ButtonAD10.BackColor = System.Drawing.Color.Aqua; } break; }
                            default:
                                break;
                        }
                        break;
                    }
                case 5: // Button AE1 - AE10
                    {
                        switch (Y_Coord)
                        {
                            case 1:
                                {   if (attackSuccess == true)
                                         { ButtonAE1.Text = draw.markAsSank();
                                           ButtonAE1.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAE1.Text = draw.markAsClear();
                                           ButtonAE1.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 2:
                                {   if (attackSuccess == true)
                                         { ButtonAE2.Text = draw.markAsSank();
                                           ButtonAE2.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAE2.Text = draw.markAsClear();
                                           ButtonAE2.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 3:
                                {   if (attackSuccess == true)
                                         { ButtonAE3.Text = draw.markAsSank();
                                           ButtonAE3.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAE3.Text = draw.markAsClear();
                                           ButtonAE3.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 4:
                                {   if (attackSuccess == true)
                                         { ButtonAE4.Text = draw.markAsSank();
                                           ButtonAE4.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAE4.Text = draw.markAsClear();
                                           ButtonAE4.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 5:
                                {   if (attackSuccess == true)
                                         { ButtonAE5.Text = draw.markAsSank();
                                           ButtonAE5.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAE5.Text = draw.markAsClear();
                                           ButtonAE5.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 6:
                                {   if (attackSuccess == true)
                                         { ButtonAE6.Text = draw.markAsSank();
                                           ButtonAE6.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAE6.Text = draw.markAsClear();
                                           ButtonAE6.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 7:
                                {   if (attackSuccess == true)
                                         { ButtonAE7.Text = draw.markAsSank();
                                           ButtonAE7.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAE7.Text = draw.markAsClear();
                                           ButtonAE7.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 8:
                                {   if (attackSuccess == true)
                                         { ButtonAE8.Text = draw.markAsSank();
                                           ButtonAE8.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAE8.Text = draw.markAsClear();
                                           ButtonAE8.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 9:
                                {   if (attackSuccess == true)
                                         { ButtonAE9.Text = draw.markAsSank();
                                           ButtonAE9.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAE9.Text = draw.markAsClear();
                                           ButtonAE9.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 10:
                                {   if (attackSuccess == true)
                                         { ButtonAE10.Text = draw.markAsSank();
                                           ButtonAE10.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAE10.Text = draw.markAsClear();
                                           ButtonAE10.BackColor = System.Drawing.Color.Aqua; } break; }
                            default:
                                break;
                        }
                        break;
                    }
                case 6: // Button AF1 - AF10
                    {
                        switch (Y_Coord)
                        {
                            case 1:
                                {   if (attackSuccess == true)
                                         { ButtonAF1.Text = draw.markAsSank();
                                           ButtonAF1.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAF1.Text = draw.markAsClear();
                                           ButtonAF1.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 2:
                                {   if (attackSuccess == true)
                                         { ButtonAF2.Text = draw.markAsSank();
                                           ButtonAF2.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAF2.Text = draw.markAsClear();
                                           ButtonAF2.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 3:
                                {   if (attackSuccess == true)
                                         { ButtonAF3.Text = draw.markAsSank();
                                           ButtonAF3.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAF3.Text = draw.markAsClear();
                                           ButtonAF3.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 4:
                                {   if (attackSuccess == true)
                                         { ButtonAF4.Text = draw.markAsSank();
                                           ButtonAF4.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAF4.Text = draw.markAsClear();
                                           ButtonAF4.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 5:
                                {   if (attackSuccess == true)
                                         { ButtonAF5.Text = draw.markAsSank();
                                           ButtonAF5.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAF5.Text = draw.markAsClear();
                                           ButtonAF5.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 6:
                                {   if (attackSuccess == true)
                                         { ButtonAF6.Text = draw.markAsSank();
                                           ButtonAF6.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAF6.Text = draw.markAsClear();
                                           ButtonAF6.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 7:
                                {   if (attackSuccess == true)
                                         { ButtonAF7.Text = draw.markAsSank();
                                           ButtonAF7.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAF7.Text = draw.markAsClear();
                                           ButtonAF7.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 8:
                                {   if (attackSuccess == true)
                                         { ButtonAF8.Text = draw.markAsSank();
                                           ButtonAF8.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAF8.Text = draw.markAsClear();
                                           ButtonAF8.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 9:
                                {   if (attackSuccess == true)
                                         { ButtonAF9.Text = draw.markAsSank();
                                           ButtonAF9.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAF9.Text = draw.markAsClear();
                                           ButtonAF9.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 10:
                                {   if (attackSuccess == true)
                                         { ButtonAF10.Text = draw.markAsSank();
                                           ButtonAF10.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAF10.Text = draw.markAsClear();
                                           ButtonAF10.BackColor = System.Drawing.Color.Aqua; } break; }
                            default:
                                break;
                        }
                        break;
                    }
                case 7: // Button AG1 - AG10
                    {
                        switch (Y_Coord)
                        {
                            case 1:
                                {   if (attackSuccess == true)
                                         { ButtonAG1.Text = draw.markAsSank();
                                           ButtonAG1.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAG1.Text = draw.markAsClear();
                                           ButtonAG1.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 2:
                                {   if (attackSuccess == true)
                                         { ButtonAG2.Text = draw.markAsSank();
                                           ButtonAG2.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAG2.Text = draw.markAsClear();
                                           ButtonAG2.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 3:
                                {   if (attackSuccess == true)
                                         { ButtonAG3.Text = draw.markAsSank();
                                           ButtonAG3.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAG3.Text = draw.markAsClear();
                                           ButtonAG3.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 4:
                                {   if (attackSuccess == true)
                                         { ButtonAG4.Text = draw.markAsSank();
                                           ButtonAG4.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAG4.Text = draw.markAsClear();
                                           ButtonAG4.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 5:
                                {   if (attackSuccess == true)
                                         { ButtonAG5.Text = draw.markAsSank();
                                           ButtonAG5.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAG5.Text = draw.markAsClear();
                                           ButtonAG5.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 6:
                                {   if (attackSuccess == true)
                                         { ButtonAG6.Text = draw.markAsSank();
                                           ButtonAG6.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAG6.Text = draw.markAsClear();
                                           ButtonAG6.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 7:
                                {   if (attackSuccess == true)
                                         { ButtonAG7.Text = draw.markAsSank();
                                           ButtonAG7.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAG7.Text = draw.markAsClear();
                                           ButtonAG7.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 8:
                                {   if (attackSuccess == true)
                                         { ButtonAG8.Text = draw.markAsSank();
                                           ButtonAG8.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAG8.Text = draw.markAsClear();
                                           ButtonAG8.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 9:
                                {   if (attackSuccess == true)
                                         { ButtonAG9.Text = draw.markAsSank();
                                           ButtonAG9.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAG9.Text = draw.markAsClear();
                                           ButtonAG9.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 10:
                                {   if (attackSuccess == true)
                                         { ButtonAG10.Text = draw.markAsSank();
                                           ButtonAG10.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAG10.Text = draw.markAsClear();
                                           ButtonAG10.BackColor = System.Drawing.Color.Aqua; } break; }
                            default:
                                break;
                        }
                        break;
                    }
                case 8: // Button AH1 - AH10
                    {
                        switch (Y_Coord)
                        {
                            case 1:
                                {   if (attackSuccess == true)
                                         { ButtonAH1.Text = draw.markAsSank();
                                           ButtonAH1.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAH1.Text = draw.markAsClear();
                                           ButtonAH1.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 2:
                                {   if (attackSuccess == true)
                                         { ButtonAH2.Text = draw.markAsSank();
                                           ButtonAH2.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAH2.Text = draw.markAsClear();
                                           ButtonAH2.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 3:
                                {   if (attackSuccess == true)
                                         { ButtonAH3.Text = draw.markAsSank();
                                           ButtonAH3.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAH3.Text = draw.markAsClear();
                                           ButtonAH3.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 4:
                                {   if (attackSuccess == true)
                                         { ButtonAH4.Text = draw.markAsSank();
                                           ButtonAH4.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAH4.Text = draw.markAsClear();
                                           ButtonAH4.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 5:
                                {   if (attackSuccess == true)
                                         { ButtonAH5.Text = draw.markAsSank();
                                           ButtonAH5.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAH5.Text = draw.markAsClear();
                                           ButtonAH5.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 6:
                                {   if (attackSuccess == true)
                                         { ButtonAH6.Text = draw.markAsSank();
                                           ButtonAH6.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAH6.Text = draw.markAsClear();
                                           ButtonAH6.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 7:
                                {   if (attackSuccess == true)
                                         { ButtonAH7.Text = draw.markAsSank();
                                           ButtonAH7.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAH7.Text = draw.markAsClear();
                                           ButtonAH7.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 8:
                                {   if (attackSuccess == true)
                                         { ButtonAH8.Text = draw.markAsSank();
                                           ButtonAH8.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAH8.Text = draw.markAsClear();
                                           ButtonAH8.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 9:
                                {   if (attackSuccess == true)
                                         { ButtonAH9.Text = draw.markAsSank();
                                           ButtonAH9.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAH9.Text = draw.markAsClear();
                                           ButtonAH9.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 10:
                                {   if (attackSuccess == true)
                                         { ButtonAH10.Text = draw.markAsSank();
                                           ButtonAH10.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAH10.Text = draw.markAsClear();
                                           ButtonAH10.BackColor = System.Drawing.Color.Aqua; } break; }
                            default:
                                break;
                        }
                        break;
                    }
                case 9: // Button AI1 - AI10
                    {
                        switch (Y_Coord)
                        {
                            case 1:
                                {   if (attackSuccess == true)
                                         { ButtonAI1.Text = draw.markAsSank();
                                           ButtonAI1.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAI1.Text = draw.markAsClear();
                                           ButtonAI1.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 2:
                                {   if (attackSuccess == true)
                                         { ButtonAI2.Text = draw.markAsSank();
                                           ButtonAI2.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAI2.Text = draw.markAsClear();
                                           ButtonAI2.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 3:
                                {   if (attackSuccess == true)
                                         { ButtonAI3.Text = draw.markAsSank();
                                           ButtonAI3.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAI3.Text = draw.markAsClear();
                                           ButtonAI3.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 4:
                                {   if (attackSuccess == true)
                                         { ButtonAI4.Text = draw.markAsSank();
                                           ButtonAI4.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAI4.Text = draw.markAsClear();
                                           ButtonAI4.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 5:
                                {   if (attackSuccess == true)
                                         { ButtonAI5.Text = draw.markAsSank();
                                           ButtonAI5.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAI5.Text = draw.markAsClear();
                                           ButtonAI5.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 6:
                                {   if (attackSuccess == true)
                                         { ButtonAI6.Text = draw.markAsSank();
                                           ButtonAI6.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAI6.Text = draw.markAsClear();
                                           ButtonAI6.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 7:
                                {   if (attackSuccess == true)
                                         { ButtonAI7.Text = draw.markAsSank();
                                           ButtonAI7.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAI7.Text = draw.markAsClear();
                                           ButtonAI7.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 8:
                                {   if (attackSuccess == true)
                                         { ButtonAI8.Text = draw.markAsSank();
                                           ButtonAI8.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAI8.Text = draw.markAsClear();
                                           ButtonAI8.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 9:
                                {   if (attackSuccess == true)
                                         { ButtonAI9.Text = draw.markAsSank();
                                           ButtonAI9.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAI9.Text = draw.markAsClear();
                                           ButtonAI9.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 10:
                                {   if (attackSuccess == true)
                                         { ButtonAI10.Text = draw.markAsSank();
                                           ButtonAI10.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAI10.Text = draw.markAsClear();
                                           ButtonAI10.BackColor = System.Drawing.Color.Aqua; } break; }
                            default:
                                break;
                        }
                        break;
                    }
                case 10: // Button AJ1 - AJ10
                    {
                        switch (Y_Coord)
                        {
                            case 1:
                                {   if (attackSuccess == true)
                                         { ButtonAJ1.Text = draw.markAsSank();
                                           ButtonAJ1.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAJ1.Text = draw.markAsClear();
                                           ButtonAJ1.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 2:
                                {   if (attackSuccess == true)
                                         { ButtonAJ2.Text = draw.markAsSank();
                                           ButtonAJ2.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAJ2.Text = draw.markAsClear();
                                           ButtonAJ2.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 3:
                                {   if (attackSuccess == true)
                                         { ButtonAJ3.Text = draw.markAsSank();
                                           ButtonAJ3.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAJ3.Text = draw.markAsClear();
                                           ButtonAJ3.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 4:
                                {   if (attackSuccess == true)
                                         { ButtonAJ4.Text = draw.markAsSank();
                                           ButtonAJ4.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAJ4.Text = draw.markAsClear();
                                           ButtonAJ4.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 5:
                                {   if (attackSuccess == true)
                                         { ButtonAJ5.Text = draw.markAsSank();
                                           ButtonAJ5.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAJ5.Text = draw.markAsClear();
                                           ButtonAJ5.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 6:
                                {   if (attackSuccess == true)
                                         { ButtonAJ6.Text = draw.markAsSank();
                                           ButtonAJ6.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAJ6.Text = draw.markAsClear();
                                           ButtonAJ6.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 7:
                                {   if (attackSuccess == true)
                                         { ButtonAJ7.Text = draw.markAsSank();
                                           ButtonAJ7.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAJ7.Text = draw.markAsClear();
                                           ButtonAJ7.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 8:
                                {   if (attackSuccess == true)
                                         { ButtonAJ8.Text = draw.markAsSank();
                                           ButtonAJ8.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAJ8.Text = draw.markAsClear();
                                           ButtonAJ8.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 9:
                                {   if (attackSuccess == true)
                                         { ButtonAJ9.Text = draw.markAsSank();
                                           ButtonAJ9.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAJ9.Text = draw.markAsClear();
                                           ButtonAJ9.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 10:
                                {   if (attackSuccess == true)
                                         { ButtonAJ10.Text = draw.markAsSank();
                                           ButtonAJ10.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonAJ10.Text = draw.markAsClear();
                                           ButtonAJ10.BackColor = System.Drawing.Color.Aqua; } break; }
                            default:
                                break;
                        }
                        break;
                    }
                default: break;

            }
        }

        protected void PlayerB_Attack(object sender, EventArgs e)
        {
            SectorB sectorB = new SectorB();

            DetermineField attack = new DetermineField(txtbox_Coordination_X_PlayerB.Text.ToUpper(), txtbox_Coordination_Y_PlayerB.Text);

            X_Coord = attack.x_Coordination;
            Y_Coord = attack.y_Coordination;

            bool attackSuccess = sectorB.attackShip(X_Coord, Y_Coord);

            switch (X_Coord)
            {
                case 1: // Button BA1 - BA10
                    {
                        switch (Y_Coord)
                        {
                            case 1:
                                {   if (attackSuccess == true)
                                         { ButtonBA1.Text = draw.markAsSank();
                                           ButtonBA1.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBA1.Text = draw.markAsClear();
                                           ButtonBA1.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 2:
                                {   if (attackSuccess == true)
                                         { ButtonBA2.Text = draw.markAsSank();
                                           ButtonBA2.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBA2.Text = draw.markAsClear();
                                           ButtonBA2.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 3:
                                {   if (attackSuccess == true)
                                         { ButtonBA3.Text = draw.markAsSank();
                                           ButtonBA3.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBA3.Text = draw.markAsClear();
                                           ButtonBA3.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 4:
                                {   if (attackSuccess == true)
                                         { ButtonBA4.Text = draw.markAsSank();
                                           ButtonBA4.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBA4.Text = draw.markAsClear();
                                           ButtonBA4.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 5:
                                {   if (attackSuccess == true)
                                         { ButtonBA5.Text = draw.markAsSank();
                                           ButtonBA5.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBA5.Text = draw.markAsClear();
                                           ButtonBA5.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 6:
                                {   if (attackSuccess == true)
                                         { ButtonBA6.Text = draw.markAsSank();
                                           ButtonBA6.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBA6.Text = draw.markAsClear();
                                           ButtonBA6.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 7:
                                {   if (attackSuccess == true)
                                         { ButtonBA7.Text = draw.markAsSank();
                                           ButtonBA7.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBA7.Text = draw.markAsClear();
                                           ButtonBA7.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 8:
                                {   if (attackSuccess == true)
                                         { ButtonBA8.Text = draw.markAsSank();
                                           ButtonBA8.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBA8.Text = draw.markAsClear();
                                           ButtonBA8.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 9:
                                {   if (attackSuccess == true)
                                         { ButtonBA9.Text = draw.markAsSank();
                                           ButtonBA9.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBA9.Text = draw.markAsClear();
                                           ButtonBA9.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 10:
                                {   if (attackSuccess == true)
                                         { ButtonBA10.Text = draw.markAsSank();
                                           ButtonBA10.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBA10.Text = draw.markAsClear();
                                           ButtonBA10.BackColor = System.Drawing.Color.Aqua; } break; }
                            default:
                                break;
                        }
                        break;
                    }
                case 2: // Button BB1 - BB10
                    {
                        switch (Y_Coord)
                        {
                            case 1:
                                {   if (attackSuccess == true)
                                         { ButtonBB1.Text = draw.markAsSank();
                                           ButtonBB1.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBB1.Text = draw.markAsClear();
                                           ButtonBB1.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 2:
                                {   if (attackSuccess == true)
                                         { ButtonBB2.Text = draw.markAsSank();
                                           ButtonBB2.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBB2.Text = draw.markAsClear();
                                           ButtonBB2.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 3:
                                {   if (attackSuccess == true)
                                         { ButtonBB3.Text = draw.markAsSank();
                                           ButtonBB3.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBB3.Text = draw.markAsClear();
                                           ButtonBB3.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 4:
                                {   if (attackSuccess == true)
                                         { ButtonBB4.Text = draw.markAsSank();
                                           ButtonBB4.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBB4.Text = draw.markAsClear();
                                           ButtonBB4.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 5:
                                {   if (attackSuccess == true)
                                         { ButtonBB5.Text = draw.markAsSank();
                                           ButtonBB5.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBB5.Text = draw.markAsClear();
                                           ButtonBB5.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 6:
                                {   if (attackSuccess == true)
                                         { ButtonBB6.Text = draw.markAsSank();
                                           ButtonBB6.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBB6.Text = draw.markAsClear();
                                           ButtonBB6.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 7:
                                {   if (attackSuccess == true)
                                         { ButtonBB7.Text = draw.markAsSank();
                                           ButtonBB7.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBB7.Text = draw.markAsClear();
                                           ButtonBB7.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 8:
                                {   if (attackSuccess == true)
                                         { ButtonBB8.Text = draw.markAsSank();
                                           ButtonBB8.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBB8.Text = draw.markAsClear();
                                           ButtonBB8.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 9:
                                {   if (attackSuccess == true)
                                         { ButtonBB9.Text = draw.markAsSank();
                                           ButtonBB9.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBB9.Text = draw.markAsClear();
                                           ButtonBB9.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 10:
                                {   if (attackSuccess == true)
                                         { ButtonBB10.Text = draw.markAsSank();
                                           ButtonBB10.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBB10.Text = draw.markAsClear();
                                           ButtonBB10.BackColor = System.Drawing.Color.Aqua; } break; }
                            default:
                                break;
                        }
                        break;
                    }
                case 3: // Button BC1 - BC10
                    {
                        switch (Y_Coord)
                        {
                            case 1:
                                {   if (attackSuccess == true)
                                         { ButtonBC1.Text = draw.markAsSank();
                                           ButtonBC1.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBC1.Text = draw.markAsClear();
                                           ButtonBC1.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 2:
                                {   if (attackSuccess == true)
                                         { ButtonBC2.Text = draw.markAsSank();
                                           ButtonBC2.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBC2.Text = draw.markAsClear();
                                           ButtonBC2.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 3:
                                {   if (attackSuccess == true)
                                         { ButtonBC3.Text = draw.markAsSank();
                                           ButtonBC3.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBC3.Text = draw.markAsClear();
                                           ButtonBC3.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 4:
                                {   if (attackSuccess == true)
                                         { ButtonBC4.Text = draw.markAsSank();
                                           ButtonBC4.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBC4.Text = draw.markAsClear();
                                           ButtonBC4.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 5:
                                {   if (attackSuccess == true)
                                         { ButtonBC5.Text = draw.markAsSank();
                                           ButtonBC5.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBC5.Text = draw.markAsClear();
                                           ButtonBC5.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 6:
                                {   if (attackSuccess == true)
                                         { ButtonBC6.Text = draw.markAsSank();
                                           ButtonBC6.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBC6.Text = draw.markAsClear();
                                           ButtonBC6.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 7:
                                {   if (attackSuccess == true)
                                         { ButtonBC7.Text = draw.markAsSank();
                                           ButtonBC7.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBC7.Text = draw.markAsClear();
                                           ButtonBC7.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 8:
                                {   if (attackSuccess == true)
                                         { ButtonBC8.Text = draw.markAsSank();
                                           ButtonBC8.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBC8.Text = draw.markAsClear();
                                           ButtonBC8.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 9:
                                {   if (attackSuccess == true)
                                         { ButtonBC9.Text = draw.markAsSank();
                                           ButtonBC9.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBC9.Text = draw.markAsClear();
                                           ButtonBC9.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 10:
                                {   if (attackSuccess == true)
                                         { ButtonBC10.Text = draw.markAsSank();
                                           ButtonBC10.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBC10.Text = draw.markAsClear();
                                           ButtonBC10.BackColor = System.Drawing.Color.Aqua; } break; }
                            default:
                                break;
                        }
                        break;
                    }
                case 4: // Button BD1 - BD10
                    {
                        switch (Y_Coord)
                        {
                            case 1:
                                {   if (attackSuccess == true)
                                         { ButtonBD1.Text = draw.markAsSank();
                                           ButtonBD1.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBD1.Text = draw.markAsClear();
                                           ButtonBD1.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 2:
                                {   if (attackSuccess == true)
                                         { ButtonBD2.Text = draw.markAsSank();
                                           ButtonBD2.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBD2.Text = draw.markAsClear();
                                           ButtonBD2.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 3:
                                {   if (attackSuccess == true)
                                         { ButtonBD3.Text = draw.markAsSank();
                                           ButtonBD3.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBD3.Text = draw.markAsClear();
                                           ButtonBD3.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 4:
                                {   if (attackSuccess == true)
                                         { ButtonBD4.Text = draw.markAsSank();
                                           ButtonBD4.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBD4.Text = draw.markAsClear();
                                           ButtonBD4.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 5:
                                {   if (attackSuccess == true)
                                         { ButtonBD5.Text = draw.markAsSank();
                                           ButtonBD5.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBD5.Text = draw.markAsClear();
                                           ButtonBD5.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 6:
                                {   if (attackSuccess == true)
                                         { ButtonBD6.Text = draw.markAsSank();
                                           ButtonBD6.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBD6.Text = draw.markAsClear();
                                           ButtonBD6.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 7:
                                {   if (attackSuccess == true)
                                         { ButtonBD7.Text = draw.markAsSank();
                                           ButtonBD7.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBD7.Text = draw.markAsClear();
                                           ButtonBD7.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 8:
                                {   if (attackSuccess == true)
                                         { ButtonBD8.Text = draw.markAsSank();
                                           ButtonBD8.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBD8.Text = draw.markAsClear();
                                           ButtonBD8.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 9:
                                {   if (attackSuccess == true)
                                         { ButtonBD9.Text = draw.markAsSank();
                                           ButtonBD9.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBD9.Text = draw.markAsClear();
                                           ButtonBD9.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 10:
                                {   if (attackSuccess == true)
                                         { ButtonBD10.Text = draw.markAsSank();
                                           ButtonBD10.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBD10.Text = draw.markAsClear();
                                           ButtonBD10.BackColor = System.Drawing.Color.Aqua; } break; }
                            default:
                                break;
                        }
                        break;
                    }
                case 5: // Button BE1 - BE10
                    {
                        switch (Y_Coord)
                        {
                            case 1:
                                {   if (attackSuccess == true)
                                         { ButtonBE1.Text = draw.markAsSank();
                                           ButtonBE1.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBE1.Text = draw.markAsClear();
                                           ButtonBE1.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 2:
                                {   if (attackSuccess == true)
                                         { ButtonBE2.Text = draw.markAsSank();
                                           ButtonBE2.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBE2.Text = draw.markAsClear();
                                           ButtonBE2.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 3:
                                {   if (attackSuccess == true)
                                         { ButtonBE3.Text = draw.markAsSank();
                                           ButtonBE3.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBE3.Text = draw.markAsClear();
                                           ButtonBE3.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 4:
                                {   if (attackSuccess == true)
                                         { ButtonBE4.Text = draw.markAsSank();
                                           ButtonBE4.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBE4.Text = draw.markAsClear();
                                           ButtonBE4.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 5:
                                {   if (attackSuccess == true)
                                         { ButtonBE5.Text = draw.markAsSank();
                                           ButtonBE5.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBE5.Text = draw.markAsClear();
                                           ButtonBE5.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 6:
                                {   if (attackSuccess == true)
                                         { ButtonBE6.Text = draw.markAsSank();
                                           ButtonBE6.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBE6.Text = draw.markAsClear();
                                           ButtonBE6.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 7:
                                {   if (attackSuccess == true)
                                         { ButtonBE7.Text = draw.markAsSank();
                                           ButtonBE7.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBE7.Text = draw.markAsClear();
                                           ButtonBE7.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 8:
                                {   if (attackSuccess == true)
                                         { ButtonBE8.Text = draw.markAsSank();
                                           ButtonBE8.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBE8.Text = draw.markAsClear();
                                           ButtonBE8.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 9:
                                {   if (attackSuccess == true)
                                         { ButtonBE9.Text = draw.markAsSank();
                                           ButtonBE9.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBE9.Text = draw.markAsClear();
                                           ButtonBE9.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 10:
                                {   if (attackSuccess == true)
                                         { ButtonBE10.Text = draw.markAsSank();
                                           ButtonBE10.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBE10.Text = draw.markAsClear();
                                           ButtonBE10.BackColor = System.Drawing.Color.Aqua; } break; }
                            default:
                                break;
                        }
                        break;
                    }
                case 6: // Button BF1 - BF10
                    {
                        switch (Y_Coord)
                        {
                            case 1:
                                {   if (attackSuccess == true)
                                         { ButtonBF1.Text = draw.markAsSank();
                                           ButtonBF1.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBF1.Text = draw.markAsClear();
                                           ButtonBF1.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 2:
                                {   if (attackSuccess == true)
                                         { ButtonBF2.Text = draw.markAsSank();
                                           ButtonBF2.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBF2.Text = draw.markAsClear();
                                           ButtonBF2.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 3:
                                {   if (attackSuccess == true)
                                         { ButtonBF3.Text = draw.markAsSank();
                                           ButtonBF3.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBF3.Text = draw.markAsClear();
                                           ButtonBF3.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 4:
                                {   if (attackSuccess == true)
                                         { ButtonBF4.Text = draw.markAsSank();
                                           ButtonBF4.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBF4.Text = draw.markAsClear();
                                           ButtonBF4.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 5:
                                {   if (attackSuccess == true)
                                         { ButtonBF5.Text = draw.markAsSank();
                                           ButtonBF5.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBF5.Text = draw.markAsClear();
                                           ButtonBF5.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 6:
                                {   if (attackSuccess == true)
                                         { ButtonBF6.Text = draw.markAsSank();
                                           ButtonBF6.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBF6.Text = draw.markAsClear();
                                           ButtonBF6.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 7:
                                {   if (attackSuccess == true)
                                         { ButtonBF7.Text = draw.markAsSank();
                                           ButtonBF7.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBF7.Text = draw.markAsClear();
                                           ButtonBF7.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 8:
                                {   if (attackSuccess == true)
                                         { ButtonBF8.Text = draw.markAsSank();
                                           ButtonBF8.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBF8.Text = draw.markAsClear();
                                           ButtonBF8.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 9:
                                {   if (attackSuccess == true)
                                         { ButtonBF9.Text = draw.markAsSank();
                                           ButtonBF9.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBF9.Text = draw.markAsClear();
                                           ButtonBF9.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 10:
                                {   if (attackSuccess == true)
                                         { ButtonBF10.Text = draw.markAsSank();
                                           ButtonBF10.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBF10.Text = draw.markAsClear();
                                           ButtonBF10.BackColor = System.Drawing.Color.Aqua; } break; }
                            default:
                                break;
                        }
                        break;
                    }
                case 7: // Button BG1 - BG10
                    {
                        switch (Y_Coord)
                        {
                            case 1:
                                {   if (attackSuccess == true)
                                         { ButtonBG1.Text = draw.markAsSank();
                                           ButtonBG1.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBG1.Text = draw.markAsClear();
                                           ButtonBG1.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 2:
                                {   if (attackSuccess == true)
                                         { ButtonBG2.Text = draw.markAsSank();
                                           ButtonBG2.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBG2.Text = draw.markAsClear();
                                           ButtonBG2.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 3:
                                {   if (attackSuccess == true)
                                         { ButtonBG3.Text = draw.markAsSank();
                                           ButtonBG3.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBG3.Text = draw.markAsClear();
                                           ButtonBG3.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 4:
                                {   if (attackSuccess == true)
                                         { ButtonBG4.Text = draw.markAsSank();
                                           ButtonBG4.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBG4.Text = draw.markAsClear();
                                           ButtonBG4.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 5:
                                {   if (attackSuccess == true)
                                         { ButtonBG5.Text = draw.markAsSank();
                                           ButtonBG5.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBG5.Text = draw.markAsClear();
                                           ButtonBG5.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 6:
                                {   if (attackSuccess == true)
                                         { ButtonBG6.Text = draw.markAsSank();
                                           ButtonBG6.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBG6.Text = draw.markAsClear();
                                           ButtonBG6.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 7:
                                {   if (attackSuccess == true)
                                         { ButtonBG7.Text = draw.markAsSank();
                                           ButtonBG7.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBG7.Text = draw.markAsClear();
                                           ButtonBG7.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 8:
                                {   if (attackSuccess == true)
                                         { ButtonBG8.Text = draw.markAsSank();
                                           ButtonBG8.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBG8.Text = draw.markAsClear();
                                           ButtonBG8.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 9:
                                {   if (attackSuccess == true)
                                         { ButtonBG9.Text = draw.markAsSank();
                                           ButtonBG9.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBG9.Text = draw.markAsClear();
                                           ButtonBG9.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 10:
                                {   if (attackSuccess == true)
                                         { ButtonBG10.Text = draw.markAsSank();
                                           ButtonBG10.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBG10.Text = draw.markAsClear();
                                           ButtonBG10.BackColor = System.Drawing.Color.Aqua; } break; }
                            default:
                                break;
                        }
                        break;
                    }
                case 8: // Button BH1 - BH10
                    {
                        switch (Y_Coord)
                        {
                            case 1:
                                {   if (attackSuccess == true)
                                         { ButtonBH1.Text = draw.markAsSank();
                                           ButtonBH1.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBH1.Text = draw.markAsClear();
                                           ButtonBH1.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 2:
                                {   if (attackSuccess == true)
                                         { ButtonBH2.Text = draw.markAsSank();
                                           ButtonBH2.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBH2.Text = draw.markAsClear();
                                           ButtonBH2.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 3:
                                {   if (attackSuccess == true)
                                         { ButtonBH3.Text = draw.markAsSank();
                                           ButtonBH3.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBH3.Text = draw.markAsClear();
                                           ButtonBH3.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 4:
                                {   if (attackSuccess == true)
                                         { ButtonBH4.Text = draw.markAsSank();
                                           ButtonBH4.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBH4.Text = draw.markAsClear();
                                           ButtonBH4.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 5:
                                {   if (attackSuccess == true)
                                         { ButtonBH5.Text = draw.markAsSank();
                                           ButtonBH5.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBH5.Text = draw.markAsClear();
                                           ButtonBH5.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 6:
                                {   if (attackSuccess == true)
                                         { ButtonBH6.Text = draw.markAsSank();
                                           ButtonBH6.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBH6.Text = draw.markAsClear();
                                           ButtonBH6.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 7:
                                {   if (attackSuccess == true)
                                         { ButtonBH7.Text = draw.markAsSank();
                                           ButtonBH7.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBH7.Text = draw.markAsClear();
                                           ButtonBH7.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 8:
                                {   if (attackSuccess == true)
                                         { ButtonBH8.Text = draw.markAsSank();
                                           ButtonBH8.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBH8.Text = draw.markAsClear();
                                           ButtonBH8.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 9:
                                {   if (attackSuccess == true)
                                         { ButtonBH9.Text = draw.markAsSank();
                                           ButtonBH9.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBH9.Text = draw.markAsClear();
                                           ButtonBH9.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 10:
                                {   if (attackSuccess == true)
                                         { ButtonBH10.Text = draw.markAsSank();
                                           ButtonBH10.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBH10.Text = draw.markAsClear();
                                           ButtonBH10.BackColor = System.Drawing.Color.Aqua; } break; }
                            default:
                                break;
                        }
                        break;
                    }
                case 9: // Button BI1 - BI10
                    {
                        switch (Y_Coord)
                        {
                            case 1:
                                {   if (attackSuccess == true)
                                         { ButtonBI1.Text = draw.markAsSank();
                                           ButtonBI1.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBI1.Text = draw.markAsClear();
                                           ButtonBI1.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 2:
                                {   if (attackSuccess == true)
                                         { ButtonBI2.Text = draw.markAsSank();
                                           ButtonBI2.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBI2.Text = draw.markAsClear();
                                           ButtonBI2.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 3:
                                {   if (attackSuccess == true)
                                         { ButtonBI3.Text = draw.markAsSank();
                                           ButtonBI3.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBI3.Text = draw.markAsClear();
                                           ButtonBI3.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 4:
                                {   if (attackSuccess == true)
                                         { ButtonBI4.Text = draw.markAsSank();
                                           ButtonBI4.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBI4.Text = draw.markAsClear();
                                           ButtonBI4.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 5:
                                {   if (attackSuccess == true)
                                         { ButtonBI5.Text = draw.markAsSank();
                                           ButtonBI5.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBI5.Text = draw.markAsClear();
                                           ButtonBI5.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 6:
                                {   if (attackSuccess == true)
                                         { ButtonBI6.Text = draw.markAsSank();
                                           ButtonBI6.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBI6.Text = draw.markAsClear();
                                           ButtonBI6.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 7:
                                {   if (attackSuccess == true)
                                         { ButtonBI7.Text = draw.markAsSank();
                                           ButtonBI7.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBI7.Text = draw.markAsClear();
                                           ButtonBI7.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 8:
                                {   if (attackSuccess == true)
                                         { ButtonBI8.Text = draw.markAsSank();
                                           ButtonBI8.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBI8.Text = draw.markAsClear();
                                           ButtonBI8.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 9:
                                {   if (attackSuccess == true)
                                         { ButtonBI9.Text = draw.markAsSank();
                                           ButtonBI9.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBI9.Text = draw.markAsClear();
                                           ButtonBI9.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 10:
                                {   if (attackSuccess == true)
                                         { ButtonBI10.Text = draw.markAsSank();
                                           ButtonBI10.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBI10.Text = draw.markAsClear();
                                           ButtonBI10.BackColor = System.Drawing.Color.Aqua; } break; }
                            default:
                                break;
                        }
                        break;
                    }
                case 10: // Button BJ1 - BJ10
                    {
                        switch (Y_Coord)
                        {
                            case 1:
                                {   if (attackSuccess == true)
                                         { ButtonBJ1.Text = draw.markAsSank();
                                           ButtonBJ1.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBJ1.Text = draw.markAsClear();
                                           ButtonBJ1.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 2:
                                {   if (attackSuccess == true)
                                         { ButtonBJ2.Text = draw.markAsSank();
                                           ButtonBJ2.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBJ2.Text = draw.markAsClear();
                                           ButtonBJ2.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 3:
                                {   if (attackSuccess == true)
                                         { ButtonBJ3.Text = draw.markAsSank();
                                           ButtonBJ3.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBJ3.Text = draw.markAsClear();
                                           ButtonBJ3.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 4:
                                {   if (attackSuccess == true)
                                         { ButtonBJ4.Text = draw.markAsSank();
                                           ButtonBJ4.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBJ4.Text = draw.markAsClear();
                                           ButtonBJ4.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 5:
                                {   if (attackSuccess == true)
                                         { ButtonBJ5.Text = draw.markAsSank();
                                           ButtonBJ5.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBJ5.Text = draw.markAsClear();
                                           ButtonBJ5.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 6:
                                {   if (attackSuccess == true)
                                         { ButtonBJ6.Text = draw.markAsSank();
                                           ButtonBJ6.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBJ6.Text = draw.markAsClear();
                                           ButtonBJ6.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 7:
                                {   if (attackSuccess == true)
                                         { ButtonBJ7.Text = draw.markAsSank();
                                           ButtonBJ7.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBJ7.Text = draw.markAsClear();
                                           ButtonBJ7.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 8:
                                {   if (attackSuccess == true)
                                         { ButtonBJ8.Text = draw.markAsSank();
                                           ButtonBJ8.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBJ8.Text = draw.markAsClear();
                                           ButtonBJ8.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 9:
                                {   if (attackSuccess == true)
                                         { ButtonBJ9.Text = draw.markAsSank();
                                           ButtonBJ9.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBJ9.Text = draw.markAsClear();
                                           ButtonBJ9.BackColor = System.Drawing.Color.Aqua; } break; }
                            case 10:
                                {   if (attackSuccess == true)
                                         { ButtonBJ10.Text = draw.markAsSank();
                                           ButtonBJ10.BackColor = System.Drawing.Color.Red; }
                                    else { ButtonBJ10.Text = draw.markAsClear();
                                           ButtonBJ10.BackColor = System.Drawing.Color.Aqua; } break; }
                            default:
                                break;
                        }
                        break;
                    }
                default: break;

            }
        }
    }
}