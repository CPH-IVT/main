﻿using CPH.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPH.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed db with state information
            builder.Entity<States>().HasData(
                new States
                {
                    Id = 1,
                    Abbriviation = "AL",
                    Name = "ALABAMA"
                },
                new States
                {
                    Id = 2,
                    Abbriviation = "AK",
                    Name = "ALASKA"
                },
                new States
                {
                    Id = 4,
                    Abbriviation = "AZ",
                    Name = "ARIZONA"
                },
                new States
                {
                    Id = 5,
                    Abbriviation = "AR",
                    Name = "ARKANSAS"
                },
                new States
                {
                    Id = 6,
                    Abbriviation = "CA",
                    Name = "CALIFORNIA"
                },
                new States
                {
                    Id = 8,
                    Abbriviation = "CO",
                    Name = "COLORADO"
                },
                new States
                {
                    Id = 9,
                    Abbriviation = "CT",
                    Name = "CONNECTICUT"
                },
                new States
                {
                    Id = 10,
                    Abbriviation = "DE",
                    Name = "DELAWARE"
                },
                new States
                {
                    Id = 12,
                    Abbriviation = "FL",
                    Name = "FLORIDA"
                },
                new States
                {
                    Id = 13,
                    Abbriviation = "GA",
                    Name = "GEORGIA"
                },
                new States
                {
                    Id = 15,
                    Abbriviation = "HI",
                    Name = "HAWAII"
                },
                new States
                {
                    Id = 16,
                    Abbriviation = "ID",
                    Name = "IDAHO"
                },
                new States
                {
                    Id = 17,
                    Abbriviation = "IL",
                    Name = "ILLINOIS"
                },
                new States
                {
                    Id = 18,
                    Abbriviation = "IN",
                    Name = "INDIANA"
                },
                new States
                {
                    Id = 19,
                    Abbriviation = "IA",
                    Name = "IOWA"
                },
                new States
                {
                    Id = 20,
                    Abbriviation = "KS",
                    Name = "KANSAS"
                },
                new States
                {
                    Id = 21,
                    Abbriviation = "KY",
                    Name = "KENTUCKY"
                },
                new States
                {
                    Id = 22,
                    Abbriviation = "LA",
                    Name = "LOUISIANA"
                },
                new States
                {
                    Id = 23,
                    Abbriviation = "ME",
                    Name = "MAINE"
                },
                new States
                {
                    Id = 24,
                    Abbriviation = "MD",
                    Name = "MARYLAND"
                },
                new States
                {
                    Id = 25,
                    Abbriviation = "MA",
                    Name = "MASSACHUSETTS"
                },
                new States
                {
                    Id = 26,
                    Abbriviation = "MI",
                    Name = "MICHIGAN"
                },
                new States
                {
                    Id = 27,
                    Abbriviation = "MN",
                    Name = "MINNESOTA"
                },
                new States
                {
                    Id = 28,
                    Abbriviation = "MS",
                    Name = "MISSISSIPPI"
                },
                new States
                {
                    Id = 29,
                    Abbriviation = "MO",
                    Name = "MISSOURI"
                },
                new States
                {
                    Id = 30,
                    Abbriviation = "MT",
                    Name = "MONTANA"
                },
                new States
                {
                    Id = 31,
                    Abbriviation = "NE",
                    Name = "NEBRASKA"
                },
                new States
                {
                    Id = 32,
                    Abbriviation = "NV",
                    Name = "NEVADA"
                },
                new States
                {
                    Id = 33,
                    Abbriviation = "NH",
                    Name = "NEW HAMPSHIRE"
                },
                new States
                {
                    Id = 34,
                    Abbriviation = "NJ",
                    Name = "NEW JERSEY"
                },
                new States
                {
                    Id = 35,
                    Abbriviation = "NM",
                    Name = "NEW MEXICO"
                },
                new States
                {
                    Id = 36,
                    Abbriviation = "NY",
                    Name = "NEW YORK"
                },
                new States
                {
                    Id = 37,
                    Abbriviation = "NC",
                    Name = "NORTH CAROLINA"
                },
                new States
                {
                    Id = 38,
                    Abbriviation = "ND",
                    Name = "NORTH DAKOTA"
                },
                new States
                {
                    Id = 39,
                    Abbriviation = "OH",
                    Name = "OHIO"
                },
                new States
                {
                    Id = 40,
                    Abbriviation = "OK",
                    Name = "OKLAHOMA"
                },
                new States
                {
                    Id = 41,
                    Abbriviation = "OR",
                    Name = "OREGON"
                },
                new States
                {
                    Id = 42,
                    Abbriviation = "PA",
                    Name = "PENNSYLVANIA"
                },
                new States
                {
                    Id = 44,
                    Abbriviation = "RI",
                    Name = "RHODE ISLAND"
                },
                new States
                {
                    Id = 45,
                    Abbriviation = "SC",
                    Name = "SOUTH CAROLINA"
                },
                new States
                {
                    Id = 46,
                    Abbriviation = "SD",
                    Name = "SOUTH DAKOTA"
                },
                new States
                {
                    Id = 47,
                    Abbriviation = "TN",
                    Name = "TENNESSEE"
                },
                new States
                {
                    Id = 48,
                    Abbriviation = "TX",
                    Name = "TEXAS"
                },
                new States
                {
                    Id = 49,
                    Abbriviation = "UT",
                    Name = "UTAH"
                },
                new States
                {
                    Id = 50,
                    Abbriviation = "VT",
                    Name = "VERMONT"
                },
                new States
                {
                    Id = 51,
                    Abbriviation = "VA",
                    Name = "VIRGINIA"
                },
                new States
                {
                    Id = 53,
                    Abbriviation = "WA",
                    Name = "WASHINGTON"
                },
                new States
                {
                    Id = 54,
                    Abbriviation = "WV",
                    Name = "WEST VIRGINIA"
                },
                new States
                {
                    Id = 55,
                    Abbriviation = "WI",
                    Name = "WISCONSIN"
                },
                new States
                {
                    Id = 56,
                    Abbriviation = "WY",
                    Name = "WYOMING"
                },
                new States
                {
                    Id = 60,
                    Abbriviation = "AS",
                    Name = "AMERICAN SAMOA"
                },
                new States
                {
                    Id = 66,
                    Abbriviation = "GU",
                    Name = "GUAM"
                },
                new States
                {
                    Id = 69,
                    Abbriviation = "MP",
                    Name = "NORTHERN MARIANA ISLANDS"
                },
                new States
                {
                    Id = 72,
                    Abbriviation = "PR",
                    Name = "PUERTO RICO"
                },
                new States
                {
                    Id = 78,
                    Abbriviation = "VI",
                    Name = "VIRGIN ISLANDS"
                }
                );
        }

        public DbSet<Counties> Counties { get; set; }
        public DbSet<DatapointColumns> DatapointColumns { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<RegionCounties> RegionCounties { get; set; }
        public DbSet<SavedChartCounties> SavedChartCounties { get; set; }
        public DbSet<SavedChartDatapoints> SavedChartDatapoints { get; set; }
        public DbSet<SavedChartRegions> SavedChartRegions { get; set; }
        public DbSet<SavedCharts> SavedCharts { get; set; }
        public DbSet<SavedChartYear> SavedChartYear { get; set; }
        public DbSet<States> States { get; set; }

    }
}
