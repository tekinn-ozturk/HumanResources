using HumanResources.Domain.Entities.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Domain.Entities
{
	public class Product : BaseEntity
	{
        public string Name { get; set; }
        public int Stock { get; set; }
        public long Price { get; set; }
    }
}
