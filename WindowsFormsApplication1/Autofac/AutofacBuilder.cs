using Presenters.Presenters;
using Servises;
using IServices;
using Repositories;
using IRepositories;

using Autofac;

namespace WindowsFormsApplication1.Autofac
{
    public static class AutofacBuilder
    {
        public static IContainer Build()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<SamplePresenter>().As<SamplePresenter>();
            //builder.RegisterType<SampleRepository>().As<ISampleRepository>();
            builder.RegisterType<SampleDBRepository>().As<ISampleRepository>();
            builder.RegisterType<SampleService>().As<ISampleService>();

            return builder.Build();
        }
    }
}
