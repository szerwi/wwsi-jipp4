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
    public class MeasurementsController : Controller
    {
        private MeasurementManager _manager;

        public MeasurementsController(MeasurementManager manager)
        {
            _manager = manager;
        }

        // GET: Measurements
        public async Task<IActionResult> Index()
        {
            ViewData["StationID"] = _manager.GetStationLocationList();

            return View(_manager.GetMeasurements());
        }

        // GET: Measurements/IndexForStation/1
        public async Task<IActionResult> IndexForStation(int? id)
        {
            return View(_manager.GetMeasurements(id));
        }

        // GET: Measurements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            Measurement? measurement = _manager.GetMeasurement(id);
            ViewData["StationID"] = _manager.GetStationLocationList();

            if (measurement == null)
            {
                return NotFound();
            }

            return View(measurement);
        }

        // GET: Measurements/Create
        public IActionResult Create()
        {
            ViewData["StationID"] = _manager.GetStationLocationList();

            return View();
        }

        // POST: Measurements/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Measurement measurement)
        {
            _manager.AddMeasurement(measurement);

            return RedirectToAction(nameof(Index));
        }

        // GET: Measurements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var measurement = _manager.GetMeasurement(id);
            ViewData["StationID"] = _manager.GetStationLocationList();

            return View(measurement);
        }

        // POST: Measurements/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Measurement measurement)
        {
            _manager.EditMeasurement(measurement);

            return RedirectToAction(nameof(Index));
        }

        // GET: Measurements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            ViewData["StationID"] = _manager.GetStationLocationList();
            var measurement = _manager.GetMeasurement(id);

            return View(measurement);
        }

        // POST: Measurements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _manager.RemoveMeasurement(id);

            return RedirectToAction(nameof(Index));
        }

        private bool MeasurementExists(int id)
        {
            return (_manager.GetMeasurement(id) != null);
        }
    }
}
