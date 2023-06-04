using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projekt_Meteo_Stations.Data;
using Projekt_Meteo_Stations.Models;

namespace Projekt_Meteo_Stations.Repositories
{
    public class StationStatusManager
    {
        private ApplicationDbContext _context;

        public StationStatusManager(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<StationStatus> GetStationStatuses()
        {
            return _context.StationStatus.ToList();
        }

        public StationStatus? GetStationStatus(int? id)
        {
            if (id == null)
            {
                return null;
            }

            return _context.StationStatus.FirstOrDefault(m => m.StationStatusID == id);
        }

        public SelectList GetStationStatusList()
        {
            return new SelectList(_context.StationStatus, "StationStatusID", "Status");
        }

        public StationStatusManager AddStationStatus(StationStatus stationStatus)
        {
            _context.StationStatus.Add(stationStatus);
            _context.SaveChanges();

            return this;
        }

        public StationStatusManager EditStationStatus(StationStatus stationStatus)
        {
            _context.StationStatus.Update(stationStatus);
            _context.SaveChanges();

            return this;
        }

        public StationStatusManager RemoveStationStatus(int id)
        {
            var stationStatus = this.GetStationStatus(id);
            if (stationStatus != null)
            {
                _context.StationStatus.Remove(stationStatus);
                _context.SaveChanges();
            }

            return this;
        }
    }
}
