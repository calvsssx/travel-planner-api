using System;
using System.ComponentModel.DataAnnotations;

namespace TravelPlannerAPI.Models
{
	public class ActivityModel
	{
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<DestinationActivityModel> DestinationActivities { get; set; }
    }
}

