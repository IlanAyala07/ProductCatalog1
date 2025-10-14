using ProductCatalog.Models;
using ProductCatalog.ViewModels;

namespace ProductCatalog.Pages
{
    [QueryProperty(nameof(Item), "item")]
    public partial class CategoryEditPage : ContentPage
    {
        public CategoryEditPage(CategoryViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        public Category? Item
        {
            set
            {
                if (BindingContext is CategoryViewModel vm && value != null)
                    vm.EditableItem = value;
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is CategoryViewModel vm && vm.EditableItem == null)
                vm.EditableItem = new Category();
        }
    }
}
