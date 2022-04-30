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

        // GET: Button
        public ActionResult Index()
        {
            Random random = new Random();
            for (int i = 0; i < 200; i++)
            {
                buttons.Add(new ButtonModel(0));
                if (random.Next(10) > 5)
                    shipLocation.Add(new ButtonModel(1));
                else
                    shipLocation.Add(new ButtonModel(2));
            }
            return View("Index", buttons);
        }
        public ActionResult HandleButtonClick(string pButtons)
        {
            int buttonNumber = Int32.Parse(pButtons);
            buttons[buttonNumber].State = shipLocation[buttonNumber].State;
            return View("Index", buttons);
        }
    }
}