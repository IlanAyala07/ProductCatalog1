using ProductCatalog.ViewModels;

namespace ProductCatalog.Pages
{
    public partial class ProductListPage : ContentPage
    {
        public ProductListPage(ProductViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is ProductViewModel vm)
                await vm.LoadAsync();
        }
    }
}
