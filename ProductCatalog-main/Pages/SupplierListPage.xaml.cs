using ProductCatalog.ViewModels;

namespace ProductCatalog.Pages
{
    public partial class SupplierListPage : ContentPage
    {
        public SupplierListPage(SupplierViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is SupplierViewModel vm)
                await vm.LoadAsync();
        }
    }
}
