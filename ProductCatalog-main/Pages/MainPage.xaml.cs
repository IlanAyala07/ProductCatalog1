namespace ProductCatalog.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage() => InitializeComponent();

        private async void OpenProducts(object sender, EventArgs e) =>
            await Shell.Current.GoToAsync(nameof(ProductListPage));

        private async void OpenCategories(object sender, EventArgs e) =>
            await Shell.Current.GoToAsync(nameof(CategoryListPage));

        private async void OpenSuppliers(object sender, EventArgs e) =>
            await Shell.Current.GoToAsync(nameof(SupplierListPage));

        private async void OpenBrands(object sender, EventArgs e) =>
            await Shell.Current.GoToAsync(nameof(BrandListPage));
    }
}
