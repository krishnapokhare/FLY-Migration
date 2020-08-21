// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AvePoint.Migration.Api.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IMAPPOP3MailBoxObject
    {
        /// <summary>
        /// Initializes a new instance of the IMAPPOP3MailBoxObject class.
        /// </summary>
        public IMAPPOP3MailBoxObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IMAPPOP3MailBoxObject class.
        /// </summary>
        public IMAPPOP3MailBoxObject(string mailbox, string password)
        {
            Mailbox = mailbox;
            Password = password;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mailbox")]
        public string Mailbox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Mailbox == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Mailbox");
            }
            if (Password == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Password");
            }
        }
    }
}
