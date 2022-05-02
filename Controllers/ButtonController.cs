using OOP_Ships_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OOP_Ships_Project.Controllers
{
    public class ButtonController : Controller
    {
        // GET: Button
       static List<DataModel> data = new List<DataModel>(); // List of button states, ship alive count and player turn
       static List<DataModel> shipLocation = new List<DataModel>(); // List of generated ship locations, 1 represents ship, 2 represents empty water
        bool pageLoaded = false;

    // GET: Button
    public ActionResult Index()
        {
            if (!pageLoaded)
                SetShipPosition();
            return View("Index", data);
        }
        public ActionResult HandleButtonClick(string pButtons)
        {
            int buttonNumber = Int32.Parse(pButtons);
            if ((buttonNumber < 100 && data[202].State == 0) || (buttonNumber > 99 && data[202].State == 1)) //Let the player who's turn it is, play
            {
                if (data[203].State == 0) data[203].State = 1; //Set a game in progress state
                
                if (data[202].State == 0) data[202].State = 1;
                else data[202].State = 0;
                data[buttonNumber].State = shipLocation[buttonNumber].State;

                if (shipLocation[buttonNumber].State == 1)
                {
                    if (buttonNumber < 100)
                        data[200].State--;
                    else
                        data[201].State--;
                }
            }
            return View("Index", data);
        }
        public ActionResult HandleTextInput(string AXcord, string AYcord, string BXcord, string BYcord)
        {
            int cord;
            if (data[202].State == 0 && (AXcord != "" || AYcord != ""))
            {
                cord = (Convert.ToInt32(AYcord) - 1) * 10 + (int)Convert.ToChar(AXcord) - 'a';
                data[cord].State = shipLocation[cord].State;
            }
            else if (data[202].State == 1 && (BXcord != "" || BYcord != ""))
            {
                cord = (Convert.ToInt32(BYcord) - 1) * 10 + (int)Convert.ToChar(BXcord) - 'a';
                data[cord + 100].State = shipLocation[cord + 100].State;
            }
            else { return View("Index", data); }

            if (data[202].State == 0) data[202].State = 1;
            else data[202].State = 0;
            return View("Index", data);
        }
        private void SetShipPosition()
        {
            pageLoaded = true;
            int[] alive = new int[2];
            const int maxShipCount = 10;

            for (int i = 0; i < 200; i++)
            {
                data.Add(new DataModel(0));
                shipLocation.Add(new DataModel(2));
            }
            
            Random random = new Random();
            for (int i = 0; i < maxShipCount * 2; i++)
            {
                if(i < 10)
                {
                    shipLocation[random.Next(100)].State = 1;
                    alive[0]++;
                }
                else
                {
                    shipLocation[random.Next(100) + 100].State = 1;
                    alive[1]++;
                }
            }
            data.Add(new DataModel(alive[0])); //Data index 200, status of Player A ships
            data.Add(new DataModel(alive[1])); //Data index 201, status of Player B ships
            data.Add(new DataModel(0)); //Data index 202, current players turn, convert bool to int
            data.Add(new DataModel(0)); // Data index 203, current game state
        }
    }
}