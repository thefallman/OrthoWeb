using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using com.orthofeet.Shopify.Entities;
using com.orthofeet.Shopify.Filters;
using com.orthofeet.Shopify.Infrastructure;
using com.orthofeet.Shopify.Lists;

namespace com.orthofeet.Shopify.Services.ScriptTag
{
    /// <summary>
    /// A service for manipulating Shopify's ScriptTag API.
    /// </summary>
    public class ScriptTagService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ScriptTagService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ScriptTagService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a count of all of the shop's <see cref="ScriptTag"/>s.
        /// </summary>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<int> CountAsync(ScriptTagCountFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<int>("script_tags/count.json", "count", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's script tags.
        /// </summary>
        public virtual async Task<ListResult<Entities.ScriptTag>> ListAsync(ListFilter<Entities.ScriptTag> filter, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync("script_tags.json", "script_tags", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's script tags.
        /// </summary>
        public virtual async Task<ListResult<Entities.ScriptTag>> ListAsync(ScriptTagListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ListAsync(filter?.AsListFilter(), cancellationToken);
        }

        /// <summary>
        /// Retrieves the <see cref="ScriptTag"/> with the given id.
        /// </summary>
        /// <param name="tagId">The id of the <see cref="ScriptTag"/> to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="ScriptTag"/>.</returns>
        public virtual async Task<Entities.ScriptTag> GetAsync(long tagId, string fields = null, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"script_tags/{tagId}.json");

            if (!string.IsNullOrEmpty(fields))
            {
                req.QueryParams.Add("fields", fields);
            }

            var response = await ExecuteRequestAsync<Entities.ScriptTag>(req, HttpMethod.Get, cancellationToken, rootElement: "script_tag");

            return response.Result;
        }

        /// <summary>
        /// Creates a new <see cref="ScriptTag"/> on the store.
        /// </summary>
        /// <param name="tag">A new <see cref="ScriptTag"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="ScriptTag"/>.</returns>
        public virtual async Task<Entities.ScriptTag> CreateAsync(Entities.ScriptTag tag, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest("script_tags.json");
            var content = new JsonContent(new
            {
                script_tag = tag
            });
            var response = await ExecuteRequestAsync<Entities.ScriptTag>(req, HttpMethod.Post, cancellationToken, content, "script_tag");

            return response.Result;
        }

        /// <summary>
        /// Updates the given <see cref="ScriptTag"/>.
        /// </summary>
        /// <param name="scriptTagId">Id of the object being updated.</param>
        /// <param name="tag">The <see cref="ScriptTag"/> to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="ScriptTag"/>.</returns>
        public virtual async Task<Entities.ScriptTag> UpdateAsync(long scriptTagId, Entities.ScriptTag tag, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"script_tags/{scriptTagId}.json");
            var content = new JsonContent(new
            {
                script_tag = tag
            });
            var response = await ExecuteRequestAsync<Entities.ScriptTag>(req, HttpMethod.Put, cancellationToken, content, "script_tag");

            return response.Result;
        }

        /// <summary>
        /// Deletes the <see cref="ScriptTag"/> with the given Id.
        /// </summary>
        /// <param name="tagId">The tag's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task DeleteAsync(long tagId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"script_tags/{tagId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }
    }
}
