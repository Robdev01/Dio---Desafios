
using MinimalApi;
using minimal_api;
using Minimalapi;

IHostBuilder CreateHostBuilder(string[] args){
  return Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.UseStartup<Startup>();
    });
}

CreateHostBuilder(args).Build().Run();