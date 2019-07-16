using ProjectManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectManagement.Data.Abstract
{
    public interface ISampleRepository
    {
        Sample GetById(int sampleId);
        IQueryable<Sample> GetAll();
        void addSample(Sample entity);
        void updateSample(Sample entity);
        void deleteSample(int sampleId);
    }
}
