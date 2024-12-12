using Microsoft.Extensions.DependencyInjection;
using ProjectN.Service.Implement;
using ProjectN.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN.DIExtensions
{
    /// <summary>
    /// Service 相關註冊
    /// </summary>
    public static class ServiceDIExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICardService, CardService>();

            return services;
        }
    }
}
