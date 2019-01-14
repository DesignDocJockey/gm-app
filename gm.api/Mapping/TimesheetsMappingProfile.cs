using AutoMapper;
using gm.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gm.api.Mapping
{
    public class TimesheetsMappingProfile : Profile
    {
        public TimesheetsMappingProfile()
        {
            CreateMap<TimesheetDataModel, TimesheetDto>();
            CreateMap<TimesheetDto, TimesheetDataModel>();
        }
    }
}
