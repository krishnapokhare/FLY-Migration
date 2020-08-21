// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AvePoint.Migration.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ExchangeOnlineConnectionOption
    {
        /// <summary>
        /// Initializes a new instance of the ExchangeOnlineConnectionOption
        /// class.
        /// </summary>
        public ExchangeOnlineConnectionOption()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExchangeOnlineConnectionOption
        /// class.
        /// </summary>
        /// <param name="basicCredential">The Exchange Online service account
        /// must have the following roles:
        /// ApplicationImpersonation,
        /// Mail Recipients,
        /// Mail Recipient Creation,
        /// Distribution Groups,
        /// To migrate source public folders,
        /// make sure a root folder with the same name exists in the
        /// destination and the service account has the Owner permission level
        /// to the root folder.</param>
        public ExchangeOnlineConnectionOption(BasicCredential basicCredential = default(BasicCredential), string connectionId = default(string))
        {
            BasicCredential = basicCredential;
            ConnectionId = connectionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Exchange Online service account must have the
        /// following roles:
        /// ApplicationImpersonation,
        /// Mail Recipients,
        /// Mail Recipient Creation,
        /// Distribution Groups,
        /// To migrate source public folders,
        /// make sure a root folder with the same name exists in the
        /// destination and the service account has the Owner permission level
        /// to the root folder.
        /// </summary>
        [JsonProperty(PropertyName = "basicCredential")]
        public BasicCredential BasicCredential { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectionId")]
        public string ConnectionId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (BasicCredential != null)
            {
                BasicCredential.Validate();
            }
        }
    }
}
