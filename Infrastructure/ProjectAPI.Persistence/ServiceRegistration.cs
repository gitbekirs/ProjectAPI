﻿using Microsoft.Extensions.DependencyInjection;
using ProjectAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ProjectAPIDbContext>(options=>options.UseNpgsql())
        }
    }
}
