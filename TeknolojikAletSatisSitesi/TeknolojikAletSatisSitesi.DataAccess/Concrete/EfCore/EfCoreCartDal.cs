﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeknolojikAletSatisSitesi.DataAccess.Abstract;
using TeknolojikAletSatisSitesi.Entities;

namespace TeknolojikAletSatisSitesi.DataAccess.Concrete.EfCore
{
    public class EfCoreCartDal : EfCoreGenericRepository<Cart, ShopContext>, ICartDal
    {
        public Cart GetByUserId(string userId)
        {
            using(var context = new ShopContext())
            {
                return context
                            .Carts
                            .Include(i => i.CartItems)
                            .ThenInclude(i => i.Product)
                            .FirstOrDefault(i => i.UserId == userId);
            }
        }
    }
}
