using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using com.orthofeet.Shopify.Extensions;
using com.orthofeet.Shopify.Filters;
using com.orthofeet.Shopify.Infrastructure;
using com.orthofeet.Shopify.Lists;
using InventoryLevelAdjust = com.orthofeet.Shopify.Entities.InventoryLevelAdjust;

namespace com.orthofeet.Shopify.Services.InventoryLevel
{
    /// <summary>
    /// A service for manipulating a Shopify inventory items.
    /// </summary>
    public class InventoryLevelService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="InventoryLevelService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public InventoryLevelService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of inventory items. 
        /// </summary>
        public virtual async Task<ListResult<Entities.InventoryLevel>> ListAsync(ListFilter<Entities.InventoryLevel> filter, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync($"inventory_levels.json", "inventory_levels", filter, cancellationToken);
        }
        
        /// <summary>
        /// Gets a list of inventory items
        /// </summary>
        public virtual async Task<ListResult<Entities.InventoryLevel>> ListAsync(InventoryLevelListFilter filter, CancellationToken cancellationToken = default)
        {
            return await ListAsync(filter?.AsListFilter(), cancellationToken);
        }

        /// <summary>
        /// Deletes inventory for an item at specified location.  All items must keep inventory at at least one location.
        /// </summary>
        /// <param name="inventoryItemId">The ID of the inventory item.</param>
        /// <param name="locationId">The ID of the location that the inventory level belongs to.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task DeleteAsync(long inventoryItemId, long locationId, CancellationToken cancellationToken = default)
        {
            await ExecuteRequestAsync(PrepareRequest($"inventory_levels.json?inventory_item_id={inventoryItemId}&location_id={locationId}"), HttpMethod.Delete, cancellationToken);
        }

        /// <summary>
        /// Updates the given <see cref="Entities.InventoryLevel"/>.
        /// </summary>
        /// <param name="updatedInventoryLevel">The updated <see cref="Entities.InventoryLevel"/></param>
        /// <param name="disconnectIfNecessary">Whether inventory for any previously connected locations will be set to 0 and the locations disconnected. This property is ignored when no fulfillment service is involved.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="Entities.InventoryLevel"/></returns>
        public virtual async Task<Entities.InventoryLevel> SetAsync(Entities.InventoryLevel updatedInventoryLevel, bool disconnectIfNecessary = false, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"inventory_levels/set.json");
            var body = updatedInventoryLevel.ToDictionary();
            
            body.Add("disconnect_if_necessary", disconnectIfNecessary);
            
            var content = new JsonContent(body);
            var response = await ExecuteRequestAsync<Entities.InventoryLevel>(req, HttpMethod.Post, cancellationToken, content, "inventory_level");
            
            return response.Result;
        }

        /// <summary>
        /// Adjusts the given <see cref="InventoryLevel"/>.
        /// </summary>
        /// <param name="updatedInventoryLevel">The updated <see cref="InventoryLevel"/></param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="InventoryLevel"/></returns>
        public virtual async Task<Entities.InventoryLevel> AdjustAsync(InventoryLevelAdjust adjustInventoryLevel, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"inventory_levels/adjust.json");
            var body = adjustInventoryLevel.ToDictionary();
            var content = new JsonContent(body);
            var response = await ExecuteRequestAsync<Entities.InventoryLevel>(req, HttpMethod.Post, cancellationToken, content, "inventory_level");
            
            return response.Result;
        }

        /// <summary>
        /// Connect an inventory item to a location
        /// </summary>
        /// <param name="inventoryItemId">The ID of the inventory item</param>
        /// <param name="locationId">The ID of the location that the inventory level belongs to</param>
        /// <param name="relocateIfNecessary">Whether inventory for any previously connected locations will be relocated. This property is ignored when no fulfillment service location is involved</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="Entities.InventoryLevel"/>.</returns>
        public virtual async Task<Entities.InventoryLevel> ConnectAsync(long inventoryItemId, long locationId, bool relocateIfNecessary = false, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"inventory_levels/connect.json");
            var content = new JsonContent(new
            {
                location_id = locationId,
                inventory_item_id = inventoryItemId,
                relocate_if_necessary = relocateIfNecessary
            });
            var response = await ExecuteRequestAsync<Entities.InventoryLevel>(req, HttpMethod.Post, cancellationToken, content, "inventory_level");
            
            return response.Result;
        }
    }
}
