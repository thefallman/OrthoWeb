using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using com.orthofeet.Shopify.Entities;
using com.orthofeet.Shopify.Infrastructure;

namespace com.orthofeet.Shopify.Services.FulfillmentEvent
{
    /// <summary>
    /// A service for manipulating Shopify fulfillment events.
    /// </summary>
    public class FulfillmentEventService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="FulfillmentEventService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public FulfillmentEventService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Get a list of all fulfillment events for a fulfillment
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillment belongs to.</param>
        /// <param name="fulfillmentId">The fulfillment id to which the fulfillment events belong to.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The list of fulfillment events for the given fulfillment.</returns>
        public virtual async Task<IEnumerable<Entities.FulfillmentEvent>> ListAsync(long orderId, long fulfillmentId, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<IEnumerable<Entities.FulfillmentEvent>>($"orders/{orderId}/fulfillments/{fulfillmentId}/events.json", "fulfillment_events", cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Retrieves the <see cref="FulfillmentEvent"/> with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillment belongs to.</param>
        /// <param name="fulfillmentId">The id of the fulfillment to which the event belongs to.</param>
        /// <param name="fulfillmentEventId">The id of the fulfillment event to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="FulfillmentEvent"/>.</returns>
        public virtual async Task<Entities.FulfillmentEvent> GetAsync(long orderId, long fulfillmentId, long fulfillmentEventId, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<Entities.FulfillmentEvent>($"orders/{orderId}/fulfillments/{fulfillmentId}/events/{fulfillmentEventId}.json", "fulfillment_event", cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Creates a new <see cref="FulfillmentEvent"/> on the fulfillment.
        /// </summary>
        /// <param name="event">A new <see cref="Fulfillment"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="FulfillmentEvent"/>.</returns>
        public virtual async Task<Entities.FulfillmentEvent> CreateAsync(long orderId, long fulfillmentId, Entities.FulfillmentEvent @event, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/{fulfillmentId}/events.json");

            var content = new JsonContent(new
            {
                @event
            });

            var response = await ExecuteRequestAsync<Entities.FulfillmentEvent>(req, HttpMethod.Post, cancellationToken, content, "fulfillment_event");
            return response.Result;
        }

        /// <summary>
        /// Deletes the <see cref="FulfillmentEvent"/> with the given Id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillment belongs to.</param>
        /// <param name="fulfillmentId">The id of the fulfillment to which the event belongs to.</param>
        /// <param name="fulfillmentEventId">The id of the fulfillment event to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task DeleteAsync(long orderId, long fulfillmentId, long fulfillmentEventId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/{fulfillmentId}/events/{fulfillmentEventId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }
    }
}
