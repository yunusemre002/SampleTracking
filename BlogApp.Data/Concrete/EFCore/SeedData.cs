﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjectManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectManagement.Data.Concrete.EFCore
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            PMContext context = app.ApplicationServices.GetRequiredService<PMContext>();

            context.Database.Migrate();


            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee() { Name="Yunus Emre", Surname="Demir"},
                    new Employee() { Name="Fatih", Surname="Dere"},
                    new Employee() { Name="Egemen", Surname="Dere"}
                    );
                context.SaveChanges();
            }

            if (!context.Samples.Any())
            {
                context.Samples.AddRange(
                        new Sample() { Customer="Müşteri2",EmployeeId=2,RequestDate=DateTime.Now.AddDays(-6),SampleType="Numune2 Tip",Size="XXL", SampleState="Yeni"},
                        new Sample() { Customer="Müşteri1",EmployeeId=1,RequestDate=DateTime.Now.AddDays(-5),SampleType="Numune1 Tip",Size="XXL", SampleState="İşlemde"},
                        new Sample() { Customer="Müşteri2",EmployeeId=2,RequestDate=DateTime.Now.AddDays(-7),SampleType="Numune3 Tip",Size="XXL", SampleState="Tamamlandı"},
                        new Sample() { Customer="Müşteri3",EmployeeId=3,RequestDate=DateTime.Now.AddDays(-8),SampleType="Numune2 Tip",Size="XXL", SampleState="Beklemede"}
                    );
                context.SaveChanges();
            }


        } 
    }
}
