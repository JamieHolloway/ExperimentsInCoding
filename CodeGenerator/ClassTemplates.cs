using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CodeGenerator
{

    public class WanSiteInstanceComponentOwnerStatus
    {
        public string WanSiteInstanceName { get; set; }
        public string WanSiteTypeId { get; set; }
        public string Owner { get; set; }
        public string Status { get; set; }
        public UpdateDetails UpdateDetails { get; set; }
    }
    public class WanSiteInstanceComponentMaps
    {
        public string WanSiteInstanceName { get; set; }
        public string WanSiteTypeId { get; set; }
        public int Version { get; set; }
        public int Iteration { get; set; }
        public string WanSiteComponentName { get; set; }
        public int WanSiteComponentRevision { get; set; }
        public int WanSiteComponentOption { get; set; }
        public string RemoteWanSiteInstanceName { get; set; }
        public string RemoteWanSiteInstanceTypeId { get; set; }
        public int Count { get; set; }
        public UpdateDetails UpdateDetails { get; set; }
        public string Owner { get; set; }
        public string OrderStatus { get; set; }
        public string InternalOrder { get; set; }
        public OrderStatusUpdateDetails OrderStatusUpdateDetails { get; set; }
        public string Comments { get; set; }
        public bool IsComponentDecom { get; set; }
    }
    public class WanSiteComponentDevices
    {
        public string WanSiteComponentName { get; set; }
        public int WanSiteComponentRevision { get; set; }
        public int WanSiteComponentOption { get; set; }
        public string DeviceId { get; set; }
        public int Count { get; set; }
        public UpdateDetails UpdateDetails { get; set; }
    }
    public class WanSiteComponents
    {
        public string WanSiteComponentName { get; set; }
        public int WanSiteComponentRevision { get; set; }
        public int WanSiteComponentOption { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime ExpirationDateTime { get; set; }
        public bool IsActive { get; set; }
        public string WanSiteComponentDescription { get; set; }
        public UpdateDetails UpdateDetails { get; set; }
        public bool IsVirtual { get; set; }
    }
    public class Devices
    {
        public string MsfId { get; set; }
        public object ParentDeviceId { get; set; }
        public object MItemId { get; set; }
        public string SkuName { get; set; }
        public string Description { get; set; }
        public object DocumentLink { get; set; }
        public string State { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string RMA_SLA { get; set; }
        public UpdateDetails UpdateDetails { get; set; }
    }

    public class ODataGetWanSiteInstanceReportsData
    {
        [JsonProperty("odata.metadata")]
        public string Metadata { get; set; }

        public List<GetWanSiteInstanceReportsData> Value { get; set; }
    }

    public class SiteComponent
    {
        public string WanSiteInstanceName { get; set; }
        public string WanSiteTypeId { get; set; }
        public int Version { get; set; }
        public int Iteration { get; set; }
        public string WanSiteComponentName { get; set; }
        public int WanSiteComponentRevision { get; set; }
        public int WanSiteComponentOption { get; set; }
        public string RemoteWanSiteInstanceName { get; set; }
        public string RemoteWanSiteInstanceTypeId { get; set; }
        public int Count { get; set; }
        public UpdateDetails UpdateDetails { get; set; }
        public string Owner { get; set; }
        public string OrderStatus { get; set; }
        public string InternalOrder { get; set; }
        public OrderStatusUpdateDetails OrderStatusUpdateDetails { get; set; }
        public string Comments { get; set; }
        public bool IsComponentDecom { get; set; }
    }

    public class GetWanSiteInstanceReportsData
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