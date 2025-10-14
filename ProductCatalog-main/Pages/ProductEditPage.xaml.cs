using ProductCatalog.Models;
using ProductCatalog.ViewModels;

namespace ProductCatalog.Pages
{
    [QueryProperty(nameof(Item), "item")]
    public partial class ProductEditPage : ContentPage
    {
        public ProductEditPage(ProductViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        // Permite navegación con parámetro '?item='
        public Product? Item
        {
            set
            {
                if (BindingContext is ProductViewModel vm && value != null)
                    vm.EditableItem = value;
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is ProductViewModel vm && vm.EditableItem == null)
                vm.EditableItem = new Product();
        }
    }
}
