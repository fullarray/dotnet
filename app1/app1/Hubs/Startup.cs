using Owin;
using Microsoft.Owin;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(app1.Startup))]
namespace app1
{
    public class Startup : Hub
    {
        public void Configuration(IAppBuilder app)
        {
            //Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}
