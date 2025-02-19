// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The UnknownActivity. </summary>
    internal partial class UnknownActivity : PipelineActivity
    {
        /// <summary> Initializes a new instance of UnknownActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties) : base(name, activityType, description, dependsOn, userProperties, additionalProperties)
        {
            ActivityType = activityType ?? "Unknown";
        }
    }
}
