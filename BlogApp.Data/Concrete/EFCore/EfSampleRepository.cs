using ProjectManagement.Data.Abstract;
using ProjectManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectManagement.Data.Concrete.EFCore
{
    public class EfSampleRepository : ISampleRepository
    {

        private PMContext context;

        public EfSampleRepository(PMContext _context)
        {
            context = _context;
        }

        public Sample addSample(Sample entity)
        {
            context.Samples.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public void deleteSample(int sampleId)
        {
            var sample = context.Samples.FirstOrDefault(p=>p.SampleId==sampleId);

            if (sample != null)
            {
                context.Samples.Remove(sample);
                context.SaveChanges();
            }
        }

        public IQueryable<Sample> GetAll()
        {
            return context.Samples;
        }

        public Sample GetById(int sampleId)
        {
            return context.Samples.FirstOrDefault(p => p.SampleId == sampleId);
        }

        public SampleStatics GetSampleStatics()
        {
            SampleStatics sampleStatics = new SampleStatics();


            sampleStatics.OpenSampleCount = context.Samples.Count(i=>i.SampleState=="Yeni");
            sampleStatics.ClosedSampleCount = context.Samples.Count(i => i.SampleState == "Tamamlandı"); ;
            return sampleStatics;
        }

        public void updateSample(Sample entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
