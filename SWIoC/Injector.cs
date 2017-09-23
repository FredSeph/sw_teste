using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWIoC
{
    public static class Injector
    {
        private static Container _container;

        //public T RegisterAndGetInstance<T>() where T : class
        //{
        //    _container = new Container();

        //    _container.Register<T>();
        //    _container.Verify();

        //    return _container.GetInstance<T>();
        //}
    }
}