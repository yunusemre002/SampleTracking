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

        public void addSample(Sample entity)
        {
            context.Samples.Add(entity);
            context.SaveChanges();
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

        public void updateSample(Sample entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
