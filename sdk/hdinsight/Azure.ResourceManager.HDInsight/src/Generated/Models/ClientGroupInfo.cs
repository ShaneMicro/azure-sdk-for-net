// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The information of AAD security group. </summary>
    public partial class ClientGroupInfo
    {
        /// <summary> Initializes a new instance of ClientGroupInfo. </summary>
        public ClientGroupInfo()
        {
        }

        /// <summary> Initializes a new instance of ClientGroupInfo. </summary>
        /// <param name="groupName"> The AAD security group name. </param>
        /// <param name="groupId"> The AAD security group id. </param>
        internal ClientGroupInfo(string groupName, string groupId)
        {
            GroupName = groupName;
            GroupId = groupId;
        }

        /// <summary> The AAD security group name. </summary>
        public string GroupName { get; set; }
        /// <summary> The AAD security group id. </summary>
        public string GroupId { get; set; }
    }
}
