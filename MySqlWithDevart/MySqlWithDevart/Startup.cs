using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySqlWithDevart.Startup))]

namespace MySqlWithDevart
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			ConfigureAuth(app);
		}
	}
}