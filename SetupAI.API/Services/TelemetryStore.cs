using System;
using System.Collections.Generic;
using System.Linq;
using SetupAI.API.Models;

namespace SetupAI.API.Services
{
	public class TelemetryStore
	{
		private readonly List<TelemetryData> _telemetryList = new();

		public void AddTelemetry(TelemetryData data)
		{
			_telemetryList.Add(data);
		}

		public TelemetryData? GetLatestTelemetry()
		{
			return _telemetryList.LastOrDefault();
		}

		public List<TelemetryData> GetAllTelemetry()
		{
			return _telemetryList;
		}

		public string GenerateSetupRecommendation()
		{
			var latest = GetLatestTelemetry();
			
			if (latest == null)
			{
				return "there is no telemetry data available.";
			}

			if (latest.TirePressurePsi < 27)
			{
				return "Recommendation: Add more pressure to tires for more stability.";
			}
			else if (latest.AverageSpeedKph < 120)
			{
				return "Recommendation: Check aerodinamic charge and pressure to get better average speed.";
			}
			else
			{
				return "Actual setup looks balanced. keep monitoring telemetry.";
			}
		}
	}
}
