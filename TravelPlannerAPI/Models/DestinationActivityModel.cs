using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace TravelPlannerAPI.Models
{
	public class DestinationActivityModel
	{
        [Key]
        public int Id { get; set; }

        public int DestinationId { get; set; }  // Foreign key to DestinationModel
        public DestinationModel Destination { get; set; }  // Reference to DestinationModel

        public int ActivityId { get; set; }  // Foreign key to ActivityModel
        public ActivityModel Activity { get; set; }  // Reference to ActivityModel
    }
}

