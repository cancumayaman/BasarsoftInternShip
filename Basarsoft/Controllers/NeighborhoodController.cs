﻿using Basarsoft.Business.Abstract;
using Basarsoft.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basarsoft.Controllers
{
    public class NeighborhoodController : Controller
    {
        private readonly INeighborhoodManager _neighborhoodManager;

        public NeighborhoodController(INeighborhoodManager neighborhoodManager)
        {
            _neighborhoodManager = neighborhoodManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SaveNeighborhood(Neighborhood neighborhood, string result, string no)
        {
            if (ModelState.IsValid)
            {
                neighborhood.Coordinates =result;
                neighborhood.NeighborhoodName = no;
                _neighborhoodManager.Add(neighborhood);

            }
            return Json("");
        }


    }
}
