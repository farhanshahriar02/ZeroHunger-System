using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class DistributionRepository
    {
        ZeroHungerDbContext db;
        public DistributionRepository (ZeroHungerDbContext db)
        {

            this.db = db;

        }
        public List<Distribution> Get()
        {
            return db.Distributions.ToList();
        }
        public Distribution Get(int id)
        {
            return db.Distributions.Find(id);
        }

        public bool Create(Distribution r)
        {
            db.Distributions.Add(r);
            return db.SaveChanges() > 0;

        }
        public bool Update(Distribution r)
        {

            var exobj = Get(r.DistributionId);

            exobj.DistributionLocation = r.DistributionLocation;
            exobj.DistributionDate = r.DistributionDate;
            exobj.DistributedQuantity = r.DistributedQuantity;
            exobj.BeneficiaryCount = r.BeneficiaryCount;
            exobj.EmployeeId = r.EmployeeId;
            exobj.Remarks = r.Remarks;
            exobj.RequestId = r.RequestId;
            exobj.EmployeeId =r.EmployeeId;
            return db.SaveChanges() > 0;

        }

        public bool Delete(int id)
        {
            var exobj = Get(id);
            db.Distributions.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<Distribution> GetHighBeneficiary()
        {
            return db.Distributions
                     .Where(x => x.BeneficiaryCount > 10)
                     .ToList();
        }


    }
}
