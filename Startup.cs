using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProposalManageSystem.Startup))]
namespace ProposalManageSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
