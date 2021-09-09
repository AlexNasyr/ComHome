using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ComHome.Data {
    public enum SensorType { 
        Temperature, Humidity, Pressure, illumination
    }
    public class Sensor {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(32)]
        public string SensorUID { get; set; }
        [Required]
        [MaxLength(32)]
        public string SensorName { get; set; }
        public SensorType? SensorType { get; set; }
    }
}
