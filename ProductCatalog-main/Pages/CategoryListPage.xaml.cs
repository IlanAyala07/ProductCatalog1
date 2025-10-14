using ProductCatalog.ViewModels;

namespace ProductCatalog.Pages
{
    public partial class CategoryListPage : ContentPage
    {
        public CategoryListPage(CategoryViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is CategoryViewModel vm)
                await vm.LoadAsync();
        }
    }
}
