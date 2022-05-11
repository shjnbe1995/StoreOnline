using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace DataLayer.DataContext
{
    //public class AppConfiguration
    //{
    //    public AppConfiguration()
    //    {
    //        var configBuilder = new ConfigurationBuilder();
    //        var path = Path.Combine(Directory.GetCurrentDirectory(), "appsetting.json");
    //        configBuilder.AddJsonFile(path, false); // NOT OPTIONAL 
    //        var root = configBuilder.Build();
    //        var appSetting = root.GetSection("ConnectionStrings:DefaultConnection");
    //        SqlConnectionString = appSetting.Value;
    //    }
    //    public string SqlConnectionString { get; set; }
    //}
}
