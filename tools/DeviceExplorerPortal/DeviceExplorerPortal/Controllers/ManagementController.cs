﻿using System.Threading.Tasks;
using System.Web.Mvc;
using DeviceExplorerPortal.Models;

namespace DeviceExplorerPortal.Controllers
{
    public class ManagementController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var devicesProcessor = new DevicesProcessor();
            return View("Index", await devicesProcessor.GetDevices());
        }

        public ActionResult CopyConnectionString(string id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DeviceEntity device)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
