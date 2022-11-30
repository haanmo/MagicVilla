using System;
using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    // as we created a database, we don't need it anymore.
	public static class VillaStore
	{
		public static List<VillaDTO> villaList = new List<VillaDTO>
        {
            new VillaDTO{Id=1, Name="Pool View", Sqft=100, Occupancy=4},
            new VillaDTO{Id=2, Name="Beach View", Sqft=100, Occupancy=3}
        };
	}
}

