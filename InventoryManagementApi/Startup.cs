﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IM.Core.Configurator;
using IM.Services.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Newtonsoft.Json.Serialization;

namespace InventoryManagementApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver()); ;
            services.Configure<CurrentSettings>(Configuration.GetSection("CurrentSettings"));
            var monitor = services.BuildServiceProvider().GetService<IOptionsMonitor<CurrentSettings>>();
            if (monitor.CurrentValue.DatabaseSettings.CurrentDatabase == IM.Core.Enums.CurrentDatabase.MongoDB)
            {
                services.AddSingleton<IMongoClient>((a) => new MongoClient(monitor.CurrentValue.MongoDBSettings.ConnectionString));
                services.AddScoped<IItemService, ItemManager>();
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
