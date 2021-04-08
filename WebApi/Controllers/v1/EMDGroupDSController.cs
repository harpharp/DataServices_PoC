using System.Threading.Tasks;
using Application.Features.ProductFeatures.Operation;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebApi.Controllers.v1
{
	[ApiVersion("1.0")]
	public class EMDGroupDSController : BaseApiController
	{

		[HttpPost]
		public async Task<IActionResult> RetrieveEMDDetailsbyDocumentNumberItem(RetrieveEMDDetailsbyDocumentNumber query)
		{
			query.filteredQueries = Program.listOfQueries["RetrieveEMDDetailsbyDocumentNumber"].ToDictionary(p => p.Key, p => p.Value);

			return Ok(await Mediator.Send(query));
		}
	}
}