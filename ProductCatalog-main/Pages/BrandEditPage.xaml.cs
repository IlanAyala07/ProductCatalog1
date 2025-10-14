using ProductCatalog.Models;
using ProductCatalog.ViewModels;

namespace ProductCatalog.Pages
{
    [QueryProperty(nameof(Item), "item")]
    public partial class BrandEditPage : ContentPage
    {
        public BrandEditPage(BrandViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        public Brand? Item
        {
            set
            {
                if (BindingContext is BrandViewModel vm && value != null)
                    vm.EditableItem = value;
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is BrandViewModel vm && vm.EditableItem == null)
                vm.EditableItem = new Brand();
        }
    }
}
