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

		public int Occupancy { get; set; }
		public int Sqft { get; set; }

        public VillaDTO()
		{
		}
	}
}

