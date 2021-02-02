﻿using ApplicatonProcess.December2020.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ApplicatonProcess.December2020.Domain.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        { }
            public DbSet<PersonalInfo> PersonalInfos { get; set; }
    }
}
