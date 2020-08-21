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

    public partial class DropboxJobExecutionModel
    {
        /// <summary>
        /// Initializes a new instance of the DropboxJobExecutionModel class.
        /// </summary>
        public DropboxJobExecutionModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DropboxJobExecutionModel class.
        /// </summary>
        /// <param name="migrationType">Possible values include: 'Incremental',
        /// 'Full', 'FailedObjectsOnly'</param>
        /// <param name="startTime">Set the start time of the migration job.
        /// The time follows the W3C datetime format.
        /// Example:
        /// 2018-11-01T08:15:30-05:00 corresponds to November 1,2018,8:15:30
        /// am, US Eastern Standard Time,
        /// 2018-11-01T13:15:30Z corresponds the same instant and "Z" reprents
        /// time in UTC(Coordinated Universal Time)</param>
        public DropboxJobExecutionModel(string migrationType, System.DateTime? startTime = default(System.DateTime?))
        {
            MigrationType = migrationType;
            StartTime = startTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Incremental', 'Full',
        /// 'FailedObjectsOnly'
        /// </summary>
        [JsonProperty(PropertyName = "migrationType")]
        public string MigrationType { get; set; }

        /// <summary>
        /// Gets or sets set the start time of the migration job.
        /// The time follows the W3C datetime format.
        /// Example:
        /// 2018-11-01T08:15:30-05:00 corresponds to November 1,2018,8:15:30
        /// am, US Eastern Standard Time,
        /// 2018-11-01T13:15:30Z corresponds the same instant and "Z" reprents
        /// time in UTC(Coordinated Universal Time)
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MigrationType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MigrationType");
            }
        }
    }
}
