using AutoMapper;
using NLayerLab.Entities.Concrete;
using NLayerLab.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerLab.Services.AutoMapper.Profiles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleAddDto, Article>().ForMember(dest => dest.CreatedDate, option => option.MapFrom(x => DateTime.Now)); //Csutom mapping
            CreateMap<ArticleUpdateDto, Article>().ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
        }
    }
}
