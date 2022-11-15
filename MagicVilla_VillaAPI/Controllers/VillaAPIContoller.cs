using System;
using Microsoft.AspNetCore.Mvc;
using MagicVilla_VillaAPI.Models ;
using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/VillaAPI")]
    //[Route("api/[controller]")] // if the controller name changed, the url changed as well. impacting all api consumers.
    [ApiController]
	public class VillaAPIContoller : ControllerBase
	{
		[HttpGet]
        /*
		public IEnumerable<Villa> GetVillas()
		{
			return new List<Villa>
			{
				new Villa{Id=1, Name="Pool View"},
				new Villa{Id=2, Name="Beach View"}
			};
		}
		*/
        public IEnumerable<VillaDTO> GetVillas()
        {
            return new List<VillaDTO>
            {
                new VillaDTO{Id=1, Name="Pool View"},
                new VillaDTO{Id=2, Name="Beach View"}
            };
        }

        public VillaAPIContoller()
		{
		}
	}
}

