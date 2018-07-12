using System;
using System.Collections.Generic;
using System.Text;
using MyBlogs.Domain;

namespace MyBlogs.DAO.DAO
{
    public interface IWp_commentDAO
    {
        Wp_comment FindById(int id);

        List<Wp_comment> GetAll();

        Wp_comment GetLast();

        void Update(Wp_comment comment);

        void Remove(Wp_comment entity);
    }
}
