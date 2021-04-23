using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using com.orthofeet.Shopify.Entities;
using com.orthofeet.Shopify.Filters;
using com.orthofeet.Shopify.Infrastructure;
using com.orthofeet.Shopify.Lists;
using com.orthofeet.Shopify.Services.Customer;

namespace com.orthofeet.Shopify.Services.Collect
{
    /// <summary>
    /// A service for manipulating mapping between Shopify products and collections.
    /// </summary>
    public class CollectService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CustomerService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CollectService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        public virtual async Task<int> CountAsync(CollectCountFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<int>("collects/count.json", "count", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's collects.
        /// </summary>
        public virtual async Task<ListResult<Entities.Collect>> ListAsync(ListFilter<Entities.Collect> filter, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync("collects.json", "collects", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's collects.
        /// </summary>
        public virtual async Task<ListResult<Entities.Collect>> ListAsync(CollectListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ListAsync(filter?.AsListFilter(), cancellationToken);
        }

        /// <summary>
        /// Retrieves the <see cref="Collect"/> with the given id.
        /// </summary>
        /// <param name="collectId">The id of the collect to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Collect"/>.</returns>
        public virtual async Task<Entities.Collect> GetAsync(long collectId, string fields = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<Entities.Collect>($"collects/{collectId}.json", "collect", fields, cancellationToken);
        }


        /// <summary>
        /// Creates a new <see cref="Collect"/> on the store. Map product to collection
        /// </summary>
        /// <param name="collect">A new <see cref="Collect"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="Collect"/>.</returns>
        public virtual async Task<Entities.Collect> CreateAsync(Entities.Collect collect, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest("collects.json");
            var content = new JsonContent(new
            {
                collect = collect
            });

            var response = await ExecuteRequestAsync<Entities.Collect>(req, HttpMethod.Post, cancellationToken, content, "collect");
            return response.Result;
        }

        /// <summary>
        /// Deletes a collect with the given Id.
        /// </summary>
        /// <param name="collectId">The product object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task DeleteAsync(long collectId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"collects/{collectId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }
    }
}
