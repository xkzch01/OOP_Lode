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
        static List<ButtonModel> buttons = new List<ButtonModel>();
        static List<ButtonModel> shipLocation = new List<ButtonModel>();
        static List<ShipsModel> alive = new List<ShipsModel>();
        static bool playerTurn = false;

        // GET: Button
        public ActionResult Index()
        {
            alive.Add(new ShipsModel(0));
            alive.Add(new ShipsModel(0));

            Random random = new Random();
            for (int i = 0; i < 200; i++)
            {
                buttons.Add(new ButtonModel(0));
                if (random.Next(10) > 5)
                {
                    shipLocation.Add(new ButtonModel(1));
                    if (i < 100)
                        alive[0].CurrentStanding++;
                    else
                        alive[1].CurrentStanding++;
                }
                else
                    shipLocation.Add(new ButtonModel(2));
            }
            return View("Index", buttons);
        }
        public ActionResult HandleButtonClick(string pButtons)
        {
            int buttonNumber = Int32.Parse(pButtons);
            if ((buttonNumber < 100 && !playerTurn) || (buttonNumber > 99 && playerTurn))
            {
                buttons[buttonNumber].State = shipLocation[buttonNumber].State;
                playerTurn = !playerTurn;
            }

            if (shipLocation[buttonNumber].State == 1)
            {
                if (buttonNumber < 100)
                    alive[0].CurrentStanding--;
                else
                    alive[1].CurrentStanding--;
            }
            return View("Index", buttons);
        }
    }
}