using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrainStations.Models
{
    public class StationDistance
    {
        [Key]
        public int StationDistanceId { get; set; }
        //[ForeignKey("Distance_1")]
        public int Distance1 { get; set; }
        public virtual Stations Stations1 { get; set; }
        //[ForeignKey("Distance_2")]
        public int Distance2 { get; set; }
        public virtual Stations Stations2 { get; set; }

        public double Distance { get; set; }
    }
}