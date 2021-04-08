using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.ServiceModel;
using Application.Features.ProductFeatures.Operation;
using Domain.Entities;
using System;

namespace Application.Interfaces
{
	[ServiceContract(Namespace ="http:name.space/dataservice")]
	public interface IDataService
	{
		[OperationContract(Action = "RetrieveEMDDetailsbyDocumentNumberItem")]
		public Task<EMDDetailsbyDocumentNumberRS> RetrieveEMDDetailsbyDocumentNumberItem(RetrieveEMDDetailsbyDocumentNumber query);
	}
}