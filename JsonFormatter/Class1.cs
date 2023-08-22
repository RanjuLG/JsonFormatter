using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonFormatter
{
    public class ExtensionUnit
    {
        public int Id { get; set; }
        public string? ExtensionId { get; set; }
        public string? UnitId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }


    public class ExtensionList
    {
        public int id { get; set; }
        public string? extensionId { get; set; }
        public string? requestType { get; set; }
        public string? parentExtensionId { get; set; }
        public DateTime date { get; set; }
        public string? displayDate { get; set; }
        public string? startTime { get; set; }
        public string? displayStartTime { get; set; }
        public string? endTime { get; set; }
        public string? displayEndTime { get; set; }
        public string? extensionType { get; set; }
        public string? displayExtensionType { get; set; }
        public string? description { get; set; }
        public string? status { get; set; }
        public bool tmApproval { get; set; }
        public bool fmApproval { get; set; }
        public bool hasEditRequest { get; set; }
        public bool hasTerminateRequest { get; set; }
        public int requestBy { get; set; }
        public int updatedBy { get; set; }
        public string? approvedBy { get; set; }
        public string? approvedAt { get; set; }
        public string? displayApprovedAt { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public List<ExtensionUnit>? extensionUnits { get; set; }
        public string? extension { get; set; }
        public string? activityLogs { get; set; }
        public string? displayCreatedAt { get; set; }
        public string? displayUpdatedAt { get; set; }
        public string? newDescription { get; set; }
        public List<object>? standingOrderExtensions { get; set; }
    }

    public class RootObject
    {

        public int DataCount { get; set; }
        public List<ExtensionList>? lstExtensionList { get; set; }
        public string? selectedExtension { get; set; }
        public string? validationError { get; set; }
        public bool isValidated { get; set; }
        public bool isSucceded { get; set; }
        public string? extensionId { get; set; }
        public bool havePendingEditRequests { get; set; }
        public bool havePendingTerminateRequests { get; set; }
        public string? extensionStatus { get; set; }
        public string? extensionType { get; set; }
        public bool authorized { get; set; }
    }
}
