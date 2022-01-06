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

    /// <summary>
    /// An email subscription for a Power BI item (such as a report or a
    /// dashboard)
    /// </summary>
    public partial class Subscription
    {
        /// <summary>
        /// Initializes a new instance of the Subscription class.
        /// </summary>
        public Subscription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Subscription class.
        /// </summary>
        /// <param name="id">The subscription ID</param>
        /// <param name="title">The app name</param>
        /// <param name="artifactId">The ID of the subscribed Power BI item
        /// (such as a report or a dashboard)</param>
        /// <param name="artifactDisplayName">The name of the subscribed Power
        /// BI item (such as a report or a dashboard)</param>
        /// <param name="subArtifactDisplayName">The page name of the
        /// subscribed Power BI item, if it's a report.</param>
        /// <param name="artifactType">The type of Power BI item (for example a
        /// `Report`, `Dashboard`, or `Dataset`)</param>
        /// <param name="isEnabled">subscription Enabled or not</param>
        /// <param name="frequency">Frequency of Email Subscription</param>
        /// <param name="startDate">The start date and time of
        /// subscription</param>
        /// <param name="endDate">The start date and time of
        /// subscription</param>
        /// <param name="linkToContent">subscription link exists in email
        /// subscription</param>
        /// <param name="previewImage">screenshot of the report exists in email
        /// subscription</param>
        /// <param name="attachmentFormat">Format of the report attached in the
        /// email subscription</param>
        /// <param name="users">The details of each email subscriber. When
        /// using the [Get User Subscriptions As
        /// Admin](/rest/api/power-bi/admin/users-get-user-subscriptions-as-admin)
        /// API call, the returned value is an empty array (null). This
        /// property will be removed from the payload response in an upcoming
        /// release. You can retrieve subscription information on a Power BI
        /// report or dashboard by using the [Get Report Subscriptions As
        /// Admin](/rest/api/power-bi/admin/reports-get-report-subscriptions-as-admin)
        /// or [Get Dashboard Subscriptions As
        /// Admin](/rest/api/power-bi/admin/dashboards-get-dashboard-subscriptions-as-admin)
        /// API calls.</param>
        public Subscription(System.Guid id, string title = default(string), System.Guid? artifactId = default(System.Guid?), string artifactDisplayName = default(string), string subArtifactDisplayName = default(string), string artifactType = default(string), bool? isEnabled = default(bool?), string frequency = default(string), System.DateTime? startDate = default(System.DateTime?), System.DateTime? endDate = default(System.DateTime?), bool? linkToContent = default(bool?), bool? previewImage = default(bool?), string attachmentFormat = default(string), IList<SubscriptionUser> users = default(IList<SubscriptionUser>))
        {
            Id = id;
            Title = title;
            ArtifactId = artifactId;
            ArtifactDisplayName = artifactDisplayName;
            SubArtifactDisplayName = subArtifactDisplayName;
            ArtifactType = artifactType;
            IsEnabled = isEnabled;
            Frequency = frequency;
            StartDate = startDate;
            EndDate = endDate;
            LinkToContent = linkToContent;
            PreviewImage = previewImage;
            AttachmentFormat = attachmentFormat;
            Users = users;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the subscription ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the app name
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the ID of the subscribed Power BI item (such as a
        /// report or a dashboard)
        /// </summary>
        [JsonProperty(PropertyName = "artifactId")]
        public System.Guid? ArtifactId { get; set; }

        /// <summary>
        /// Gets or sets the name of the subscribed Power BI item (such as a
        /// report or a dashboard)
        /// </summary>
        [JsonProperty(PropertyName = "artifactDisplayName")]
        public string ArtifactDisplayName { get; set; }

        /// <summary>
        /// Gets or sets the page name of the subscribed Power BI item, if it's
        /// a report.
        /// </summary>
        [JsonProperty(PropertyName = "subArtifactDisplayName")]
        public string SubArtifactDisplayName { get; set; }

        /// <summary>
        /// Gets or sets the type of Power BI item (for example a `Report`,
        /// `Dashboard`, or `Dataset`)
        /// </summary>
        [JsonProperty(PropertyName = "artifactType")]
        public string ArtifactType { get; set; }

        /// <summary>
        /// Gets or sets subscription Enabled or not
        /// </summary>
        [JsonProperty(PropertyName = "isEnabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets frequency of Email Subscription
        /// </summary>
        [JsonProperty(PropertyName = "frequency")]
        public string Frequency { get; set; }

        /// <summary>
        /// Gets or sets the start date and time of subscription
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the start date and time of subscription
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets subscription link exists in email subscription
        /// </summary>
        [JsonProperty(PropertyName = "linkToContent")]
        public bool? LinkToContent { get; set; }

        /// <summary>
        /// Gets or sets screenshot of the report exists in email subscription
        /// </summary>
        [JsonProperty(PropertyName = "previewImage")]
        public bool? PreviewImage { get; set; }

        /// <summary>
        /// Gets or sets format of the report attached in the email
        /// subscription
        /// </summary>
        [JsonProperty(PropertyName = "attachmentFormat")]
        public string AttachmentFormat { get; set; }

        /// <summary>
        /// Gets or sets the details of each email subscriber. When using the
        /// [Get User Subscriptions As
        /// Admin](/rest/api/power-bi/admin/users-get-user-subscriptions-as-admin)
        /// API call, the returned value is an empty array (null). This
        /// property will be removed from the payload response in an upcoming
        /// release. You can retrieve subscription information on a Power BI
        /// report or dashboard by using the [Get Report Subscriptions As
        /// Admin](/rest/api/power-bi/admin/reports-get-report-subscriptions-as-admin)
        /// or [Get Dashboard Subscriptions As
        /// Admin](/rest/api/power-bi/admin/dashboards-get-dashboard-subscriptions-as-admin)
        /// API calls.
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public IList<SubscriptionUser> Users { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Users != null)
            {
                foreach (var element in Users)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
