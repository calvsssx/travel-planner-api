using System;
using System.ComponentModel.DataAnnotations;

namespace TravelPlannerAPI.Models
{
    public class DestinationModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public List<DestinationActivityModel> DestinationActivities { get; set; }
        public List<TripModel> Trips { get; set; }  // Reference to TripModel
        public List<TripDestinationModel> TripDestinations { get; set; }

    }

}

