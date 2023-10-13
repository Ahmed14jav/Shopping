using System;
using System.Net.Http.Headers;

namespace Shopping
{
    public class Cart
    {
        #region private attributes
        private List<CartItem> _cartItems = new List<CartItem>();
        private float _price;
        #endregion private attributes

        #region public methods
        public void Add(List<CartItem> cartItems)
        {
            _cartItems = cartItems;
        }

        public List<Article> Remove(Boolean clearCart = false)
        {
            List<Article> articlesReadyToCheckout = new List<Article>();
            if (clearCart) 
            {
                articlesReadyToCheckout.Clear();
                return articlesReadyToCheckout;
            }
            else
            {
                return articlesReadyToCheckout;
            }
        }

        public void Release() { }

        public void Remove(List<CartItem> cartItemsToRemove)

        {
            throw new NotImplementedException();
        }

        public List<CartItem> CartItems
        {
            get
            {
                return _cartItems;
            }
        }

        public float Price
        {
            get
            {
                return _price;
            }
        }
        #endregion public methods
    }
}
