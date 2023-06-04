using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projekt_Meteo_Stations.Data;
using Projekt_Meteo_Stations.Models;
using Projekt_Meteo_Stations.Repositories;

namespace Projekt_Meteo_Stations.Controllers
{
    public class StationsController : Controller
    {
        private StationManager _manager;

        public StationsController(StationManager manager)
        {
            _manager = manager;
        }

        // GET: Stations
        public IActionResult Index()
        {
            ViewData["StationStatusID"] = _manager.GetStationStatusList();

            return View(_manager.GetStations());
        }

        // GET: Stations/Details/5
        public IActionResult Details(int? id)
        {
            Station? station = _manager.GetStation(id);
            ViewData["StationStatusID"] = _manager.GetStationStatusList();

            if (station == null)
            {
                return NotFound();
            }

            return View(station);
        }

        // GET: Stations/Create
        public IActionResult Create()
        {
            ViewData["StationStatusID"] = _manager.GetStationStatusList();

            return View();
        }

        // POST: Stations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Station station)
        {
            _manager.AddStation(station);

            return RedirectToAction(nameof(Index));
        }

        // GET: Stations/Edit/5
        public IActionResult Edit(int? id)
        {
            var station = _manager.GetStation(id);
            ViewData["StationStatusID"] = _manager.GetStationStatusList();

            return View(station);
        }

        // POST: Stations/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Station station)
        {
            _manager.EditStation(station);

            return RedirectToAction(nameof(Index));
        }

        // GET: Stations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            ViewData["StationStatusID"] = _manager.GetStationStatusList();
            var station = _manager.GetStation(id);

            return View(station);
        }

        // POST: Stations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _manager.RemoveStation(id);

            return RedirectToAction(nameof(Index));
        }

        private bool StationExists(int id)
        {
          return (_manager.GetStation(id) != null);
        }
    }
}
