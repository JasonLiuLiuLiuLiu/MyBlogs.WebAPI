using System.Collections.Generic;
using System.Linq;
using MyBlogs.Domain;
using MyBlogs.DTO;
using MyBlogs.DAO.DAO;

namespace MyBlogs.Service
{
    public class CommentService:ICommentService
    {
        private readonly IWp_commentDAO _commentDao;

        public CommentService(IWp_commentDAO commentDao)
        {
            _commentDao = commentDao;
        }
        public CommentResponse FindById(int id)
        {
            return ChangeToResopnse(_commentDao.FindById(id));
        }

        public List<CommentResponse> GetAll()
        {
            return _commentDao.GetAll().Select(ChangeToResopnse).ToList();
        }

        public CommentResponse GetLast()
        {
            return ChangeToResopnse(_commentDao.GetLast());
        }

        public bool Update(CommentRequest request)
        {
            if (request == null)
                return false;
            var entity = _commentDao.FindById(request.Id);
            if (entity == null)
                return false;
            entity.comment_content = request.Content;
            _commentDao.Update(entity);

            return true;
        }

        public bool Delete(int id)
        {
            var entity = _commentDao.FindById(id);
            if (entity == null)
                return false;
            _commentDao.Remove(entity);
            return true;
        }

        private CommentResponse ChangeToResopnse(Wp_comment entity)
        {
            return new CommentResponse()
            {
                Id = entity.comment_ID,
                Author = entity.comment_author,
                AuthorEmail = entity.comment_author_email,
                IP = entity.comment_author_IP,
                CommentDate = entity.comment_date,
                Content = entity.comment_content
            };
        }

    }
}