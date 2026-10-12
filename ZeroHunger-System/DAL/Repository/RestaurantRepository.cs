using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;


namespace DAL.Repository
{
    public  class RestaurantRepository
    {
        ZeroHungerDbContext db;
        public RestaurantRepository(ZeroHungerDbContext db) {

            this.db = db;   
        
        }
        public List <Restaurant> Get()
        {
            return db.Restaurants.ToList();
        }
        public Restaurant Get(int id)
        {
            return db.Restaurants.Find(id)  ;
        }

        public bool Create  (Restaurant r)
        {
            db.Restaurants.Add(r);
            return db.SaveChanges() > 0;

        }
        public bool Update(Restaurant r) {

            var exobj = Get(r.RestaurantId);

            exobj.Name = r.Name;
            exobj.Email = r.Email;
            exobj.ContactNo = r.ContactNo;
            exobj.Address = r.Address;

            return db.SaveChanges() > 0;
        
        }

        public bool Delete (int id)
        {
            var exobj = Get(id);
            db.Restaurants.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<Restaurant> Search(string name)
        {
            return db.Restaurants
                     .Where(x => x.Name.Contains(name))
                     .ToList();
        }


    }
}
