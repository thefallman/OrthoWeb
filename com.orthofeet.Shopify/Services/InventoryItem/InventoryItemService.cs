using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using com.orthofeet.Shopify.Entities;
using com.orthofeet.Shopify.Filters;
using com.orthofeet.Shopify.Infrastructure;
using com.orthofeet.Shopify.Lists;

namespace com.orthofeet.Shopify.Services.InventoryItem
{
    /// <summary>
    /// A service for manipulating a Shopify inventory items.
    /// </summary>
    public class InventoryItemService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="InventoryItemService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public InventoryItemService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of inventory items.
        /// </summary>
        /// <param name="ids">Show only inventory items specified by a list of IDs. Maximum: 100.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<Entities.InventoryItem>> ListAsync(ListFilter<Entities.InventoryItem> filter, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync($"inventory_items.json", "inventory_items", filter, cancellationToken);
        }

        public virtual async Task<ListResult<Entities.InventoryItem>> ListAsync(InventoryItemListFilter filter, CancellationToken cancellationToken = default)
        {
            return await ListAsync(filter?.AsListFilter(), cancellationToken);
        }

        /// <summary>
        /// Retrieves the <see cref="InventoryItem"/> with the given id.
        /// </summary>
        /// <param name="inventoryItemId">The id of the inventory item to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<Entities.InventoryItem> GetAsync(long inventoryItemId, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<Entities.InventoryItem>($"inventory_items/{inventoryItemId}.json", "inventory_item", cancellationToken: cancellationToken);
        }


        /// <summary>
        /// Updates an existing <see cref="InventoryItem"/>.
        /// </summary>
        /// <param name="inventoryItemId">The id of the inventory item to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<Entities.InventoryItem> UpdateAsync( long inventoryItemId, Entities.InventoryItem inventoryItem, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest( $"inventory_items/{inventoryItemId}.json" );
            var content = new JsonContent( new
            {
                inventory_item = inventoryItem
            } );

            var response = await ExecuteRequestAsync<Entities.InventoryItem>( req, HttpMethod.Put, cancellationToken, content, "inventory_item");
            return response.Result;
        }
    }
}
