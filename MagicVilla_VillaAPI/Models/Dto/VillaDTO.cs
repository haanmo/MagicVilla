using System;
using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.Dto
{
	public class VillaDTO
	{
        public int Id { get; set; }
        // the data annotation below is thanks to [ApiController] in the controller
        [Required]
		[MaxLength(30)]
        public String Name { get; set; }
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }
        public int Sqft { get; set; }
        public int Occupancy { get; set; }
        public string ImageUrl { get; set; }
        public string Amenity { get; set; }

        // we don't want to expose below items.
        //public DateTime CreatedDate { get; set; }
        //public DateTime UpdatedDate { get; set; }

        public VillaDTO()
		{
		}
	}
}

