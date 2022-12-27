using Caliburn.Micro;
using System.ComponentModel;
using System.Threading.Tasks;
using TRMDesktopUI.Ibrary.Api;
using TRMDesktopUI.Ibrary.Models;

namespace TRMDesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {
        private IProductEndpoint _productEndpoint;

        public SalesViewModel(IProductEndpoint productEndpoint)
        {
            _productEndpoint = productEndpoint;
        }

        protected override async void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            await LoadProducts();
        }

        private async Task LoadProducts()
        {
            Products = new BindingList<Product>(await _productEndpoint.GetAll());
        }

        private BindingList<Product> _products;

        public BindingList<Product> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        private BindingList<string> _cart;

        public BindingList<string> Cart
        {
            get { return _cart; }
            set
            {
                _cart = value;
                NotifyOfPropertyChange(() => Cart);
            }
        }

        public string SubTotal
        {
            get
            {
                // TODO: Replace with calculation
                return "$0.00";
            }
        }

        public string Tax
        {
            get
            {
                // TODO: Replace with calculation
                return "$0.00";
            }
        }

        public string Total
        {
            get
            {
                // TODO: Replace with calculation
                return "$0.00";
            }
        }

        private int _itemQuantity;

        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set
            {
                _itemQuantity = value;
                NotifyOfPropertyChange(() => ItemQuantity);
            }
        }

        public bool CanAddToCart
        {
            get
            {
                // TODO: Make sure something is selected and there is an item quantity
                return false;
            }
        }

        public void AddToCart()
        {

        }

        public bool CanRemoveFromCart
        {
            get
            {
                // TODO: Make sure something is selected
                return false;
            }
        }

        public void RemoveFromCart()
        {

        }

        public bool CanCheckOut
        {
            get
            {
                // TODO: Make sure something is in the cart
                return false;
            }
        }

        public void CheckOut()
        {

        }
    }
}
