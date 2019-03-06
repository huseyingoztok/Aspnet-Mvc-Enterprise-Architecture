using Ninject;
using NorthWind.Dal.Concrete.EntityFramework;
using NorthWind.Interfaces;
using NorthWindBussinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NorthWind.MvcWebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel _kernel;
        public NinjectControllerFactory()
        {
            _kernel = new StandardKernel();
            //AddBussinessLayerBindings();
            AddServiceBindings();
        }

        private void AddServiceBindings()
        {
            _kernel.Bind<IProductService>().ToConstant(WcfProxy<IProductService>.CreateChannel());
            _kernel.Bind<ICategoryService>().ToConstant(WcfProxy<ICategoryService>.CreateChannel());
        }

        private void AddBussinessLayerBindings()
        {
            _kernel.Bind<IProductService>().To<ProductManager>().WithConstructorArgument("productDal", new EfProductDal());
            _kernel.Bind<ICategoryService>().To<CategoryManager>().WithConstructorArgument("categoryDal", new EfCategoryDal());
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_kernel.Get(controllerType);
        }
    }
}