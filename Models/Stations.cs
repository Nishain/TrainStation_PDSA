using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrainStations.Models
{
    public class Stations
    {
        [Key]
        public int StationsId { get; set; }
        public string StationName { get; set; }
        public virtual ICollection<StationDistance> StationDistances1 { get; set; }
        public virtual ICollection<StationDistance> StationDistances2 { get; set; }
    }
}