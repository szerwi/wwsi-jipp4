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
using static System.Collections.Specialized.BitVector32;

namespace Projekt_Meteo_Stations.Controllers
{
    public class StationStatusController : Controller
    {
        private StationStatusManager _manager;

        public StationStatusController(StationStatusManager manager)
        {
            _manager = manager;
        }

        // GET: StationStatus
        public async Task<IActionResult> Index()
        {
            return View(_manager.GetStationStatuses());
        }

        // GET: StationStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StationStatus/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StationStatus stationStatus)
        {
            _manager.AddStationStatus(stationStatus);
            return RedirectToAction(nameof(Index));
        }

        // GET: StationStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var stationStatus = _manager.GetStationStatus(id);
            return View(stationStatus);
        }

        // POST: StationStatus/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(StationStatus stationStatus)
        {
            _manager.EditStationStatus(stationStatus);
            return RedirectToAction(nameof(Index));
        }

        // GET: StationStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var stationStatus = _manager.GetStationStatus(id);

            return View(stationStatus);
        }

        // POST: StationStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _manager.RemoveStationStatus(id);
            return RedirectToAction(nameof(Index));
        }

        private bool StationStatusExists(int id)
        {
            return (_manager.GetStationStatus(id) != null);
        }
    }
}
