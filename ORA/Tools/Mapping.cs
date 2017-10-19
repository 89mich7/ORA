﻿using AutoMapper;
using ORA.Models;
using ORA_Data.Model;

namespace ORA.Tools
{
    public class Mapping
    {
        public static void MappingMethod()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<AddressVM, AddressDM>().ReverseMap();
                cfg.CreateMap<AssessmentVM, AssessmentDM>().ReverseMap();
                cfg.CreateMap<AssignmentVM, AssignmentDM>().ReverseMap();
                cfg.CreateMap<ClientsVM, ClientsDM>().ReverseMap();
                cfg.CreateMap<KPIVM, KPIDM>().ReverseMap();
                cfg.CreateMap<PositionsVM, PositionsDM>().ReverseMap();
                cfg.CreateMap<ProjectVM, ProjectDM>().ReverseMap();
                cfg.CreateMap<SprintVM, SprintDM>().ReverseMap();
                cfg.CreateMap<StatusVM, StatusDM>().ReverseMap();
                cfg.CreateMap<StoryVM, StoryDM>().ReverseMap();
                cfg.CreateMap<TeamsVM, TeamsDM>().ReverseMap();
                cfg.CreateMap<LoginVM,LoginDM>().ReverseMap();
                cfg.CreateMap<EmployeeVM, EmployeeDM>().ReverseMap();
                cfg.CreateMap<RolesVM, RolesDM>().ReverseMap();
                cfg.CreateMap<EmployeeTimeDM, EmployeeTimeVM>().ReverseMap();
            });
        }
    }
}