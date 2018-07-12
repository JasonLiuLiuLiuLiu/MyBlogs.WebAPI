using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlogs.Domain;

namespace MyBlogs.DAO.DAO
{
    public class Wp_userDAO : IWp_userDAO
    {
        private readonly IRepository<Wp_user> _repository;

        public Wp_userDAO(IRepository<Wp_user> repository)
        {
            _repository = repository;
        }

        public Wp_user FindById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Wp_user> GetAll()
        {
            return _repository.Table.ToList();
        }
    }
}
