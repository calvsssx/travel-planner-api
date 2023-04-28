using System;
using System.ComponentModel.DataAnnotations;

namespace TravelPlannerAPI.Models
{
	public class TripDestinationModel
	{
        [Key]
        public int Id { get; set; }

        public int TripId { get; set; }  // Foreign key to TripModel
        public TripModel Trip { get; set; }  // Reference to TripModel

        public int DestinationId { get; set; }  // Foreign key to DestinationModel
        public DestinationModel Destination { get; set; }  // Reference to DestinationModel
    }
}

