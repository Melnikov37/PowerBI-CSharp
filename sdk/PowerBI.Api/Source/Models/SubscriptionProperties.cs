// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SubscriptionProperties
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionProperties class.
        /// </summary>
        public SubscriptionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionProperties class.
        /// </summary>
        /// <param name="subscriptions">(Empty Value) The subscription details
        /// for a Power BI item (such as a report or a dashboard). This
        /// property will be removed from the payload response in an upcoming
        /// release. You can retrieve subscription information for a Power BI
        /// report by using the [Get Report Subscriptions as
        /// Admin](/rest/api/power-bi/admin/reports-get-report-subscriptions-as-admin)
        /// API call.</param>
        public SubscriptionProperties(IList<Subscription> subscriptions = default(IList<Subscription>))
        {
            Subscriptions = subscriptions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets (Empty Value) The subscription details for a Power BI
        /// item (such as a report or a dashboard). This property will be
        /// removed from the payload response in an upcoming release. You can
        /// retrieve subscription information for a Power BI report by using
        /// the [Get Report Subscriptions as
        /// Admin](/rest/api/power-bi/admin/reports-get-report-subscriptions-as-admin)
        /// API call.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptions")]
        public IList<Subscription> Subscriptions { get; set; }

    }
}
