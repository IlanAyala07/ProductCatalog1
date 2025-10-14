using ProductCatalog.ViewModels;

namespace ProductCatalog.Pages
{
    public partial class BrandListPage : ContentPage
    {
        public BrandListPage(BrandViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is BrandViewModel vm)
                await vm.LoadAsync();
        }
    }
}
