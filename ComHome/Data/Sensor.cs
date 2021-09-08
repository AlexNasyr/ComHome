using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ComHome.Data {
    public class Sensor {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string SensorUID { get; set; }
        public string SensorName { get; set; }
        public string SensorType { get; set; }
    }
}
