﻿using AutoMapper;
using TimeTracker.Application.Activities.Commands.UpdateActivity;
using TimeTracker.Application.Common.Mappings;
using TimeTracker.Domain;

namespace TimeTracker.Api.Models
{
    public class UpdateActivityDto : IMapWith<UpdateActivityCommand>
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public List<Guid> TagIds { get; set; }
        public Guid? ProjectId { get; set; }
        public long StartInMilliseconds { get; set; }
        public long? EndInMilliseconds { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateActivityDto, UpdateActivityCommand>()
                .ForMember(cmd => cmd.Id,
                    opt => opt.MapFrom(dto => dto.Id))
                .ForMember(cmd => cmd.Description,
                    opt => opt.MapFrom(dto => dto.Description))
                .ForMember(cmd => cmd.TagIds,
                    opt => opt.MapFrom(dto => dto.TagIds))
                .ForMember(cmd => cmd.ProjectId,
                    opt => opt.MapFrom(dto => dto.ProjectId))
                .ForMember(cmd => cmd.StartInMilliseconds,
                    opt => opt.MapFrom(dto => dto.StartInMilliseconds))
                .ForMember(cmd => cmd.EndInMilliseconds,
                    opt => opt.MapFrom(dto => dto.EndInMilliseconds));
        }
    }
}
