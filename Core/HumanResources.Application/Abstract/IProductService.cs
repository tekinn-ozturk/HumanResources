using HumanResources.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Application.Abstract
{
	public interface IProductService
	{
		List<Product> GetProducts();

	}
}
