using AutoMapper;
using BLL.Models;
using DAL.EF.Tables;
using DAL.Repository;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Service
{
    public class RestaurantService
    {
        RestaurantRepository repository;
        IMapper mapper;

        public RestaurantService (RestaurantRepository repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public  List <RestaurantModel> Get()
        {
            var data = repository.Get();
            return mapper.Map<List<RestaurantModel>>(data);
        }

        public  RestaurantModel Get (int id)
        {

            var data = repository.Get(id);
            return mapper.Map <RestaurantModel> (data);
        }

        public bool Create (RestaurantModel model)
        {
            var data = mapper.Map<Restaurant>(model);

            return repository.Create(data);
        }

        public bool Update(RestaurantModel model)
        {
            var data = mapper.Map<Restaurant>(model);

            return repository.Update(data);
        }

        public bool Delete(int id)
        {

            return repository.Delete(id);
        }

        public List<Restaurant> Search(string name)
        {
            return repository.Search(name);
        }


    }
}
