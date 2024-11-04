using InventoryAppGraphic.Models.Repositories;
using InventoryAppGraphic.Presenters;
using InventoryAppGraphic.Services;
using InventoryAppGraphic.Views;


namespace InventoryAppGraphic
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            MainView mainView = new();
            CategoryRepository categoryRepository = new();
            CategoryService categoryService = new(categoryRepository);
            ProductRepository productRepository = new();
            ProductService productService = new(productRepository);
            MainPresenter mainPresenter = new(mainView, categoryService, productService);

            Application.Run(mainView);
        }
    }
}