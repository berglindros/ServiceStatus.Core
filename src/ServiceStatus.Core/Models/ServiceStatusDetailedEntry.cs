﻿using Newtonsoft.Json;

using System.Diagnostics;

namespace ServiceStatus.Core.Models
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class ServiceStatusDetailedEntry
    {
        /// <summary>
        /// Gets or sets the name of the detailed entry
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the detail entry
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the response time (in milliseconds) that the operation took
        /// </summary>
        [JsonProperty(PropertyName = "responseTime")]
        public long ResponseTime { get; set; }

        /// <summary>
        /// Gets or sets the response time (in milliseconds) that the operation took as a string
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

        /// <summary>
        /// Gets or sets the required responsibilities of the detail entry
        /// </summary>
        [JsonProperty(PropertyName = "requiredBy", NullValueHandling = NullValueHandling.Ignore)]
        public string[] RequiredBy { get; set; }

        /// <summary>
        /// Gets or sets the optional responsibilities of the detail entry
        /// </summary>
        [JsonProperty(PropertyName = "optionalBy", NullValueHandling = NullValueHandling.Ignore)]
        public string[] OptionalBy { get; set; }

        /// <summary>
        /// Gets the string to display in the debugger
        /// </summary>
        private string DebuggerDisplay => $"Name = {Name}, Value = {Value}, Time = {ResponseTime}";

        /// <summary>
        /// Initializes a new instance of the class
        /// </summary>
        /// <param name="name">Name of entry</param>
        /// <param name="value">Value of entry</param>
        /// <param name="responseTime">Duration of the check in milliseconds</param>
        /// <param name="requiredBy">Required responsibilities</param>
        /// <param name="optionalBy">Optional responsibilities</param>
        public ServiceStatusDetailedEntry(string name, string value, long responseTime, string[] requiredBy = null, string[] optionalBy = null)
        {
            Name = name;
            Value = value;
            ResponseTime = responseTime;
            Time = responseTime.ToString();
            RequiredBy = requiredBy;
            OptionalBy = optionalBy;
        }
    }
}
