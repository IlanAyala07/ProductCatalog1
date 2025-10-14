namespace ProductCatalog
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Pages.ProductListPage), typeof(Pages.ProductListPage));
            Routing.RegisterRoute(nameof(Pages.ProductEditPage), typeof(Pages.ProductEditPage));

            Routing.RegisterRoute(nameof(Pages.CategoryListPage), typeof(Pages.CategoryListPage));
            Routing.RegisterRoute(nameof(Pages.CategoryEditPage), typeof(Pages.CategoryEditPage));

            Routing.RegisterRoute(nameof(Pages.SupplierListPage), typeof(Pages.SupplierListPage));
            Routing.RegisterRoute(nameof(Pages.SupplierEditPage), typeof(Pages.SupplierEditPage));

            Routing.RegisterRoute(nameof(Pages.BrandListPage), typeof(Pages.BrandListPage));
            Routing.RegisterRoute(nameof(Pages.BrandEditPage), typeof(Pages.BrandEditPage));
        }
    }
}
