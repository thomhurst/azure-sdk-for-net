// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Availability information of a product system. </summary>
    public partial class ProductAvailabilityInformation
    {
        /// <summary> Initializes a new instance of ProductAvailabilityInformation. </summary>
        internal ProductAvailabilityInformation()
        {
        }

        /// <summary> Initializes a new instance of ProductAvailabilityInformation. </summary>
        /// <param name="availabilityStage"> Current availability stage of the product. Availability stage. </param>
        /// <param name="disabledReason"> Reason why the product is disabled. </param>
        /// <param name="disabledReasonMessage"> Message for why the product is disabled. </param>
        internal ProductAvailabilityInformation(ProductAvailabilityStage? availabilityStage, ProductDisabledReason? disabledReason, string disabledReasonMessage)
        {
            AvailabilityStage = availabilityStage;
            DisabledReason = disabledReason;
            DisabledReasonMessage = disabledReasonMessage;
        }

        /// <summary> Current availability stage of the product. Availability stage. </summary>
        public ProductAvailabilityStage? AvailabilityStage { get; }
        /// <summary> Reason why the product is disabled. </summary>
        public ProductDisabledReason? DisabledReason { get; }
        /// <summary> Message for why the product is disabled. </summary>
        public string DisabledReasonMessage { get; }
    }
}
