using PsscProject.Helpers.Domain;
using PsscProject.Models.Carts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Purchases
{
    public class Purchase : IAggregateRoot
    {
        private List<PurchasedProduct> purchasedProducts = new List<PurchasedProduct>();

        public Guid Id { get; protected set; }
        public ReadOnlyCollection<PurchasedProduct> Products
        {
            get { return purchasedProducts.AsReadOnly(); }
        }
        public DateTime Created { get; protected set; }
        public Guid CustomerId { get; protected set; }
        public decimal TotalTax { get; protected set; }
        public decimal TotalCost { get; protected set; }

        public static Purchase Create(Cart cart)
        {
            Purchase purchase = new Purchase()
            {
                Id = Guid.NewGuid(),
                Created = DateTime.Today,
                CustomerId = cart.CustomerId,
                TotalCost = cart.TotalCost,
                TotalTax = cart.TotalTax
            };

            List<PurchasedProduct> purchasedProducts = new List<PurchasedProduct>();
            foreach (CartProduct cartProduct in cart.Products)
            {
                purchasedProducts.Add(PurchasedProduct.Create(purchase, cartProduct));
            }

            purchase.purchasedProducts = purchasedProducts;

            return purchase;
        }
    }
}
