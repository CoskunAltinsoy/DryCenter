using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class City:IEntity<int>
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string NameOfCity { get; set; }
    }
}
