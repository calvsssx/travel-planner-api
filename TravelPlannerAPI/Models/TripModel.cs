using System;
using System.ComponentModel.DataAnnotations;

namespace TravelPlannerAPI.Models
{
	public class TripModel
	{
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int DestinationId { get; set; }  // Foreign key to DestinationModel
        public DestinationModel Destination { get; set; }  // Reference to DestinationModel

        public List<TripDestinationModel> TripDestinations { get; set; }
    }
}

