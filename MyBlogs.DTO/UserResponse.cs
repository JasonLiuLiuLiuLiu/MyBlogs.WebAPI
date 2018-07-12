using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlogs.DTO
{
    public class UserResponse
    {
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string NiceName { get; set; }
        public string Email { get; set; }
        public String Status  { get; set; }
    }
}
