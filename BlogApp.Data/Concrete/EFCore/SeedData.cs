using Microsoft.AspNetCore.Builder;
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
                        new Sample() { Customer="Müşteri2",EmployeeId=2,RequestDate=DateTime.Now.AddDays(-6),SampleType="Numune2 Tip",Size="XXL", SampleState=Entity.Enums.State.Yeni, Termin="termin", Artikel="artikel", CustomerModelNo = "mm numarası", Color="beyaz", RequestedCount = 5, ModelDescription ="açıklama", AccessoryTermin="aksesuar termin", MeshFinishDate= DateTime.Now.AddDays(-6), PaintDeliveryDate= DateTime.Now.AddDays(-5), PaintFinishDate= DateTime.Now.AddDays(-6),SewingFinishDate= DateTime.Now.AddDays(-6),  DeliveryDate= DateTime.Now.AddDays(-3), DelayDescription="bu sebepten", DeliveryTime="yarın" },
                        new Sample() { Customer="Müşteri2",EmployeeId=2,RequestDate=DateTime.Now.AddDays(-6),SampleType="Numune2 Tip",Size="XXL", SampleState= Entity.Enums.State.Yeni, Termin="termin", Artikel="artikel", CustomerModelNo = "mm numarası", Color="beyaz", RequestedCount = 5, ModelDescription ="açıklama", AccessoryTermin="aksesuar termin", MeshFinishDate= DateTime.Now.AddDays(-6), PaintDeliveryDate= DateTime.Now.AddDays(-5), PaintFinishDate= DateTime.Now.AddDays(-6),SewingFinishDate= DateTime.Now.AddDays(-6),  DeliveryDate= DateTime.Now.AddDays(-3), DelayDescription="bu sebepten", DeliveryTime="yarın" },
                        new Sample() { Customer="Müşteri2",EmployeeId=2,RequestDate=DateTime.Now.AddDays(-6),SampleType="Numune2 Tip",Size="XXL", SampleState= Entity.Enums.State.Yeni, Termin="termin", Artikel="artikel", CustomerModelNo = "mm numarası", Color="beyaz", RequestedCount = 5, ModelDescription ="açıklama", AccessoryTermin="aksesuar termin", MeshFinishDate= DateTime.Now.AddDays(-6), PaintDeliveryDate= DateTime.Now.AddDays(-5), PaintFinishDate= DateTime.Now.AddDays(-6),SewingFinishDate= DateTime.Now.AddDays(-6),  DeliveryDate= DateTime.Now.AddDays(-3), DelayDescription="bu sebepten", DeliveryTime="yarın" }
      
                    );
                context.SaveChanges();
            }


        } 
    }
}
