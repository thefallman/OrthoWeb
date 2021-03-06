using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using com.orthofeet.Shopify.Entities;
using com.orthofeet.Shopify.Extensions;
using com.orthofeet.Shopify.Filters;
using com.orthofeet.Shopify.Infrastructure;
using com.orthofeet.Shopify.Lists;

namespace com.orthofeet.Shopify.Services.Product
{
    /// <summary>
    /// A service for manipulating Shopify products.
    /// </summary>
    public class ProductService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ProductService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a count of all of the shop's products.
        /// </summary>
        /// <returns>The count of all products for the shop.</returns>
        public virtual async Task<int> CountAsync(ProductCountFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<int>("products/count.json", "count", filter, cancellationToken);
        }
        
        /// <summary>
        /// Gets a list of up to 250 of the shop's products.
        /// </summary>
        public virtual async Task<ListResult<Entities.Product>> ListAsync(ListFilter<Entities.Product> filter, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync("products.json", "products", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's products.
        /// </summary>
        public virtual async Task<ListResult<Entities.Product>> ListAsync(ProductListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ListAsync(filter?.AsListFilter(), cancellationToken);
        }

        /// <summary>
        /// Retrieves the <see cref="Product"/> with the given id.
        /// </summary>
        /// <param name="productId">The id of the product to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Product"/>.</returns>
        public virtual async Task<Entities.Product> GetAsync(long productId, string fields = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<Entities.Product>($"products/{productId}.json", "product", fields, cancellationToken);
        }

        /// <summary>
        /// Creates a new <see cref="Product"/> on the store.
        /// </summary>
        /// <param name="product">A new <see cref="Product"/>. Id should be set to null.</param>
        /// <param name="options">Options for creating the product.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="Product"/>.</returns>
        public virtual async Task<Entities.Product> CreateAsync(Entities.Product product, ProductCreateOptions options = null, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest("products.json");
            var body = product.ToDictionary();

            if (options != null)
            {
                foreach (var option in options.ToDictionary())
                {
                    body.Add(option);
                }
            }

            var content = new JsonContent(new
            {
                product = body
            });
            var response = await ExecuteRequestAsync<Entities.Product>(req, HttpMethod.Post, cancellationToken, content, "product");

            return response.Result;
        }

        /// <summary>
        /// Updates the given <see cref="Product"/>.
        /// </summary>
        /// <param name="productId">Id of the object being updated.</param>
        /// <param name="product">The <see cref="Product"/> to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="Product"/>.</returns>
        public virtual async Task<Entities.Product> UpdateAsync(long productId, Entities.Product product, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"products/{productId}.json");
            var content = new JsonContent(new
            {
                product = product
            });
            var response = await ExecuteRequestAsync<Entities.Product>(req, HttpMethod.Put, cancellationToken, content, "product");

            return response.Result;
        }

        /// <summary>
        /// Deletes a product with the given Id.
        /// </summary>
        /// <param name="productId">The product object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task DeleteAsync(long productId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"products/{productId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }

        /// <summary>
        /// Publishes an unpublished <see cref="Product"/>.
        /// </summary>
        /// <param name="id">The product's id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The published <see cref="Product"/></returns>
        public virtual async Task<Entities.Product> PublishAsync(long id, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"products/{id}.json");
            var content = new JsonContent(new
            {
                product = new
                {
                    id = id,
                    published = true
                }
            });
            var response = await ExecuteRequestAsync<Entities.Product>(req, HttpMethod.Put, cancellationToken, content, "product");

            return response.Result;
        }

        /// <summary>
        /// Unpublishes an published <see cref="Product"/>.
        /// </summary>
        /// <param name="id">The product's id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The unpublished <see cref="Product"/></returns>
        public virtual async Task<Entities.Product> UnpublishAsync(long id, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"products/{id}.json");
            var content = new JsonContent(new
            {
                product = new
                {
                    id = id,
                    published = false
                }
            });
            var response = await ExecuteRequestAsync<Entities.Product>(req, HttpMethod.Put, cancellationToken, content, "product");

            return response.Result;
        }
    }
}
