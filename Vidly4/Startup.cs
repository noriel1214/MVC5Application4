using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly4.Startup))]
namespace Vidly4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

/*
echo "# MVC5Application4" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/noriel1214/MVC5Application4.git
git push -u origin main
*/