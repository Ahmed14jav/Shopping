using System;
using System.Net.Http.Headers;

namespace Shopping
{
    public class Cart
    {
        #region private attributes
        private List<CartItem> _cartItems = new List<CartItem>();
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

        public void Remove(List<CartItem> cartItemsToRemove = null)
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
                float currentCartPrice = 0;
                foreach(var item in _cartItems)
                {
                    currentCartPrice += item.Article.Price * item.Quantity;
                }
                return currentCartPrice;
            }
        }

        public int Cheapest(int ArticleId)
        {
            
        }

        public bool DoesExist(int ArticleId)
        {
            foreach(CartItem cartItem in _cartItems)
            {
                if (cartItem.Article.Id = ArticleId) 
                    return true;
            }
            return false;
        }

      
        #endregion public methodsss
        public class CartException : Exception { }
    }
}
