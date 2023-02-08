using System;
using System.Configuration;
using System.IO;
using MessagesBAL;
using Microsoft.Extensions.Configuration;

namespace MessagesService
{
    class Program
    {
        static void Main(string[] args)
        {
           // GetAppSettingsFile();
           ManageCaseHearing manageCase = new ManageCaseHearing();
            manageCase.CaseHearing();
           // Console.WriteLine("Hello World!");
            System.Environment.Exit(0);
        }
        private static IConfiguration _iconfiguration;
        static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",
                    optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
           // _Connection = _iconfiguration.GetConnectionString("IGRSCCDB");
        }
       
    }
}
