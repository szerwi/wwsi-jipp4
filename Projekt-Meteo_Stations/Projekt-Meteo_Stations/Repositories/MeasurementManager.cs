using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projekt_Meteo_Stations.Data;
using Projekt_Meteo_Stations.Models;

namespace Projekt_Meteo_Stations.Repositories
{
    public class MeasurementManager
    {
        private ApplicationDbContext _context;

        public MeasurementManager(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Measurement> GetMeasurements(int? stationId = null)
        {
            if (stationId == null)
            {
                return _context.Measurement
                    .Include(m => m.Station)
                    .OrderBy(m => m.StationID)
                    .ThenBy(m => m.MeasurementDate)
                    .ToList();
            }

            return _context.Measurement.Include(m => m.Station)
                .Where(m => m.StationID == stationId)
                .OrderBy(m => m.MeasurementDate)
                .ToList();
        }

        public SelectList GetStationLocationList()
        {
            return new SelectList(_context.Station, "StationID", "Location");
        }

        public Measurement? GetMeasurement(int? id)
        {
            if (id == null)
            {
                return null;
            }

            return _context.Measurement
                .Include(m => m.Station)
                .FirstOrDefault(m => m.MeasurementID == id);
        }

        public MeasurementManager AddMeasurement(Measurement measurement)
        {
            _context.Measurement.Add(measurement);
            _context.SaveChanges();

            return this;
        }

        public MeasurementManager EditMeasurement(Measurement measurement)
        {
            _context.Measurement.Update(measurement);
            _context.SaveChanges();

            return this;
        }

        public MeasurementManager RemoveMeasurement(int id)
        {
            var measurement = this.GetMeasurement(id);
            if (measurement != null)
            {
                _context.Measurement.Remove(measurement);
                _context.SaveChanges();
            }

            return this;
        }
    }
}
