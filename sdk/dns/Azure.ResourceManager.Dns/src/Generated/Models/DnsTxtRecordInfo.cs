// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Dns.Models
{
    /// <summary> A TXT record. </summary>
    public partial class DnsTxtRecordInfo
    {
        /// <summary> Initializes a new instance of DnsTxtRecordInfo. </summary>
        public DnsTxtRecordInfo()
        {
            Values = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DnsTxtRecordInfo. </summary>
        /// <param name="values"> The text value of this TXT record. </param>
        internal DnsTxtRecordInfo(IList<string> values)
        {
            Values = values;
        }

        /// <summary> The text value of this TXT record. </summary>
        public IList<string> Values { get; }
    }
}
