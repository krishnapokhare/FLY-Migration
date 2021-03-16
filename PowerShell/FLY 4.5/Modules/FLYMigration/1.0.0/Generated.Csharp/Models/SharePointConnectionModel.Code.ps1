// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AvePoint.PowerShell.FLYMigration.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SharePointConnectionModel
    {
        /// <summary>
        /// Initializes a new instance of the SharePointConnectionModel class.
        /// </summary>
        public SharePointConnectionModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SharePointConnectionModel class.
        /// </summary>
        public SharePointConnectionModel(IList<string> siteCollections, string appProfileName = default(string), string account = default(string), string password = default(string))
        {
            AppProfileName = appProfileName;
            Account = account;
            Password = password;
            SiteCollections = siteCollections;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appProfileName")]
        public string AppProfileName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "account")]
        public string Account { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "siteCollections")]
        public IList<string> SiteCollections { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SiteCollections == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SiteCollections");
            }
        }
    }
}