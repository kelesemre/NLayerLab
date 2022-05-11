using NLayerLab.Entities.Concrete;
using NLayerLab.Entities.Dtos;
using NLayerLab.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerLab.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<Category>> Get(int categoryId);
        Task<IDataResult<IList<Category>>> GetAll();
        Task<IDataResult<IList<Category>>> GetAllUndeleted();
        Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName);
        Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
        Task<IResult> Delete(int categoryId,string modifiedByName);
        Task<IResult> HardDelete(int categoryId);
    }
}
