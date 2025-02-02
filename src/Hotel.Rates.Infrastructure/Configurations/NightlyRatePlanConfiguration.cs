﻿using System.Collections.Generic;
using Hotel.Rates.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel.Rates.Infrastructure.Configurations
{
    public class NightlyRatePlanConfiguration : IEntityTypeConfiguration<NightlyRatePlan>
    {
        public void Configure(EntityTypeBuilder<NightlyRatePlan> builder)
        {
            builder.HasData(new List<NightlyRatePlan>
            {
                new NightlyRatePlan
                {
                    Id = -1,
                    Name = "Verano 2020",
                    Price = 500
                },
                 new NightlyRatePlan
                {
                    Id = -2,
                    Name = "Invierno 2020",
                    Price = 200
                }
            });
        }
    }
}
