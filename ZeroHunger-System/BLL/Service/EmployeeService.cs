using AutoMapper;
using BLL.Models;
using DAL.EF.Tables;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Service
{
    public class EmployeeService
    {
        EmployeeRepository repository;
        IMapper mapper;

        public EmployeeService(EmployeeRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public List<EmployeeModel> Get()
        {
            var data = repository.Get();
            return mapper.Map<List<EmployeeModel>>(data);
        }

        public EmployeeModel Get(int id)
        {

            var data = repository.Get(id);
            return mapper.Map<EmployeeModel>(data);
        }

        public bool Create(EmployeeModel model)
        {
            var data = mapper.Map<Employee>(model);

            return repository.Create(data);
        }

        public bool Update(EmployeeModel model)
        {
            var data = mapper.Map<Employee>(model);

            return repository.Update(data);
        }

        public bool Delete(int id)
        {

            return repository.Delete(id);
        }

        public List<Employee> Search(string name)
        {
            return repository.Search(name);
        }

    }
}
