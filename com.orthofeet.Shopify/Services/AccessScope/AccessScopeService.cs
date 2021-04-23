using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace com.orthofeet.Shopify.Services.AccessScope
{
    /// <summary>
    /// A service for getting the access scopes associated with the access token
    /// </summary>
    public class AccessScopeService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of the service.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public AccessScopeService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        //oauth endpoints don't support versioning
        protected override bool SupportsAPIVersioning => false;

        /// <summary>
        /// Retrieves a list of access scopes associated to the access token.
        /// </summary>
        public virtual async Task<IEnumerable<Entities.AccessScope>> ListAsync(CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<IEnumerable<Entities.AccessScope>>("oauth/access_scopes.json", "access_scopes", cancellationToken: cancellationToken);
        }
    }
}
