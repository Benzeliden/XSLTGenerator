using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XSLTGenerator
{
    public static class ReportsDefinition
    {
        public static class CustomFunctions
        {
            public const string CommaToLineBreak = "Code.I_Logical.CommaToLineBreak";
            
            public const string SpecialToLineBreak = "Code.I_Logical.SpecialStringToLineBreak";

        }

        public static class CustomFormats
        {
            public const string Date = "MM/dd/yyyy";
            public const string Time = "hh:mm tt";
            public const string Currency = "'$'0.00;('$'0.00)";
        }

        public static List<SortingProperty> SortingForAudit = new List<SortingProperty>()
                {
                    new SortingProperty{Name = "ActionDateTime",SortDirection = SortingDirection.Desc},
                    new SortingProperty{Name = "ActionName",SortDirection = SortingDirection.Desc},
                    new SortingProperty{Name = "Actor",SortDirection = SortingDirection.Asc},
                };

        public static TransformObject GetBoxInfoDefinition()
        {
            return new TransformObject()
            {
                FileName = "BoxInfo",
                DataSetName = "BoxInfo",
                Title = "Box Information Report",
                Fields = new List<FieldDef>
                {
                    new FieldDef("UBBBoxNumber", "UBB Box Number") {Width = 0.90, FirstColumn = true},
                    new FieldDef("VendorBoxNumber", "Vendor Box Number") {Width = 0.90},
                    new FieldDef("BoxTypePublicID", "Box Type Id") {Width = 0.25},
                    new FieldDef("BoxTypeName", "Box Type") {Width = 1.80},
                    new FieldDef("BoxOwnerName", "Box Owner Name") {Width = 1.50},
                    new FieldDef("BoxRequester", "Box Requester") {Width = 1.50},
                    new FieldDef("BoxDescription", "Box Description") {Width = 2.50},
                    new FieldDef("BoxStatusDescription", "Box Status") {Width = 1.00},
                    new FieldDef("OnSiteVisitDate", "On-Site Visit Date") {Width = 0.95, Format=CustomFormats.Date},
                    new FieldDef("BoxLocationName", "Box Location") {Width = 1.15},
                    new FieldDef("StatusLocationEffectiveDate", "Status/Location Effective Date") {Width = 1.15, Format = CustomFormats.Date},
                    new FieldDef("StorageVendorName", "Storage Vendor") {Width = 1.00},
                    new FieldDef("BoxCreationDate", "Box Creation Date") {Width = 0.95, Format=CustomFormats.Date},
                    new FieldDef("AssumedDestructionDate", "Assumed Destruction Date") {Width = 0.95, Format=CustomFormats.Date},
                    new FieldDef("DepartmentStorageDueDate", "Department Storage Due Date") {Width = 0.95, Format=CustomFormats.Date},
                    new FieldDef("CheckOutDueDate", "Check-Out Due Date") {Width = 0.95, Format=CustomFormats.Date},
                    new FieldDef("DocumentsDateFrom", "Documents Date From") {Width = 0.95, Format=CustomFormats.Date},
                    new FieldDef("DocumentsDateTo", "Documents Date To") {Width = 0.95, Format=CustomFormats.Date},
                    new FieldDef("ContainsAttachments", "Contains Attachments") {Width = 1.00},
                    new FieldDef("DepartmentIDForDisplay", "Department Id") {Width = 0.25},
                    new FieldDef("DepartmentName", "Department") {Width = 1.25},
                    new FieldDef("UBBDeliveryDate", "UBB Delivery Date ") {Width = 0.95, Format=CustomFormats.Date},
                    new FieldDef("CompletedOnSiteVisit", "Completed On-Site Visit") {Width = 0.94},
                    new FieldDef("DigitalCopyLocation", "Digital Copy Location") {Width = 1.70},
                    new FieldDef("FinalDestinationName", "Final Destination") {Width = 1.15},
                    new FieldDef("IsBoxDestructionPlanned", "Is Box Destruction Planned") {Width = 0.95},
                },
                Sorting = new List<SortingProperty>
                {
                    new SortingProperty{Name = "DepartmentIDForDisplay", SortDirection = SortingDirection.Asc},
                    new SortingProperty{Name = "UBBBoxNumber", SortDirection = SortingDirection.Desc},
                    new SortingProperty{Name = "BoxCreationDate", SortDirection = SortingDirection.Desc},
                    new SortingProperty{Name = "BoxTypePublicID", SortDirection = SortingDirection.Desc},
                }
            };
        }

        public static TransformObject GetRequestInfoDefinition()
        {
            return new TransformObject()
            {
                FileName = "RequestInfo",
                DataSetName = "RequestInfo",
                Title = "Request Information Report",
                Fields = new List<FieldDef>
                {
                    new FieldDef("RequestID", "Request ID") {Width = 0.90, FirstColumn = true},
                    new FieldDef("RequestTypeName", "Request Type") {Width = 1.76},
                    new FieldDef("RequestDate", "Request Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("RequestStatusName", "Request Status") {Width = 0.82},
                    new FieldDef("Requester", "Requester") {Width = 1.50},
                    new FieldDef("CheckOutDueDate", "Check-Out Due Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("OnSiteVisitDate", "On-Site Visit Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("ExtendedDueDate", "Extended Due Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("RequestDescription", "Request Description") {Width = 2.50},
                    new FieldDef("RequestNotes", "Request Notes") {Width = 2.50},
                    new FieldDef("FinalDestinationName", "Final Destination") {Width = 1.15},
                    new FieldDef("UBBBoxNumber", "UBB Box Number") {Width = 0.90},
                    new FieldDef("VendorBoxNumber", "Vendor Box Number") {Width = 0.90},
                    new FieldDef("BoxOwnerName", "Box Owner") {Width = 1.50},
                    new FieldDef("BoxRequester", "Box Requester") {Width = 1.50},
                    new FieldDef("BoxDescription", "Box Description") {Width = 2.50},
                    new FieldDef("BoxStatusName", "Box Status") {Width = 1.00},
                    new FieldDef("BoxTypeName", "Box Type") {Width = 1.80},
                    new FieldDef("BoxLocationName", "Box Location") {Width = 1.15},
                    new FieldDef("StorageVendorName", "Storage Vendor") {Width = 1.00},
                    new FieldDef("BoxCreationDate", "Box Creation Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("AssumedDestructionDate", "Assumed Destruction Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("DepartmentStorageDueDate", "Department Storage Due Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("DocumentsDateFrom", "Documents Date From") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("DocumentsDateTo", "Documents Date To") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("UBBDeliveryDate", "UBB Delivery Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("CompletedOnSiteVisit", "Completed On-Site Visit") {Width = 0.95},
                    new FieldDef("DepartmentName", "Department") {Width = 1.25},
                },
                Sorting = new List<SortingProperty>
                {
                    new SortingProperty{Name = "RequestID", SortDirection = SortingDirection.Desc},
                    new SortingProperty{Name = "RequestDate", SortDirection = SortingDirection.Desc},
                    new SortingProperty{Name = "RequestTypeName", SortDirection = SortingDirection.Asc},
                }
            };
        }

        public static TransformObject GetDepartmentInfoDefinition()
        {
            return new TransformObject()
            {
                FileName = "DepartmentInfo",
                DataSetName = "DepartmentInfo",
                Title = "Department Information Report",
                Fields = new List<FieldDef>
                {
                    new FieldDef("DepartmentName", "Department") {Width = 1.25, FirstColumn = true},
                    new FieldDef("BoxTypeName", "Box Type") {Width = 1.80, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("DepartmentManager", "Department Manager") {Width = 1.50, CustomFunction = CustomFunctions.SpecialToLineBreak},
                    new FieldDef("UserNames", "User Name") {Width = 1.50, CustomFunction = CustomFunctions.SpecialToLineBreak},
                    new FieldDef("DepartmentAbbreviation", "Department Abbreviation") {Width = 1.90, CustomFunction = CustomFunctions.SpecialToLineBreak},
                },
                Sorting = new List<SortingProperty>
                {
                    new SortingProperty{Name = "DepartmentName", SortDirection = SortingDirection.Asc},
                }
            };
        }

        public static TransformObject GetUserInfoDefinition()
        {
            return new TransformObject()
            {
                FileName = "UserInfo",
                DataSetName = "UserInfo",
                Title = "User Information Report",
                Fields = new List<FieldDef>
                {
                    new FieldDef("UserLastName", "User Last Name") {Width = 1.40, FirstColumn = true},
                    new FieldDef("UserFirstName", "User First Name") {Width = 1.00},
                    new FieldDef("PhoneNumber", "Phone Number") {Width = 1.50},
                    new FieldDef("EmailAddress", "Email Address") {Width = 1.80},
                    new FieldDef("UserGroupName", "User Group") {Width = 2.00, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("UserRoleName", "User Role ") {Width = 1.90, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("UserPermissionsName", "User Permissions") {Width = 2.50, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("DepartmentName", "Department") {Width = 1.25},
                },
                Sorting = new List<SortingProperty>
                {
                    new SortingProperty{Name = "UserLastName",SortDirection = SortingDirection.Asc},
                    new SortingProperty{Name = "UserFirstName",SortDirection = SortingDirection.Asc},
                    new SortingProperty{Name = "DepartmentName",SortDirection = SortingDirection.Asc},
                },
            };
        }
        
        public static TransformObject GetCostInfoDefinition()
        {
            var temp = new TransformObject()
            {
                FileName = "CostInfo",
                DataSetName = "CostInfo",
                Title = "Cost Information Report",
                Fields = new List<FieldDef>
                {
                    new FieldDef("UBBBoxNumber", "UBB Box Number") {Width = 0.90, FirstColumn = true},
                    new FieldDef("VendorBoxNumber", "Vendor Box Number") {Width = 0.90},
                    new FieldDef("BoxTypeName", "Box Type") {Width = 1.80},
                    new FieldDef("BoxOwnerName", "Box Owner Name") {Width = 1.50},
                    new FieldDef("BoxRequester", "Box Requester") {Width = 1.50},
                    new FieldDef("BoxDescription", "Box Description") {Width = 2.50},
                    new FieldDef("BoxStatusName", "Box Status") {Width = 1.00},
                    new FieldDef("BoxOnSiteVisitDate", "On-Site Visit Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("BoxLocationName", "Box Location") {Width = 1.15},
                    new FieldDef("StorageVendorName", "Storage Vendor") {Width = 1.00},
                    new FieldDef("BoxCreationDate", "Box Creation Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("AssumedDestructionDate", "Assumed Destruction Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("DepartmentStorageDueDate", "Department Storage Due Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("CheckOutDueDate", "Check-Out Due Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("DocumentsDateFrom", "Documents Date From") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("DocumentsDateTo", "Documents Date To") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("ContainsAttachments", "Contains Attachments") {Width = 1.00},
                    new FieldDef("DepartmentName", "Department") {Width = 1.25},
                    new FieldDef("UBBDeliveryDate", "UBB Delivery Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("CompletedOnSiteVisit", "Completed On-Site Visit") {Width = 0.94},
                    new FieldDef("DigitalCopyLocation", "Digital Copy Location") {Width = 1.70},
                    new FieldDef("FinalDestinationName", "Final Destination") {Width = 1.15},

                    new FieldDef("BoxCreationCost", "Creation Cost") {Width = 1.10, Format = CustomFormats.Currency},
                    new FieldDef("BoxStorageBeforeDestruction", "Storage Cost before Destruction Date") {Width = 1.35, Format = CustomFormats.Currency},
                    new FieldDef("BoxStorageAfterDestruction", "Storage Cost after Destruction Date") {Width = 1.35, Format = CustomFormats.Currency},
                    new FieldDef("BoxPickUpCost", "Pick-Up Cost") {Width = 1.00, Format = CustomFormats.Currency},
                    new FieldDef("BoxCheckOutCost", "Check-Out Cost") {Width = 1.20, Format = CustomFormats.Currency},
                    new FieldDef("BoxDestructionCost", "Destruction Cost") {Width = 1.20, Format = CustomFormats.Currency},
                    new FieldDef("TotalCostVisible", "Total of Included in Report Costs") {Width = 1.35, Format = CustomFormats.Currency,IngnoreInDataSet = true, CalculatedField = "BoxCreationCost,BoxStorageBeforeDestruction,BoxPickUpCost,BoxCheckOutCost,BoxDestructionCost,BoxStorageAfterDestruction"},
                    new FieldDef("TotalCostOverall", "Total Cost Overall") {Width = 1.35, Format = CustomFormats.Currency},

                },
                Sorting = new List<SortingProperty>
                {
                    new SortingProperty{Name = "DepartmentName",SortDirection = SortingDirection.Asc},
                    new SortingProperty{Name = "BoxTypeName",SortDirection = SortingDirection.Asc},
                    new SortingProperty{Name = "UBBBoxNumber",SortDirection = SortingDirection.Asc},
                },
            };
            var field = temp.Fields.FirstOrDefault(x => x.Name == "TotalCostVisible");
            if (field != null)
            {
                var simple = "Code.I_Logical.IsHidden(Parameters!ColumnVisibilityOptions.Value, \"{0}.{1}\")";
                var medium = "IIF({0},0,Fields!{1}.Value)";
                var split = field.CalculatedField.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                var sum = new List<string>();
                foreach (var str in split)
                {
                    var res = String.Format(simple, temp.DataSetName, str);
                    sum.Add(String.Format(medium, res, str));
                }
                field.CalculatedField = String.Join(" + ", sum);

            }
            return temp;
        }
        
        public static TransformObject GetBDRSVendorExportDefinition()
        {
            return new TransformObject
            {
                FileName = "BDRSVendorExport",
                DataSetName = "BDRSVendorExport",
                Title = "BDRSVendorExport",
                Fields = new List<FieldDef>
                {
                    new FieldDef("VendorBoxNumber", "BDRS Barcode") { },
                    new FieldDef("TransmittalNumber", "Transmittal Number ") { },
                    new FieldDef("ManagementSeries", "Management Series") {},
                    new FieldDef("UBBBoxNumber", "File ID") {},
                    new FieldDef("RangeFrom", "Range From") {},
                    new FieldDef("RangeTo", "Range To") {},
                    new FieldDef("BoxDescription", "Description ") {},
                    new FieldDef("Department", "Department") {Format = "000000000000000"},
                    new FieldDef("Retrieved", "Retrieved") {},
                    new FieldDef("RetrievedDate", "Retrieved Date") {},
                    new FieldDef("NameOut", "Name Out") {},
                    new FieldDef("Location", "Location") {},
                    new FieldDef("EffectiveDate", "Effective Date") {},
                    new FieldDef("ReviewDate", "Review Date") {},
                    new FieldDef("DocumentsDateFrom", "From Date ") {Format = CustomFormats.Date},
                    new FieldDef("DocumentsDateTo", "To Date ") {Format = CustomFormats.Date},
                    new FieldDef("IndexedNotes", "Indexed Notes") {},
                }
            };
        }

        public static TransformObject GetIMVendorExportDefinition()
        {
            return new TransformObject
            {
                FileName = "IMVendorExport",
                DataSetName = "IMVendorExport",
                Title = "IMVendorExport",
                Fields = new List<FieldDef>
                {
                    new FieldDef("TypeofBox", "Type of Box") {},
                    new FieldDef("UBBBoxNumber", "UBB #")  {},
                    new FieldDef("VendorBoxNumber", "IM #")  {},
                    new FieldDef("DocumentsDateTo", "To Date")  {Format = CustomFormats.Date},
                    new FieldDef("DocumentsDateFrom", "From Date ")  {Format = CustomFormats.Date},
                    new FieldDef("DepartmentName", "Department")  {},
                }
            };
        }


        public static TransformObject GetPromtAuditReportDefinition()
        {
            return new TransformObject
            {
                FileName = "PromtInfoAudit",
                DataSetName = "PromtInfoAudit",
                Title = "Promt Information Audit Report",
                Fields = new List<FieldDef>
                {
                    new FieldDef("Prompt", "Prompt") {Width = 1.15, StartNormalHeader = true, FirstColumn = true},
                    new FieldDef("PrimaryContactTimeFrame", "Primary Contact Time Frame") {Width = 1.40},
                    new FieldDef("SecondaryContactTimeFrame", "Secondary Contact Time Frame") {Width = 1.40},
                    new FieldDef("ThirdContactTimeFrame", "Third Contact Time Frame") {Width = 1.40},
                    new FieldDef("Departments", "Department(s)") {Width = 1.25, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("PrimaryContact", "Primary Contact") {Width = 1.50},
                    new FieldDef("SecondaryContact", "Secondary Contact") {Width = 1.50},
                    new FieldDef("ThirdContact", "Third Contact") {Width = 1.50},
                    new FieldDef("ActionName", "Action") {Width = 1.00,IsAuditField = true, StartAuditHeader = true},
                    new FieldDef("OldValueName", "Old Value") {Width = 2.50,IsAuditField = true, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("NewValueName", "New Value") {Width = 2.50,IsAuditField = true, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("ActionDateTime", "Action Date/Time") {Width = 1.5,IsAuditField = true},
                    new FieldDef("Actor", "Actor") {Width = 1.50,IsAuditField = true},
                },
                Sorting = SortingForAudit
            };
        }


        public static TransformObject GetCostInfoAuditDefinition()
        {
            return new TransformObject()
            {
                FileName = "CostInfoAudit",
                DataSetName = "CostInfoAudit",
                Title = "Cost Information Audit Report",
                Fields = new List<FieldDef>()
                {
                    new FieldDef("StorageName", "Storage") {Width = 1.15, StartNormalHeader = true, FirstColumn = true},
                    new FieldDef("BoxCreationCost", "Box Creation Cost") {Width = 1.25, Format = CustomFormats.Currency},
                    new FieldDef("CostValidFrom", "Cost Valid from Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("BoxStorageCost", "Box Storage Cost") {Width = 1.25, Format = CustomFormats.Currency},
                    new FieldDef("CostToStoreTheBoxPastDestructionDate", "Cost to Store Box Past Destruction Date") {Width = 2.00, Format = CustomFormats.Currency},
                    new FieldDef("BoxPickUpTripCharge", "Box Pick-Up: Trip Charge") {Width = 1.70, Format = CustomFormats.Currency},
                    new FieldDef("BoxPickUpHandlingperBox", "Box Pick-Up: Handling per Box") {Width = 1.25, Format = CustomFormats.Currency},
                    new FieldDef("BoxPickUpOnlineWebEntry", "Box Pick-Up: Online Web Entry") {Width = 1.25, Format = CustomFormats.Currency},
                    new FieldDef("BoxPickUpFileNewCarton", "Box Pick-Up: File New Carton (shelf)") {Width = 1.35, Format = CustomFormats.Currency},
                    new FieldDef("BoxCheckOutTripCharge", "Box Check-Out: Trip Charge") {Width = 1.15, Format = CustomFormats.Currency},
                    new FieldDef("BoxCheckOutPermanentRemoval", "Box Check-Out: Permanent Removal") {Width = 1.45, Format = CustomFormats.Currency},
                    new FieldDef("BoxCheckOutHandling", "Box Check-Out: Handling per box") {Width = 1.25, Format = CustomFormats.Currency},
                    new FieldDef("BoxCheckOutBoxRetrieval", "Box Check-Out: Box Retrieval") {Width = 1.15, Format = CustomFormats.Currency},
                    new FieldDef("BoxDestructionTripCharge", "Box Destruction: Trip Charge") {Width = 1.20, Format = CustomFormats.Currency},
                    new FieldDef("BoxDestructionCostPerBox1", "Box Destruction: Destruction Cost Per Box (1-49)") {Width = 1.95, Format = CustomFormats.Currency},
                    new FieldDef("BoxDestructionCostPerBox2", "Box Destruction: Destruction Cost Per Box (50-249)") {Width = 1.95, Format = CustomFormats.Currency},
                    new FieldDef("BoxDestructionBoxRetrieval", "Box Destruction: Box Retrieval") {Width = 1.45, Format = CustomFormats.Currency},
                    new FieldDef("ActionName", "Action") {Width = 1.00,IsAuditField = true, StartAuditHeader = true},
                    new FieldDef("OldValueName", "Old Value") {Width = 2.50,IsAuditField = true, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("NewValueName", "New Value") {Width = 2.50,IsAuditField = true, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("ActionDateTime", "Action Date/Time") {Width = 1.5,IsAuditField = true},
                    new FieldDef("Actor", "Actor") {Width = 1.50,IsAuditField = true},
                },
                Sorting = SortingForAudit,
            };
        }
        public static TransformObject GetNotificationDistributionDefinition()
        {
            return new TransformObject
            {
                FileName = "NotificationDistributionInfo",
                DataSetName = "NotificationDistributionInfo",
                Title = "Notification Distribution Information Audit Report",
                Fields = new List<FieldDef>
                {
                    new FieldDef("NotificationType", "Notification Type") {Width = 1.15, StartNormalHeader = true, FirstColumn = true},
                    new FieldDef("Department", "Department") {Width = 1.25, CustomFunction =CustomFunctions.SpecialToLineBreak},
                    new FieldDef("SendtoUserswithRoles", "Send to User(s) with Role(s)") {Width = 1.90, CustomFunction =CustomFunctions.SpecialToLineBreak},
                    new FieldDef("SendtoEventOriginator", "Send to Event Originator") {Width = 1.10},
                    new FieldDef("SendtoBoxOwner", "Send to Box Owner") {Width = 0.95},
                    new FieldDef("ActionName", "Action") {Width = 1.00,IsAuditField = true, StartAuditHeader = true},
                    new FieldDef("OldValueName", "Old Value") {Width = 2.50,IsAuditField = true, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("NewValueName", "New Value") {Width = 2.50,IsAuditField = true, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("ActionDateTime", "Action Date/Time") {Width = 1.5,IsAuditField = true},
                    new FieldDef("Actor", "Actor") {Width = 1.50,IsAuditField = true},
                },
                Sorting = SortingForAudit
            };
        }
        
        public static TransformObject GetEmailInfoDefinition()
        {
            return new TransformObject
            {
                FileName = "EmailsInfo",
                DataSetName = "EmailsInfo",
                Title = "Emails Information Report",
                Fields = new List<FieldDef>
                {
                    new FieldDef("Recipients", "Recipient(s)") {Width = 0.90, StartNormalHeader = true, FirstColumn = true},
                    new FieldDef("NotificationType", "Notification Type") {Width = 1.15},
                    new FieldDef("Reminder", "Reminder") {Width = 0.90},
                    new FieldDef("ActionName", "Action") {Width = 1.00,IsAuditField = true, StartAuditHeader = true},
                    new FieldDef("OldValue", "Old Value") {Width = 2.50,IsAuditField = true},
                    new FieldDef("NewValue", "New Value") {Width = 2.50,IsAuditField = true},
                    new FieldDef("ActionDateTime", "Action Date/Time") {Width = 1.5,IsAuditField = true},
                    new FieldDef("Actor", "Actor") {Width = 1.50,IsAuditField = true},
                },
                Sorting = SortingForAudit
            };
        }

        public static TransformObject GetVendorImportInfoDefinition()
        {
            return new TransformObject
            {
                FileName = "VendorImportInfo",
                DataSetName = "VendorImportInfo",
                Title = "Vendor Import Information Report",
                Fields = new List<FieldDef>
                {
                    new FieldDef("ImportStatus", "Import Status") {Width = 1.00, StartNormalHeader = true, FirstColumn = true},
                    new FieldDef("FileName", "File Name") {Width = 1.65},
                    new FieldDef("FailedRecords", "Failed Records") {Width = 1.50},
                    new FieldDef("ActionName", "Action") {Width = 1.00,IsAuditField = true, StartAuditHeader = true},
                    new FieldDef("OldValue", "Old Value") {Width = 2.50,IsAuditField = true},
                    new FieldDef("NewValue", "New Value") {Width = 2.50,IsAuditField = true},
                    new FieldDef("ActionDateTime", "Action Date/Time") {Width = 1.5,IsAuditField = true},
                    new FieldDef("Actor", "Actor") {Width = 1.50,IsAuditField = true},
                },
                Sorting = SortingForAudit
            };
        }

        public static TransformObject GetQueriesInfoDefinition()
        {
            return new TransformObject
            {
                FileName = "QueriesInfo",
                DataSetName = "QueriesInfo",
                Title = "Queries Information Report",
                Fields = new List<FieldDef>
                {
                    new FieldDef("QueryName", "Query Name") {Width = 1.20, StartNormalHeader = true, FirstColumn = true},
                    new FieldDef("QueryType", "Query Type") {Width = 1.10},
                    new FieldDef("QueryConditions", "Query Conditions") {Width = 2.50, CustomFunction =CustomFunctions.SpecialToLineBreak},
                    new FieldDef("OutputFields", "Output Fields") {Width = 2.00, CustomFunction =CustomFunctions.SpecialToLineBreak},
                    new FieldDef("ActionName", "Action") {Width = 1.00,IsAuditField = true, StartAuditHeader = true},
                    new FieldDef("OldValueName", "Old Value") {Width = 2.50,IsAuditField = true, CustomFunction =CustomFunctions.CommaToLineBreak},
                    new FieldDef("NewValueName", "New Value") {Width = 2.50,IsAuditField = true, CustomFunction =CustomFunctions.CommaToLineBreak},
                    new FieldDef("ActionDateTime", "Action Date/Time") {Width = 1.50,IsAuditField = true},
                    new FieldDef("Actor", "Actor") {Width = 1.50,IsAuditField = true},
                },
                Sorting = SortingForAudit
            };
        }



        public static TransformObject GetBoxInfoAuditReportDefinition()
        {
            return new TransformObject()
            {
                FileName = "BoxInfoAudit",
                DataSetName = "BoxInfoAudit",
                Title = "Box Information Audit Report",
                Fields = new List<FieldDef>
                {
                    new FieldDef("UBBBoxNumber", "UBB Box Number") {Width = 0.90, StartNormalHeader = true, FirstColumn = true},
                    new FieldDef("VendorBoxNumber", "Vendor Box Number") {Width = 0.90},
                    new FieldDef("BoxTypeName", "Box Type") {Width = 1.80},
                    new FieldDef("BoxOwnerName", "Box Owner Name") {Width = 1.50},
                    new FieldDef("BoxRequester", "Box Requester") {Width = 1.50},
                    new FieldDef("BoxDescription", "Box Description") {Width = 2.50},
                    new FieldDef("BoxStatusName", "Box Status") {Width = 1.00},
                    new FieldDef("OnSiteVisitDate", "On-Site Visit Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("BoxLocationName", "Box Location") {Width = 1.15},
                    new FieldDef("StatusLocationEffectiveDate", "Status/Location Effective Date") {Width = 1.15, Format = CustomFormats.Date},
                    new FieldDef("StorageVendorName", "Storage Vendor") {Width = 1.00},
                    new FieldDef("BoxCreationDate", "Box Creation Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("AssumedDestructionDate", "Assumed Destruction Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("DepartmentStorageDueDate", "Department Storage Due Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("CheckOutDueDate", "Check-Out Due Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("DocumentsDateFrom", "Documents Date From") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("DocumentsDateTo", "Documents Date To") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("ContainsAttachments", "Contains Attachments") {Width = 1.00},
                    new FieldDef("DepartmentName", "Department") {Width = 1.25},
                    new FieldDef("UBBDeliveryDate", "UBB Delivery Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("CompletedOnSiteVisit", "Completed On-Site Visit") {Width = 0.94},
                    new FieldDef("DigitalCopyLocation", "Digital Copy Location") {Width = 1.70},
                    new FieldDef("FinalDestinationName", "Final Destination") {Width = 1.15},
                    new FieldDef("IsBoxDestructionPlanned", "Is Box Destruction Planned") {Width = 0.95},
                    new FieldDef("ActionName", "Action") {Width = 1.00,IsAuditField = true, StartAuditHeader = true},
                    new FieldDef("OldValueName", "Old Value") {Width = 2.50,IsAuditField = true, CustomFunction = CustomFunctions.SpecialToLineBreak},
                    new FieldDef("NewValueName", "New Value") {Width = 2.50,IsAuditField = true, CustomFunction = CustomFunctions.SpecialToLineBreak},
                    new FieldDef("ActionDateTime", "Action Date/Time") {Width = 1.50,IsAuditField = true},
                    new FieldDef("Actor", "Actor") {Width = 1.50,IsAuditField = true},
                },
                Sorting = SortingForAudit
            };
        }

        public static TransformObject GetRequestInfoAuditDefinition()
        {
            return new TransformObject()
            {
                FileName = "RequestInfoAudit",
                DataSetName = "RequestInfoAudit",
                Title = "Request Information Audit Report",
                Fields = new List<FieldDef>
                {
                    new FieldDef("RequestID", "Request ID") {Width = 0.90, StartNormalHeader = true, FirstColumn = true},
                    new FieldDef("RequestTypeName", "Request Type") {Width = 1.76},
                    new FieldDef("RequestDate", "Request Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("RequestStatusName", "Request Status") {Width = 0.82},
                    new FieldDef("BoxRequester", "Box Requester") {Width = 1.50},
                    new FieldDef("ExtendedDueDate", "Extended Due Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("StorageVendorName", "Storage Vendor") {Width = 1.00},
                    new FieldDef("RequestDescription", "Request Description") {Width = 2.50},
                    new FieldDef("RequestNotes", "Request Notes") {Width = 2.50},
                    new FieldDef("UBBBoxNumber", "UBB Box Number") {Width = 0.90},
                    new FieldDef("VendorBoxNumber", "Vendor Box Number") {Width = 0.90},
                    new FieldDef("BoxTypeName", "Box Type") {Width = 1.80},
                    new FieldDef("BoxOwnerName", "Box Owner Name") {Width = 1.50},
                    new FieldDef("BoxStatusName", "Box Status") {Width = 1.00},
                    new FieldDef("BoxLocationName", "Box Location") {Width = 1.15},
                    new FieldDef("BoxDescription", "Box Description") {Width = 2.50},
                    new FieldDef("OnSiteVisitDate", "On-Site Visit Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("BoxCreationDate", "Box Creation Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("AssumedDestructionDate", "Assumed Destruction Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("DepartmentStorageDueDate", "Department Storage Due Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("CheckOutDueDate", "Check-Out Due Date") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("DocumentsDateFrom", "Documents Date From") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("DocumentsDateTo", "Documents Date To") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("ContainsAttachments", "Contains Attachments") {Width = 1.00},
                    new FieldDef("DepartmentName", "Department") {Width = 1.25},
                    new FieldDef("UBBDeliveryDate", "UBB Delivery Date ") {Width = 0.95, Format = CustomFormats.Date},
                    new FieldDef("CompletedOnSiteVisit", "Completed On-Site Visit") {Width = 0.95},
                    new FieldDef("DigitalCopyLocation", "Digital Copy Location") {Width = 1.70},
                    new FieldDef("FinalDestinationName", "Final Destination") {Width = 1.15},
                    new FieldDef("IsBoxDestructionPlanned", "Is Box Destruction Planned") {Width = 0.95},


                    new FieldDef("ActionName", "Action") {Width = 1.00,IsAuditField = true, StartAuditHeader = true},
                    new FieldDef("OldValueName", "Old Value") {Width = 2.50,IsAuditField = true, CustomFunction = CustomFunctions.SpecialToLineBreak},
                    new FieldDef("NewValueName", "New Value") {Width = 2.50,IsAuditField = true, CustomFunction = CustomFunctions.SpecialToLineBreak},
                    new FieldDef("ActionDateTime", "Action Date/Time") {Width = 1.50,IsAuditField = true},
                    new FieldDef("Actor", "Actor") {Width = 1.00,IsAuditField = true},
                },
                Sorting = SortingForAudit,
            };
        }

        public static TransformObject GetBoxTypeInfoAuditDefinition()
        {
            return new TransformObject()
            {
                FileName = "BoxTypeInfoAudit",
                DataSetName = "BoxTypeInfoAudit",
                Title = "Box Type Information Audit Report",
                Fields = new List<FieldDef>
                {
                    new FieldDef("BoxTypeName", "Box Type") {Width = 1.80, StartNormalHeader = true, FirstColumn = true},
                    new FieldDef("DepartmentName", "Department") {Width = 1.25},
                    new FieldDef("DepartmentManager", "Department Manager") {Width = 1.50},
                    new FieldDef("UBBBoxNumber", "UBB Box Number") {Width = 0.90, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("BoxTypeUsage", "Box Type Usage") {Width = 0.90},
                    new FieldDef("ActionName", "Action") {Width = 1.00,IsAuditField = true, StartAuditHeader = true},
                    new FieldDef("OldValueName", "Old Value") {Width = 2.50,IsAuditField = true, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("NewValueName", "New Value") {Width = 2.50,IsAuditField = true, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("ActionDateTime", "Action Date/Time") {Width = 1.50,IsAuditField = true},
                    new FieldDef("Actor", "Actor") {Width = 1.50,IsAuditField = true},
                },
                Sorting = SortingForAudit
            };
        }

        public static TransformObject GetDepartmentInfoAuditDefinition()
        {
            return new TransformObject()
            {
                FileName = "DepartmentInfoAudit",
                DataSetName = "DepartmentInfoAudit",
                Title = "Department Information Audit Report",
                Fields = new List<FieldDef>
                {
                    new FieldDef("DepartmentName", "Department") {Width = 1.25, StartNormalHeader = true, FirstColumn = true},
                    new FieldDef("BoxTypeName", "Box Type") {Width = 1.80, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("DepartmentManager", "Department Manager") {Width = 1.50, CustomFunction = CustomFunctions.SpecialToLineBreak},
                    new FieldDef("DepartmentAbbreviation", "Department Abbreviation") {Width = 1.90, CustomFunction = CustomFunctions.SpecialToLineBreak},
                    new FieldDef("ActionName", "Action") {Width = 1.00,IsAuditField = true, StartAuditHeader = true},
                    new FieldDef("OldValueName", "Old Value") {Width = 2.50,IsAuditField = true, CustomFunction = CustomFunctions.SpecialToLineBreak},
                    new FieldDef("NewValueName", "New Value") {Width = 2.50,IsAuditField = true, CustomFunction = CustomFunctions.SpecialToLineBreak},
                    new FieldDef("ActionDateTime", "Action Date/Time") {Width = 1.5,IsAuditField = true},
                    new FieldDef("Actor", "Actor") {Width = 1.50,IsAuditField = true},
                },
                Sorting = SortingForAudit,
            };
        }
        public static TransformObject GetUserInfoAuditDefinition()
        {
            return new TransformObject()
            {
                FileName = "UserInfoAudit",
                DataSetName = "UserInfoAudit",
                Title = "User Information Audit Report",
                Fields = new List<FieldDef>
                {
                    new FieldDef("UserLastName", "User Last Name") {Width = 1.40, StartNormalHeader = true, FirstColumn = true},
                    new FieldDef("UserFirstName", "User First Name") {Width = 1.00},
                    new FieldDef("UserPhoneNumber", "Phone Number") {Width = 1.50},
                    new FieldDef("UserEmailAddress", "Email Address") {Width = 1.80},
                    new FieldDef("UserGroupName", "User Group") {Width = 2.00, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("UserRoleName", "User Role") {Width = 1.90, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("UserPermissionsName", "User Permissions") {Width = 2.50, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("DepartmentName", "Department") {Width = 1.25},
                    new FieldDef("ActionName", "Action") {Width = 1.00,IsAuditField = true, StartAuditHeader = true},
                    new FieldDef("OldValueName", "Old Value") {Width = 2.50,IsAuditField = true, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("NewValueName", "New Value") {Width = 2.50,IsAuditField = true, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("ActionDateTime", "Action Date/Time") {Width = 1.50,IsAuditField = true},
                    new FieldDef("Actor", "Actor") {Width = 1.50,IsAuditField = true},
                },
                Sorting = SortingForAudit,
            };
        }
        public static TransformObject GetVendorInfoAuditDefinition()
        {
            return new TransformObject()
            {
                FileName = "VendorInfoAudit",
                DataSetName = "VendorInfoAudit",
                Title = "Vendor Information Audit Report",
                Fields = new List<FieldDef>
                {
                    new FieldDef("StorageVendorName", "Storage Vendor") {Width = 1.00, StartNormalHeader = true, FirstColumn = true},
                    new FieldDef("ContactName", "Contact Name") {Width = 1.80},
                    new FieldDef("EmailAddress", "Email Address") {Width = 1.50},
                    new FieldDef("PhoneNumber", "Phone Number") {Width = 1.50},
                    new FieldDef("FaxNumber", "Fax Number") {Width = 1.50},
                    new FieldDef("StreetAddress", "Street Address") {Width = 1.50},
                    new FieldDef("City", "City") {Width = 1.20},
                    new FieldDef("State", "State") {Width = 0.50},
                    new FieldDef("ZipCode", "Zip Code") {Width = 0.65},
                    new FieldDef("Website", "Website") {Width = 2.40},
                    new FieldDef("ActionName", "Action") {Width = 1.00,IsAuditField = true, StartAuditHeader = true},
                    new FieldDef("OldValueName", "Old Value") {Width = 2.50,IsAuditField = true, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("NewValueName", "New Value") {Width = 2.50,IsAuditField = true, CustomFunction = CustomFunctions.CommaToLineBreak},
                    new FieldDef("ActionDateTime", "Action Date/Time") {Width = 1.50,IsAuditField = true},
                    new FieldDef("Actor", "Actor") {Width = 1.50,IsAuditField = true},
                },
                Sorting = SortingForAudit,
            };
        }

        public static TransformObject GetScheduleReportAuditDefinition()
        {
            return new TransformObject
            {
                FileName = "ReportSchedulesInfo",
                DataSetName = "ReportSchedulesInfo",
                Title = "Report Schedules Information",
                Fields = new List<FieldDef>
                {
                    new FieldDef("ReportType", "Report Type") {Width = 1.10, StartNormalHeader = true, FirstColumn = true},
                    new FieldDef("SendEmailNotificationto", "Send Email Notification to") {Width = 2.20, CustomFunction =CustomFunctions.SpecialToLineBreak},
                    new FieldDef("ReportName", "Report Name") {Width = 1.50},
                    new FieldDef("ReportFormat", "Report Format") {Width = 1.10, CustomFunction =CustomFunctions.CommaToLineBreak},
                    new FieldDef("GenerationFrequency", "Generation Frequency") {Width = 0.90},
                    new FieldDef("ScheduleEffectiveFrom", "Schedule Effective From") {Width = 0.95,Format = CustomFormats.Date},
                    new FieldDef("ScheduleEffectiveTo", "Schedule Effective To") {Width = 0.95,Format = CustomFormats.Date},
                    new FieldDef("GenerationTime", "Generation Time") {Width = 0.90,Format = CustomFormats.Time},
                    new FieldDef("ActionName", "Action") {Width = 1.00,IsAuditField = true, StartAuditHeader = true},
                    new FieldDef("OldValueName", "Old Value") {Width = 2.50,IsAuditField = true, CustomFunction =CustomFunctions.CommaToLineBreak},
                    new FieldDef("NewValueName", "New Value") {Width = 2.50,IsAuditField = true, CustomFunction =CustomFunctions.CommaToLineBreak},
                    new FieldDef("ActionDateTime", "Action Date/Time") {Width = 1.5,IsAuditField = true},
                    new FieldDef("Actor", "Actor") {Width = 1.50,IsAuditField = true},
                },
                Sorting = SortingForAudit
            };
        }

        public static TransformObject GetRoleInfoAuditDefinition()
        {
            return new TransformObject
            {
                FileName = "RoleInfoAudit",
                DataSetName = "RoleInfoAudit",
                Title = "Role Information Audit Report",
                Fields = new List<FieldDef>
                {                    
                    new FieldDef("Role", "Role") {Width = 1.90,StartNormalHeader = true, FirstColumn = true},
                    new FieldDef("UserPermissionsName", "Permissions") {Width = 2.50, CustomFunction =CustomFunctions.SpecialToLineBreak},
                    new FieldDef("ISSystemRoleEnabled", "Is System Role") {Width = 0.80},
                    new FieldDef("ActionName", "Action") {Width = 1.00,IsAuditField = true, StartAuditHeader = true},
                    new FieldDef("OldValueName", "Old Value") {Width = 2.50,IsAuditField = true, CustomFunction =CustomFunctions.CommaToLineBreak},
                    new FieldDef("NewValueName", "New Value") {Width = 2.50,IsAuditField = true, CustomFunction =CustomFunctions.CommaToLineBreak},
                    new FieldDef("ActionDateTime", "Action Date/Time") {Width = 1.5,IsAuditField = true},
                    new FieldDef("Actor", "Actor") {Width = 1.50,IsAuditField = true},
                },
                Sorting = SortingForAudit
            };
        }

        public static TransformObject GetUserGroupInfoAuditDefinition()
        {
            return new TransformObject
            {
                FileName = "UserGroupInfoAudit",
                DataSetName = "UserGroupInfoAudit",
                Title = "User Group Information Audit Report",
                Fields = new List<FieldDef>
                {                    
                    new FieldDef("UserGroupName", "User Group") {Width = 2.00,StartNormalHeader = true, FirstColumn = true},
                    new FieldDef("RoleName", "Role") {Width = 1.90, CustomFunction =CustomFunctions.SpecialToLineBreak},
                    new FieldDef("UsersName", "Users") {Width = 1.00, CustomFunction =CustomFunctions.SpecialToLineBreak},
                    new FieldDef("ActionName", "Action") {Width = 1.00,IsAuditField = true, StartAuditHeader = true},
                    new FieldDef("OldValueName", "Old Value") {Width = 2.50,IsAuditField = true, CustomFunction =CustomFunctions.CommaToLineBreak},
                    new FieldDef("NewValueName", "New Value") {Width = 2.50,IsAuditField = true, CustomFunction =CustomFunctions.CommaToLineBreak},
                    new FieldDef("ActionDateTime", "Action Date/Time") {Width = 1.5,IsAuditField = true},
                    new FieldDef("Actor", "Actor") {Width = 1.50,IsAuditField = true},
                },
                Sorting = SortingForAudit
            };
        }
    }
}
