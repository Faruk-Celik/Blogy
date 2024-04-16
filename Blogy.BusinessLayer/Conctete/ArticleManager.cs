using Blogy.BusinessLayer.Abstract;
using Blogy.DataAccessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.Conctete
{
    public class ArticleManager : IArticleService
    {
        private readonly IArticleDal _articleDal;

        public ArticleManager ( IArticleDal articleDal )
        {
            _articleDal = articleDal;
        }

        public List<Article> TGetListAll ()
        {
            
            return _articleDal.GetListAll();
        }

        public void TDelete ( int id )
        {
            if (id != 0)
            {
                _articleDal.Delete(id);
            }
            else
            {
                //Error message
            }
        }

        public Article TGetById ( int id )
        {
            //eğer id derğerine göre yetkisi varsa
            return _articleDal.GetById(id);
        }

        public void TInsert ( Article entity )
        {
            if (entity.Title!=null && entity.Description.Length>50 && entity.CategoryId>=0)
            {
                _articleDal.Insert(entity);
            }
            else
            {
                //Error message
            }
        }

        public void TUpdate ( Article entity )
        {
            if (entity.Title != null && entity.Description.Length > 50 && entity.CategoryId >= 0)
            {
                _articleDal.Insert(entity);
            }
            else
            {
                //Error message
            }
        }

		

        public Writer TGetWriterInfoByArticleWriter ( int id )
        {
            return _articleDal.GetWriterInfoByArticleWriter(id);
        }

        public List<Article> TGetArticleWithWriter ()
        {
            return _articleDal.GetArticleWithWriter();
        }
    }
}
