using NLayerLab.Entities.Concrete;
using NLayerLab.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerLab.Entities.Dtos
{
    public class CategoryDto: DtoGetBase
    {
        public Category Category { get; set; }
    }
}
