using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace com.orthofeet.Shopify.Services.Policy
{
    public class PolicyService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="PolicyService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public PolicyService(string myShopifyUrl, string shopAccessToken): base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Get the policies and their contents for a shop
        /// </summary>
        public virtual async Task<IEnumerable<Entities.Policy>> ListAsync(CancellationToken cancellationToken = default)
        {
            var request = PrepareRequest("policies.json");
            var response = await ExecuteRequestAsync<List<Entities.Policy>>(request, HttpMethod.Get, cancellationToken, rootElement: "policies");

            return response.Result;
        }
    }
}
