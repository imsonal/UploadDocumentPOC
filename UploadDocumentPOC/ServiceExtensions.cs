


using BussinessLayer;
using Helper;
using ServiceLayer.Impl;
using ServiceLayer.Interface;
using TradingViewUdfProvider;
using TradingViewUdfProvider.Example;

namespace UploadDocumentPOCWebAPI
{
    public static class ServiceExtensions
    {
        public static void DIScopes(this IServiceCollection services)
        {
              services.AddTradingViewProvider<MyTvProvider>();
            //Helpers
              services.AddScoped<CommonHelper>();

                //services.AddScoped<AuthRepo>();
                services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

                //BLL
                services.AddScoped<UserLogBLL>();
                services.AddScoped<YahooFinanceBLL>();
                services.AddScoped<TradingViewBLL>();


                //Services
                services.AddScoped<IUserLog, UserLogImpl>();
                services.AddScoped<IYahooFinance, YahooFinanceImpl>();
                services.AddScoped<ServiceLayer.Interface.ITradingView, TradingViewImpl>();



        }


    }
}
