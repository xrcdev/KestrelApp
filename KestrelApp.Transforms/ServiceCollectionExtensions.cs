﻿using KestrelApp.Transforms.Analyzers;
using Microsoft.Extensions.DependencyInjection;

namespace KestrelApp
{
    /// <summary>
    /// ServiceCollection扩展
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 添加流量分析
        /// </summary>
        /// <param name="services"></param> 
        /// <returns></returns>
        public static IServiceCollection AddFlowAnalyze(this IServiceCollection services)
        { 
            return services.AddSingleton<IFlowAnalyzer, FlowAnalyzer>();
        }
    }
}
