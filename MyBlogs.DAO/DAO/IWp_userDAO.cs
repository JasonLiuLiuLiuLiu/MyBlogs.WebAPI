using System.Collections.Generic;
using MyBlogs.Domain;

namespace MyBlogs.DAO.DAO
{
    public interface IWp_userDAO
    {
        Wp_user FindById(int id);

        List<Wp_user> GetAll();
    }
}