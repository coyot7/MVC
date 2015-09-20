using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Store.Domain.Entities;
using Store.Domain.Abstract;
using System.Collections.Generic;
using System.Linq;
using Store.Domain.Concrete;

namespace Store3
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }
        protected override IController GetControllerInstance(RequestContext
        requestContext, Type controllerType)
        {
            return controllerType == null
            ? null
            : (IController)ninjectKernel.Get(controllerType);
        }
        private void AddBindings()
        {
            ninjectKernel.Bind<IProductRepository>().To<EFProductRepository>();
        }
    }
}