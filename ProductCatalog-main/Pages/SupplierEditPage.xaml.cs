using ProductCatalog.Models;
using ProductCatalog.ViewModels;

namespace ProductCatalog.Pages
{
    [QueryProperty(nameof(Item), "item")]
    public partial class SupplierEditPage : ContentPage
    {
        public SupplierEditPage(SupplierViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        public Supplier? Item
        {
            set
            {
                if (BindingContext is SupplierViewModel vm && value != null)
                    vm.EditableItem = value;
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is SupplierViewModel vm && vm.EditableItem == null)
                vm.EditableItem = new Supplier();
        }
    }
}
