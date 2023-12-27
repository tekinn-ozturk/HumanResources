using HumanResources.Application.Abstract;
using HumanResources.Persistence.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Persistence
{
	//Extension fonksiyonları tanımladığımız için static bir class olmalı.Nedeni ise instance almadan rahat bir şekilde çağırabilelim.
	public static class ServiceRegistration
	{
		public static void AddPersistenceServices(this IServiceCollection services)
		{
			services.AddSingleton<IProductService, ProductService>();
		}
	}
}
