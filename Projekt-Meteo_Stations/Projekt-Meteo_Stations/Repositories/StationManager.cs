using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projekt_Meteo_Stations.Data;
using Projekt_Meteo_Stations.Models;

namespace Projekt_Meteo_Stations.Repositories
{
    public class StationManager
    {
        private ApplicationDbContext _context;

        public StationManager(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Station> GetStations()
        {
            return _context.Station.Include(m => m.StationStatus).ToList();
        }

        public SelectList GetStationStatusList()
        {
            return new SelectList(_context.StationStatus, "StationStatusID", "Status");
        }

        public Station? GetStation(int? id)
        {
            if(id == null)
            {
                return null;
            }

            return _context.Station.Include(m => m.StationStatus).FirstOrDefault(m => m.StationID == id);
        }

        public StationManager AddStation(Station station)
        {
            _context.Station.Add(station);
            _context.SaveChanges();

            return this;
        }

        public StationManager EditStation(Station station)
        {
            _context.Station.Update(station);
            _context.SaveChanges();

            return this;
        }

        public StationManager RemoveStation(int id)
        {
            var station = this.GetStation(id);
            if(station != null)
            {
                _context.Station.Remove(station);
                _context.SaveChanges();
            }

            return this;
        }
    }
}
