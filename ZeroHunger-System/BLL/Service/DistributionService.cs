using AutoMapper;
using BLL.Models;
using DAL.EF.Tables;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Service
{
    public class DistributionService
    {
        DistributionRepository repository;
        IMapper mapper;

        public DistributionService(DistributionRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public List<DistributionModel> Get()
        {
            var data = repository.Get();
            return mapper.Map<List<DistributionModel>>(data);
        }

        public DistributionModel Get(int id)
        {

            var data = repository.Get(id);
            return mapper.Map<DistributionModel>(data);
        }

        public bool Create(DistributionModel model)
        {
            var data = mapper.Map<Distribution>(model);

            return repository.Create(data);
        }

        public bool Update(DistributionModel model)
        {
            var data = mapper.Map<Distribution>(model);

            return repository.Update(data);
        }

        public bool Delete(int id)
        {

            return repository.Delete(id);
        }

        public List<Distribution> GetHighBeneficiary()
        {
            return repository.GetHighBeneficiary();
        }
    }
}
