using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace ConsoleTemplate
{
    public class App
    {
        private ILogger<App> _logger;
        private IConfigurationRoot _config;
        public App(ILogger<App> logger, IConfigurationRoot config)
        {
            this._config = config ?? throw new NullReferenceException(nameof(config));
            this._logger = logger ?? throw new NullReferenceException(nameof(logger));
        }
        public Task Run()
        {
            System.Console.WriteLine("helloworld programmversion " + _config.GetSection("appVersion").Value);
            return Task.CompletedTask;
        }

    }
}
