using AutoMapper;
using Collections.Portal.Models;
using Collections.Portal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collections.Portal.Extensions;

namespace Collections.Portal.Infrastructure
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration()
        {
            CreateMap<MovieViewModel, MoviesModel>()
                .ForMember(dest => dest.Directors, opts => opts.MapFrom(src => src.Directors.SplitStringToList()))
                .ForMember(dest => dest.Genres, opts => opts.MapFrom(src => src.Genres.SplitStringToList()))
                .ForMember(dest => dest.Producers, opts => opts.MapFrom(src => src.Producers.SplitStringToList()))
                .ForMember(dest => dest.Writers, opts => opts.MapFrom(src => src.Writers.SplitStringToList()))
                .ForMember(dest => dest.Cast, opts => opts.MapFrom(src => src.Cast.SplitStringToList()));
        }
    }
}
