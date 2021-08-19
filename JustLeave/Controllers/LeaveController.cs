using JustLeave.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustLeave.Controllers
{
    public class LeaveController : Controller
    {
        public IActionResult Index()
        {
            List<Leave> leaves = new List<Leave>()
            {
                new Leave
                {
                    Id = 1,
                    LeaveType = "Annual",
                    StartDateLeave = new DateTime(2021, 08, 19),
                    EndDateLeave = new DateTime(2021, 08, 19),
                    Day = 1,
                    Reason = "Personal"
                },
                new Leave
                {
                    Id = 2,
                    LeaveType = "Replacement",
                    StartDateLeave = new DateTime(2021, 08, 21),
                    EndDateLeave = new DateTime(2021, 08, 21),
                    Day = 1,
                    Reason = "going to register class for my kids"
                }
            };
            return View(leaves);
        }
    }
}
