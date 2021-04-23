using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using com.orthofeet.Shopify.Entities;
using com.orthofeet.Shopify.Filters;

namespace com.orthofeet.Shopify.Services.RecurringCharge
{
    /// <summary>
    /// A service for manipulating Shopify's RecurringApplicationCharge API.
    /// </summary>
    public class RecurringChargeService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="RecurringChargeService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public RecurringChargeService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Creates a <see cref="RecurringCharge"/>.
        /// </summary>
        /// <param name="charge">The <see cref="RecurringCharge"/> to create.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="RecurringCharge"/>.</returns>
        public virtual async Task<Entities.RecurringCharge> CreateAsync(Entities.RecurringCharge charge, CancellationToken cancellationToken = default)
        {
            return await ExecutePostAsync<Entities.RecurringCharge>("recurring_application_charges.json", "recurring_application_charge", cancellationToken, new { recurring_application_charge = charge });
        }

        /// <summary>
        /// Retrieves the <see cref="RecurringCharge"/> with the given id.
        /// </summary>
        /// <param name="id">The id of the charge to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="RecurringCharge"/>.</returns>
        public virtual async Task<Entities.RecurringCharge> GetAsync(long id, string fields = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<Entities.RecurringCharge>($"recurring_application_charges/{id}.json", "recurring_application_charge", fields, cancellationToken);
        }

        /// <summary>
        /// Retrieves a list of all past and present <see cref="RecurringCharge"/> objects.
        /// </summary>
        public virtual async Task<IEnumerable<Entities.RecurringCharge>> ListAsync(RecurringChargeListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<IEnumerable<Entities.RecurringCharge>>("recurring_application_charges.json", "recurring_application_charges", filter, cancellationToken);
        }

        /// <summary>
        /// Activates a <see cref="RecurringCharge"/> that the shop owner has accepted.
        /// </summary>
        /// <param name="id">The id of the charge to activate.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<Entities.RecurringCharge> ActivateAsync(long id, CancellationToken cancellationToken = default)
        {
            return await ExecutePostAsync<Entities.RecurringCharge>($"recurring_application_charges/{id}/activate.json", "recurring_application_charge", cancellationToken);
        }

        /// <summary>
        /// Deletes a <see cref="RecurringCharge"/>.
        /// </summary>
        /// <param name="id">The id of the charge to delete.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            await ExecuteDeleteAsync($"recurring_application_charges/{id}.json", cancellationToken);
        }
    }
}
