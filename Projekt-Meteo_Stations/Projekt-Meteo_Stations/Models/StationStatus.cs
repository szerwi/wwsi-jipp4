using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Projekt_Meteo_Stations.Models
{
    public class StationStatus
    {
        public int StationStatusID { get; set; }

        [Required]
        [MaxLength(64)]
        [DisplayName("Status")]
        public string Status { get; set; }
    }
}
