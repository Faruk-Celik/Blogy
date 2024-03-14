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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager ( ICategoryDal categoryDal )
        {
            _categoryDal = categoryDal;
        }

        public List<Category> TGetListAll ()
        {
           return _categoryDal.GetListAll();
        }

        public void TDelete ( int id )
        {
            _categoryDal.Delete(id);
        }

        public Category TGetById ( int id )
        {
            return _categoryDal.GetById(id);
        }

        public void TInsert ( Category entity )
        {
            _categoryDal.Insert(entity);
        }

        public void TUpdate ( Category entity )
        {
            _categoryDal.Update(entity);    
        }

        public int TGetCategoryCount ()
        {
            return _categoryDal.GetCategoryCount ();
        }
    }
}
