using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GetPrimativeTypes
{
    public class ODataWanSiteInstance
    {
        [JsonProperty("odata.metadata")]
        public string Metadata { get; set; }
        public List<WanSiteInstance> Value { get; set; }
    }

    public class WanSiteInstance
    {
        public string SiteName { get; set; }
        public string SiteType { get; set; }
        public string MasterSiteCode { get; set; }
        public string TemplateId { get; set; }
        public string ProjectIdentifier { get; set; }
        public string Region { get; set; }
        public string HldRegionId { get; set; }
        public string HldRegionDescription { get; set; }
        public Address Address { get; set; }
        public UpdateDetails UpdateDetails { get; set; }
        public List<string> SpanIds { get; set; }
        public List<OwnerStatus> OwnerStatuses { get; set; }
        public string Version { get; set; }
        public string Comments { get; set; }
    }

    public class Address
    {
        public object City { get; set; }
        public object AddressLine { get; set; }
        public object Province { get; set; }
        public object Country { get; set; }
    }

    public class UpdateDetails
    {
        public DateTime ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
    }

    public class OwnerStatus
    {
        public string Owner { get; set; }
        public string Status { get; set; }
    }

    public class OrderStatusUpdateDetails
    {
        public DateTime ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
    }

}
