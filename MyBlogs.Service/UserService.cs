using System.Collections.Generic;
using System.Linq;
using MyBlogs.DAO.DAO;
using MyBlogs.Domain;
using MyBlogs.DTO;

namespace MyBlogs.Service
{
    public class UserService:IUserService
    {
        private readonly IWp_userDAO _userDao;

        public UserService(IWp_userDAO userDao)
        {
            _userDao = userDao;
        }

        public UserResponse FindById(int id)
        {
            return ChangeToResopnse(_userDao.FindById(id));
        }

        public List<UserResponse> GetAll()
        {
            return _userDao.GetAll().Select(u => ChangeToResopnse(u)).ToList();
        }

        private UserResponse ChangeToResopnse(Wp_user entity)
        {
            var response = new UserResponse()
            {
                Id = entity.ID,
                Email = entity.user_email,
                NiceName = entity.user_nicename,
                UserLogin = entity.user_login,
            };
            response.Status = entity.user_status == 0 ? "正常" : "禁用";
            return response;
        }
    }
}
