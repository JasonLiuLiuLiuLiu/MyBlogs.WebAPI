using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlogs.Domain;

namespace MyBlogs.DAO.DAO
{
    public class Wp_commentDAO : IWp_commentDAO
    {
        private readonly IRepository<Wp_comment> _repository;

        public Wp_commentDAO(IRepository<Wp_comment> repository)
        {
            _repository = repository;
        }

        public Wp_comment FindById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Wp_comment> GetAll()
        {
            return _repository.TableNoTracking.ToList();
        }

        public Wp_comment GetLast()
        {
            return _repository.TableNoTracking.OrderByDescending(u => u.comment_date).FirstOrDefault();
        }

        public void Update(Wp_comment comment)
        {
            _repository.Update(comment);
        }

        public void Remove(Wp_comment entity)
        {
            _repository.Delete(entity);
        }
    }
}
