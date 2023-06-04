using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projekt_Meteo_Stations.Models
{
    public class Station
    {
        [DisplayName("ID stacji")]
        public int StationID { get; set; }

        [DisplayName("Lokalizacja stacji")]
        [Required]
        [MaxLength(512)]
        public string Location { get; set; }

        [DisplayName("Status stacji")]
        [Required]
        [ForeignKey("StationStatusID")]
        public int? StationStatusID { get; set; }

        [DisplayName("Status stacji")]
        public virtual StationStatus? StationStatus { get; set; }
    }
}
