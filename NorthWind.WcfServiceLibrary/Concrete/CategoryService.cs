using NorthWind.Dal.Abstract;
using NorthWind.Dal.Concrete.EntityFramework;
using NorthWind.Entities.Concrete;
using NorthWind.Interfaces;
using NorthWindBussinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.WcfServiceLibrary.Concrete
{
    public class CategoryService:ICategoryService
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        public List<Category> GetAll()
        {
            return categoryManager.GetAll();
        }
    }
}
