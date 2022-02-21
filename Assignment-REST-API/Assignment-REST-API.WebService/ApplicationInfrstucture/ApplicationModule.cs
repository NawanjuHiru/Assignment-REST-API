using Assignment_REST_API.Business;
using Assignment_REST_API.Business.Interface;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_REST_API.WebService.ApplicationInfrstucture
{
    public class ApplicationModule : Autofac.Module
    {
        public ApplicationModule()
        {

        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SAPService>()
                 .As<ISAPService>()
                 .SingleInstance();
        }
    }
}
