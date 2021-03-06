using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using com.orthofeet.Shopify.Entities;
using com.orthofeet.Shopify.Extensions;
using com.orthofeet.Shopify.Filters;
using com.orthofeet.Shopify.Infrastructure;
using com.orthofeet.Shopify.Lists;

namespace com.orthofeet.Shopify.Services.Fulfillment
{
    /// <summary>
    /// A service for manipulating Shopify fulfillments.
    /// </summary>
    public class FulfillmentService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="FulfillmentService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public FulfillmentService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a count of all of the order's fulfillments.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="filter">Options for filtering the count.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The count of all fulfillments for the shop.</returns>
        public virtual async Task<int> CountAsync(long orderId, FulfillmentCountFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<int>($"orders/{orderId}/fulfillments/count.json", "count", filter, cancellationToken);
        }
        
        /// <summary>
        /// Gets a list of up to 250 of the order's fulfillments.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="filter">Options for filtering the list.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<Entities.Fulfillment>> ListAsync(long orderId, ListFilter<Entities.Fulfillment> filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync($"orders/{orderId}/fulfillments.json", "fulfillments", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the order's fulfillments.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="filter">Options for filtering the list.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<Entities.Fulfillment>> ListAsync(long orderId, FulfillmentListFilter filter, CancellationToken cancellationToken = default)
        {
            return await ListAsync(orderId, filter?.AsListFilter(), cancellationToken);
        }

        /// <summary>
        /// Retrieves the <see cref="Fulfillment"/> with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">The id of the Fulfillment to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Fulfillment"/>.</returns>
        public virtual async Task<Entities.Fulfillment> GetAsync(long orderId, long fulfillmentId, string fields = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<Entities.Fulfillment>($"orders/{orderId}/fulfillments/{fulfillmentId}.json", "fulfillment", fields, cancellationToken);
        }

        /// <summary>
        /// Creates a new <see cref="Fulfillment"/> on the order.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillment">A new <see cref="Fulfillment"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="Fulfillment"/>.</returns>
        public virtual async Task<Entities.Fulfillment> CreateAsync(long orderId, Entities.Fulfillment fulfillment, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments.json");
            var body = fulfillment.ToDictionary();

            var content = new JsonContent(new
            {
                fulfillment = body
            });

            var response = await ExecuteRequestAsync<Entities.Fulfillment>(req, HttpMethod.Post, cancellationToken, content, "fulfillment");
            return response.Result;
        }

        /// <summary>
        /// Updates the given <see cref="Fulfillment"/>.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">Id of the object being updated.</param>
        /// <param name="fulfillment">The <see cref="Fulfillment"/> to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="Fulfillment"/>.</returns>
        public virtual async Task<Entities.Fulfillment> UpdateAsync(long orderId, long fulfillmentId, Entities.Fulfillment fulfillment, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/{fulfillmentId}.json");
            var body = fulfillment.ToDictionary();
            var content = new JsonContent(new
            {
                fulfillment = body
            });

            var response = await ExecuteRequestAsync<Entities.Fulfillment>(req, HttpMethod.Put, cancellationToken, content, "fulfillment");
            return response.Result;
        }

        /// <summary>
        /// Completes a pending fulfillment with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">The fulfillment's id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<Entities.Fulfillment> CompleteAsync(long orderId, long fulfillmentId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/{fulfillmentId}/complete.json");

            var response = await ExecuteRequestAsync<Entities.Fulfillment>(req, HttpMethod.Post, cancellationToken, rootElement: "fulfillment");
            return response.Result;
        }

        /// <summary>
        /// Cancels a pending fulfillment with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">The fulfillment's id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<Entities.Fulfillment> CancelAsync(long orderId, long fulfillmentId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/{fulfillmentId}/cancel.json");

            var response = await ExecuteRequestAsync<Entities.Fulfillment>(req, HttpMethod.Post, cancellationToken, rootElement: "fulfillment");
            return response.Result;
        }

        /// <summary>
        /// Opens a pending fulfillment with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">The fulfillment's id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<Entities.Fulfillment> OpenAsync(long orderId, long fulfillmentId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/{fulfillmentId}/open.json");

            var response = await ExecuteRequestAsync<Entities.Fulfillment>(req, HttpMethod.Post, cancellationToken, rootElement: "fulfillment");
            return response.Result;
        }
    }
}
