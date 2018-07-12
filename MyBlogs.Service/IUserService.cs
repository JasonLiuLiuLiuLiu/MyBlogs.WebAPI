using System.Collections.Generic;
using MyBlogs.DTO;

namespace MyBlogs.Service
{
    public interface IUserService
    {

        UserResponse FindById(int id);

        List<UserResponse> GetAll();
    }
}