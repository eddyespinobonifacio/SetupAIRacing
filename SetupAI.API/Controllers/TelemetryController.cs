using System;
using Microsoft.AspNetCore.Mvc;
using SetupAI.API.Models;
using SetupAI.API.Services;

/// <summary>
/// Summary description for TelemetryController
/// </summary>
namespace SetupAI.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class TelemetryController : ControllerBase
	{
		private readonly TelemetryStore _store;
		public TelemetryController(TelemetryStore store)
		{
			_store = store;
		}
	
		[HttpPost]
		public IActionResult SubmitTelemetry([FromBody] TelemetryData data)
		{
			_store.AddTelemetry(data);
			return Ok("Telemetry received succesfully");
		}

		[HttpGet("latest")]
		public ActionResult<TelemetryData> GetLatestTelemetry()
		{
			var latest = _store.GetLatestTelemetry();
			if (latest == null)
				return NotFound(" No data Available.");
			return Ok(latest);
		}
		[HttpGet("recommendation")]
		public ActionResult<string> GetSetupRecommendation()
		{
			var recommendation = _store.GenerateSetupRecommendation();
			return Ok(recommendation);
		}
		[HttpGet]
		public ActionResult<List<TelemetryData>> GetAllTelemetry()
		{
			var all = _store.GetAllTelemetry();
			return Ok(all);
		}
	}
}