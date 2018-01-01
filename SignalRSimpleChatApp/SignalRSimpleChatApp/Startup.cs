using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRSimpleChatApp.Startup))]

namespace SignalRSimpleChatApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            app.MapSignalR(); // gerekli sinalR methodu eklenerek signalR kütüphanesinin proje içerisinde kullanılacağını belirtiyoruz.
        }
    }
}
