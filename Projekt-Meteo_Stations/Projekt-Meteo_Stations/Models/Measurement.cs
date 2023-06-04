using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using NuGet.Packaging.Signing;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace Projekt_Meteo_Stations.Models
{
    public class Measurement
    {
        public int MeasurementID { get; set; }

        [Required]
        [DisplayName("Data i godzina pomiaru")]
        public DateTime MeasurementDate { get; set; }

        [DisplayName("Temperatura [°C]")]
        [Precision(5, 2)]
        public decimal Temperature { get; set; }

        [DisplayName("Wilgotność [%]")]
        [Range(0, 100, ErrorMessage = "Wartość {0} musi zawierać się w zakresie {1} - {2}.")]
        public byte Humidity { get; set; }

        [DisplayName("Ciśnienie [hPa]")]
        public short Pressure { get; set; }

        [Required]
        [ForeignKey("StationID")]
        [DisplayName("Stacja")]
        public int StationID { get; set; }

        [DisplayName("Stacja")]
        public virtual Station? Station { get; set; }
    }
}
