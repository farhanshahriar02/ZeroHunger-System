using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class CollectRequestRepository
    {
        ZeroHungerDbContext db;
        
        public CollectRequestRepository (ZeroHungerDbContext db)
        {
            this.db= db;
        }

        public List<CollectRequest> Get()
        {
            return db.CollectRequests.ToList();
        }
        public CollectRequest Get(int id)
        {
            return db.CollectRequests.Find(id);
        }

        public bool Create(CollectRequest r)
        {
            db.CollectRequests.Add(r);
            return db.SaveChanges() > 0;

        }
        public bool Update(CollectRequest r)
        {

            var exobj = Get(r.RequestId);

            exobj.CollectionDate = r.CollectionDate;
            exobj.FoodDescription   = r.FoodDescription;
            exobj.Status    = r.Status;
            exobj.Remarks = r.Remarks;
            exobj.EmployeeId = r.EmployeeId;
            exobj.Quantity = r.Quantity;
            exobj.EmployeeId =r.EmployeeId;
            exobj.RequestId = r.RequestId;
            return db.SaveChanges() > 0;

        }

        public bool Delete(int id)
        {
            var exobj = Get(id);
            db.CollectRequests.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<CollectRequest> GetPending()
        {
            return db.CollectRequests
                     .Where(x => x.Status == "Pending")
                     .ToList();
        }








    }
}
