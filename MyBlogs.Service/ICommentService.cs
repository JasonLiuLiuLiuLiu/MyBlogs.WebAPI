using System.Collections.Generic;
using MyBlogs.DTO;

namespace MyBlogs.Service
{
    public interface ICommentService
    {
        CommentResponse FindById(int id);

        List<CommentResponse> GetAll();

        CommentResponse GetLast();

        bool Update(CommentRequest request);

        bool Delete(int id);
    }
}