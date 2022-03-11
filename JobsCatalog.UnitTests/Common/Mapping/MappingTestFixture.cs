﻿using AutoMapper;
using JobsCatalog.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.UnitTests.Common.Mapping
{
    public class MappingTestFixture
    {
        public MappingTestFixture()
        {
            ConfigurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            Mapper = ConfigurationProvider.CreateMapper();
        }
        public IConfigurationProvider ConfigurationProvider { get; set; }
        public IMapper Mapper { get; set; }
    }
}
