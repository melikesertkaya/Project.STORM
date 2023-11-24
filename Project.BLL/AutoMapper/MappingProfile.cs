using AutoMapper;
using Project.BLL.DTO.Request;
using Project.BLL.DTO.Response;
using Project.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Product Request
            CreateMap<Product, CreateProductRequest>();
            CreateMap<CreateProductRequest, Product>();
            CreateMap<Product, DeleteProductRequest>();
            CreateMap<DeleteProductRequest, Product>();
            CreateMap<Product, UpdateProductRequest>();
            CreateMap<UpdateProductRequest, Product>();
            #endregion
            #region Product Response
            CreateMap<Product, GetAllProductQueryResponse>();
            CreateMap<GetAllProductQueryResponse, Product>(); 

            CreateMap<Product, ProductGetByIdQueryResponse>();
            CreateMap<ProductGetByIdQueryResponse, Product>();

            CreateMap<Product, GetByPriceProductQueryResponse>();
            CreateMap<GetByPriceProductQueryResponse, Product>();
            CreateMap<Product, GetAllProductQueryResponse>();
            CreateMap<GetAllProductQueryResponse, Product>();
            #endregion
            #region Campaign Request
            CreateMap<Campaign, CreateCampaignRequest>();
            CreateMap<CreateCampaignRequest, Campaign>();
            CreateMap<Campaign, UpdateCampaignRequest>();
            CreateMap<UpdateCampaignRequest, Campaign>();
            CreateMap<Campaign, DeleteCampaignRequest>();
            CreateMap<DeleteCampaignRequest, Campaign>();
            #endregion
            #region Campaign Response
            CreateMap<Campaign, GetAllCampaignQueryResponse>();
            CreateMap<GetAllCampaignQueryResponse, Campaign>();
            CreateMap<Campaign,GetCampaignQueryResponse >();
            CreateMap<GetCampaignQueryResponse, Campaign>();
            #endregion
            #region Category Request
            CreateMap<Category, CreateCategoryRequest>();
            CreateMap<CreateCategoryRequest, Category>(); 
            CreateMap<Category, UpdateCategoryRequest>();
            CreateMap<UpdateCategoryRequest, Category>();
            CreateMap<Category, DeleteCategoryRequest>();
            CreateMap<DeleteCategoryRequest, Category>();


            #endregion
            #region Category Response
            CreateMap<Category, GetAllCategoryQueryResponse>();
            CreateMap<GetAllCategoryQueryResponse, Category>();
            CreateMap<Category, GetCategoryQueryResponse>();
            CreateMap<GetCategoryQueryResponse, Category>();
            #endregion
            #region Order Request
            CreateMap<Order, CreateOrderRequest>();
            CreateMap<CreateOrderRequest, Order>();
            CreateMap<Order, UpdateOrderRequest>();
            CreateMap<UpdateOrderRequest, Order>();
            CreateMap<Order, DeleteOrderRequest>();
            CreateMap<DeleteOrderRequest, Order>();
            #endregion
            #region Order Response
            CreateMap<Order, GetAllOrderQueryResponse>();
            CreateMap<GetAllOrderQueryResponse, Order>();
            CreateMap<Order, GetByOrderIdQueryResponse>();
            CreateMap<GetByOrderIdQueryResponse, Order>();
            #endregion
            #region Basket Request
            CreateMap<Basket, AddToBasketRequest>();
            CreateMap<AddToBasketRequest, Basket>();
            CreateMap<Basket, DeleteBasketRequest>();
            CreateMap<DeleteBasketRequest, Basket>();
            #endregion
            #region Basket Response
            CreateMap<Basket, GetToBasketResponse>();
            CreateMap<GetToBasketResponse, Basket>();
            #endregion


        }
    }
}
