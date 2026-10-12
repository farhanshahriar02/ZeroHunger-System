using AutoMapper;
using BLL.Models;
using DAL.EF.Tables;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Service
{
    public class CollectRequestService
    {
        CollectRequestRepository repository;
        IMapper mapper;

        public CollectRequestService(CollectRequestRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public List<CollectRequestModel> Get()
        {
            var data = repository.Get();
            return mapper.Map<List<CollectRequestModel>>(data);
        }

        public CollectRequestModel Get(int id)
        {

            var data = repository.Get(id);
            return mapper.Map<CollectRequestModel>(data);
        }

        public bool Create(CollectRequestModel model)
        {
            var data = mapper.Map<CollectRequest>(model);

            return repository.Create(data);
        }

        public bool Update(CollectRequestModel model)
        {
            var data = mapper.Map<CollectRequest>(model);

            return repository.Update(data);
        }

        public bool Delete(int id)
        {

            return repository.Delete(id);
        }

        public List<CollectRequest> GetPending()
        {
            return repository.GetPending();
        }
    }
}
