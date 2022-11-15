using System;
using Microsoft.AspNetCore.Mvc;
using MagicVilla_VillaAPI.Models;

namespace MagicVilla_VillaAPI.Controllers
{
	[Route("api/VillaAPI")]
	[ApiController]
	public class VillaAPIContoller : ControllerBase
	{
		[HttpGet]
		public IEnumerable<Villa> GetVillas()
		{
			return new List<Villa>
			{
				new Villa{Id=1, Name="Pool View"},
				new Villa{Id=2, Name="Beach View"}
			};
		}

		public VillaAPIContoller()
		{
		}
	}
}

