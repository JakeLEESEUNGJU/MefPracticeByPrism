using LoginModule;
using Prism.Mef;
using Prism.Modularity;
using StateInfoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MefPracticeByPrism
{
    class Bootstrapper : MefBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return new Shell();
        }
        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }
        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }
        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();

            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(Bootstrapper).Assembly));

            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(LoginModule.LoginModule).Assembly));

            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(StateInfoModule.StateInfoModule).Assembly));

            //DirectoryCatalog catalog = new DirectoryCatalog("DirectoryModules");
            //this.AggregateCatalog.Catalogs(catalog);

            //ModuleCatalog moduleCatalogL = (ModuleCatalog)this.ModuleCatalog;
            //moduleCatalogL.AddModule(typeof(LoginModule.LoginModule));

            //ModuleCatalog moduleCatalog2 = (ModuleCatalog)this.ModuleCatalog;
            //moduleCatalog2.AddModule(typeof(StateInfoModule.StateInfoModule));
        }
    }
}
