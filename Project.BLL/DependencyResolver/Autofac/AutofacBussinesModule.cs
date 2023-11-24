using Autofac;
using Castle.DynamicProxy;
using Project.BLL.Abstract;
using Project.BLL.Concrete;
using Project.CORE.Utilities.Interceptors;
using Project.CORE.Utilities.JWTToken;
using Project.DAL.Abstract;
using Project.DAL.Concrete;
using Autofac.Extras.DynamicProxy;
using Project.BLL.AutoMapper;
using AutoMapper;
using System.Collections.Generic;
 


namespace Project.BLL.DependencyResolver.Autofac
{
    public class AutofacBussinesModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<ProductDataAccess>().As<IProductDataAccess>();

            builder.RegisterType<OrderCampaignDetailManager>().As<IOrderCampaignDetailService>().SingleInstance();
            builder.RegisterType<OrderCampaignDetailDataAccess>().As<IOrderCampaignDetailDataAccess>();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<CategoryDataAccess>().As<ICategoryDataAccess>();


            builder.RegisterType<CampaignManager>().As<ICampaignService>().SingleInstance();
            builder.RegisterType<CampaignDataAccess>().As<DAL.Abstract.ICampaignDataAccess>();

            builder.RegisterType<BasketManager>().As<IBasketService>().SingleInstance();
            builder.RegisterType<BasketDataAccess>().As<IBasketDataAccess>();


            builder.RegisterType<ProductCampaignDetailManager>().As<IProductCampaignDetailService>().SingleInstance();
            builder.RegisterType<ProductCampaignDetailDataAccess>().As<IProductCampaignDetailDataAccess>();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<CategoryDataAccess>().As<ICategoryDataAccess>();


            builder.RegisterType<OrderDetailManager>().As<IOrderDetailService>().SingleInstance();
            builder.RegisterType<OrderDetailDataAccess>().As<IOrderDetailDataAccess>();

            builder.RegisterType<OrderManager>().As<IOrderService>().SingleInstance();
            builder.RegisterType<OrderDataAccess>().As<IOrderDataAccess>();


            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            builder.RegisterType<UserManager>().As<IUserService>();

            builder.RegisterType<UserDataAccess>().As<IUserDataAccess>();
            builder.RegisterType<JWTHelper>().As<ITokenHelper>();

            #region AutoMapper
            builder.RegisterType<MappingProfile>().As<Profile>();
            builder.Register(c => new MapperConfiguration(cfg =>
            {
                foreach (var profile in c.Resolve<IEnumerable<Profile>>())
                {
                    cfg.AddProfile(profile);
                }
            })).AsSelf().SingleInstance();
            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve)).As<IMapper>().InstancePerLifetimeScope();

            #endregion
            //TODO Yetki kontrol icin bakılacak suanda patlıyor burası
            //var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            //builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(new ProxyGenerationOptions()
            //{

            //    Selector = new AspectInterceptorSelector()
            //}).SingleInstance();

        }


    }
}
