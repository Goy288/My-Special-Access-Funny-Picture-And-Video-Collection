using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using My_Special_Access_Funny_Picture_And_Video_Collection.Data;

[assembly: HostingStartup(typeof(My_Special_Access_Funny_Picture_And_Video_Collection.Areas.Identity.IdentityHostingStartup))]
namespace My_Special_Access_Funny_Picture_And_Video_Collection.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}