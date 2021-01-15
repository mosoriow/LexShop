using LexShop.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LexShop.Core.Contract
{
    public interface IBasketService
    {
        void AddToBasket(HttpContextBase httpContext, string productID);
        void RemoveFromBasket(HttpContextBase httpContext, string itemsID);

        List<BasketItemViewModel> GetBasketItems(HttpContextBase httpContext);
        BasketSummaryViewModel GetBasketSummary(HttpContextBase httpContext);
    }
}
