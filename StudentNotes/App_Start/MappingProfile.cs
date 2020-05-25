﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using StudentNotes.Dtos;
using StudentNotes.Models;

namespace StudentNotes.App_Start
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            Mapper.CreateMap<Student, StudentDto>();
            Mapper.CreateMap<StudentDto, Student>();



            // Ignore studentId in mapping, as it is auto generated by database. 
            Mapper.CreateMap<StudentDto, Student>()
                .ForMember(s => s.Id, opt => opt.Ignore());

        }

    }
}