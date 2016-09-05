using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

namespace webapp1_aadb2c
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
