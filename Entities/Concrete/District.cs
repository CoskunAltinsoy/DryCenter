using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class District:IEntity<int>
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string NameOfDistrict { get; set; }
    }
}
