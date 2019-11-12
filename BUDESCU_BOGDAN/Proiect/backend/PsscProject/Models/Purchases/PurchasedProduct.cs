﻿using PsscProject.Models.Carts;
using PsscProject.Models.Generic;
using PsscProject.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Purchases
{
    public class PurchasedProduct
    {
        public Guid PurchaseId { get; protected set; }
        public Guid ProductId { get; protected set; }
        public Quantity Quantity { get; protected set; }

        public static PurchasedProduct Create(Purchase purchase, CartProduct cartProduct)
        {
            return new PurchasedProduct()
            {
                ProductId = cartProduct.ProductId,
                PurchaseId = purchase.Id,
                Quantity = cartProduct.Quantity
            };
        }
    }
}
