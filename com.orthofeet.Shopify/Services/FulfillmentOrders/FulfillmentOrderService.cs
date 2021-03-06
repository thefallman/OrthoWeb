using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using com.orthofeet.Shopify.Entities;

namespace com.orthofeet.Shopify.Services.FulfillmentOrders
{
    /// <summary>
    /// A service for manipulating Shopify fulfillment orders.
    /// </summary>
    public class FulfillmentOrderService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="FulfillmentOrderService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public FulfillmentOrderService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of up to 250 of the order's fulfillments.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<IEnumerable<FulfillmentOrder>> ListAsync(long orderId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillment_orders.json");
            var response = await ExecuteRequestAsync<IEnumerable<FulfillmentOrder>>(req, HttpMethod.Get, cancellationToken, rootElement: "fulfillment_orders");

            return response.Result;
        }
    }
}
