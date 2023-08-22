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
        public string ExtensionId { get; set; }
        public string UnitId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }


    public class ExtensionList
    {
        public int Id { get; set; }
        public string ExtensionId { get; set; }
        public string RequestType { get; set; }
        public string ParentExtensionId { get; set; }
        public DateTime Date { get; set; }
        public string DisplayDate { get; set; }
        public string StartTime { get; set; }
        public string DisplayStartTime { get; set; }
        public string EndTime { get; set; }
        public string DisplayEndTime { get; set; }
        public string ExtensionType { get; set; }
        public string DisplayExtensionType { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public bool TmApproval { get; set; }
        public bool FmApproval { get; set; }
        public bool HasEditRequest { get; set; }
        public bool HasTerminateRequest { get; set; }
        public int RequestBy { get; set; }
        public int UpdatedBy { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovedAt { get; set; }
        public string DisplayApprovedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<ExtensionUnit> ExtensionUnits { get; set; }
        public string Extension { get; set; }
        public string ActivityLogs { get; set; }
        public string DisplayCreatedAt { get; set; }
        public string DisplayUpdatedAt { get; set; }
        public string NewDescription { get; set; }
        public List<object> StandingOrderExtensions { get; set; }
    }

    public class RootObject
    {

        public int DataCount { get; set; }
        public List<ExtensionList> ExtensionList { get; set; }
        public string SelectedExtension { get; set; }
        public string ValidationError { get; set; }
        public bool IsValidated { get; set; }
        public bool IsSucceded { get; set; }
        public string ExtensionId { get; set; }
        public bool HavePendingEditRequests { get; set; }
        public bool HavePendingTerminateRequests { get; set; }
        public string ExtensionStatus { get; set; }
        public string ExtensionType { get; set; }
        public bool Authorized { get; set; }
    }
}
