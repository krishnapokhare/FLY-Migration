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

    public partial class SimpleSchedule
    {
        /// <summary>
        /// Initializes a new instance of the SimpleSchedule class.
        /// </summary>
        public SimpleSchedule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SimpleSchedule class.
        /// </summary>
        /// <param name="intervalType">Possible values include: 'Daily',
        /// 'Once'</param>
        /// <param name="startTime">The start time to run the migration job.
        /// Note that the start time cannot be earlier than the current time.
        /// The time follows the W3C datetime format.
        /// Example:
        /// 2018-11-01T08:15:30-05:00 corresponds to November 1,2018,8:15:30
        /// am, US Eastern Standard Time,
        /// 2018-11-01T13:15:30Z corresponds the same instant and "Z" reprents
        /// time in UTC(Coordinated Universal Time)</param>
        /// <param name="lastIncrementalMigrationStartTime">The time to run the
        /// last migration job. Note that the last incemental start time cannot
        /// be earlier than the start time.
        /// The time follows the W3C datetime format.
        /// Example:
        /// 2018-11-01T08:15:30-05:00 corresponds to November 1,2018,8:15:30
        /// am, US Eastern Standard Time,
        /// 2018-11-01T13:15:30Z corresponds the same instant and "Z" reprents
        /// time in UTC(Coordinated Universal Time)</param>
        public SimpleSchedule(string intervalType, System.DateTime startTime, System.DateTime? lastIncrementalMigrationStartTime = default(System.DateTime?))
        {
            IntervalType = intervalType;
            StartTime = startTime;
            LastIncrementalMigrationStartTime = lastIncrementalMigrationStartTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Daily', 'Once'
        /// </summary>
        [JsonProperty(PropertyName = "intervalType")]
        public string IntervalType { get; set; }

        /// <summary>
        /// Gets or sets the start time to run the migration job. Note that the
        /// start time cannot be earlier than the current time.
        /// The time follows the W3C datetime format.
        /// Example:
        /// 2018-11-01T08:15:30-05:00 corresponds to November 1,2018,8:15:30
        /// am, US Eastern Standard Time,
        /// 2018-11-01T13:15:30Z corresponds the same instant and "Z" reprents
        /// time in UTC(Coordinated Universal Time)
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time to run the last migration job. Note that the
        /// last incemental start time cannot be earlier than the start time.
        /// The time follows the W3C datetime format.
        /// Example:
        /// 2018-11-01T08:15:30-05:00 corresponds to November 1,2018,8:15:30
        /// am, US Eastern Standard Time,
        /// 2018-11-01T13:15:30Z corresponds the same instant and "Z" reprents
        /// time in UTC(Coordinated Universal Time)
        /// </summary>
        [JsonProperty(PropertyName = "lastIncrementalMigrationStartTime")]
        public System.DateTime? LastIncrementalMigrationStartTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (IntervalType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IntervalType");
            }
        }
    }
}
