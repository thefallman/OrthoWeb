using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using com.orthofeet.Shopify.Extensions;
using com.orthofeet.Shopify.Filters;

namespace com.orthofeet.Shopify.Services.ShippingZone
{
    /// <summary>
    /// A service for retrieve Shopify shipping zones.
    /// </summary>
    public class ShippingZoneService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ShippingZoneService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShippingZoneService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Retrieves a list of all shipping zones. 
        /// </summary>
        public virtual async Task<IEnumerable<Entities.ShippingZone>> ListAsync(ShippingZoneListFilter filter = null, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest("shipping_zones.json");
            
            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }
            
            var response = await ExecuteRequestAsync<List<Entities.ShippingZone>>(req, HttpMethod.Get, cancellationToken, rootElement: "shipping_zones");

            return response.Result;
        }
    }
}
