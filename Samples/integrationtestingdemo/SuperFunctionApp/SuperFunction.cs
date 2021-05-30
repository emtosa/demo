using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace SuperFunctionApp
{
	public class SuperFunction
	{
		readonly IHitchhikerGuideToTheGalaxy _hitchhikerGuideToTheGalaxy = new HitchhikerGuideToTheGalaxy();

		[FunctionName(nameof(AnswerToLifeTheUniverseAndEverything))]
		public IActionResult AnswerToLifeTheUniverseAndEverything(
			[HttpTrigger(AuthorizationLevel.Anonymous)] HttpRequest req)
		{
			return new OkObjectResult(_hitchhikerGuideToTheGalaxy.GetTheAnswerToLifeTheUniverseAndEverything());
		}
	}

	public interface IHitchhikerGuideToTheGalaxy
	{
		int GetTheAnswerToLifeTheUniverseAndEverything();
	}

	public class HitchhikerGuideToTheGalaxy : IHitchhikerGuideToTheGalaxy
	{
		readonly ISuperComputer _superComputer = new SuperComputer();

		public int GetTheAnswerToLifeTheUniverseAndEverything() => _superComputer.CalculateTheAnswerToLifeTheUniverseAndEverything();
	}

	public interface ISuperComputer
	{
		int CalculateTheAnswerToLifeTheUniverseAndEverything();
	}

	public class SuperComputer : ISuperComputer
	{
		public int CalculateTheAnswerToLifeTheUniverseAndEverything() => 42;
	}
}
