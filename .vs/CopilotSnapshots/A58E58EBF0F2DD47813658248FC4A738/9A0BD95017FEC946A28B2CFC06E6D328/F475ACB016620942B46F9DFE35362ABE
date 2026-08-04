using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AI_WPF.Services;
using AI_WPF.ViewModels;

namespace AI_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Simple manual composition; no DI container to keep the demo readable.
            var catalogueService = new CatalogueService();
            var productionService = new ProductionService();
            var salesService = new SalesService(productionService);

            var mainViewModel = new MainViewModel(catalogueService, salesService, productionService);

            var window = new MainWindow
            {
                DataContext = mainViewModel
            };
            window.Show();
        }
    }
}
