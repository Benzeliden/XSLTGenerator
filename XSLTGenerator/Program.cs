using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;
using System.Linq;

namespace XSLTGenerator
{
    class Program
    {
        static void Main()
        {
            var processer = new TransformProcesser();
            var list = new List<TransformObject>()
            {
                ReportsDefinition.GetBoxInfoDefinition(),
                ReportsDefinition.GetRequestInfoDefinition(),
                ReportsDefinition.GetDepartmentInfoDefinition(),
                ReportsDefinition.GetUserInfoDefinition(),
                ReportsDefinition.GetBoxInfoAuditReportDefinition(),
                ReportsDefinition.GetRequestInfoAuditDefinition(),
                ReportsDefinition.GetBoxTypeInfoAuditDefinition(),
                ReportsDefinition.GetDepartmentInfoAuditDefinition(),
                ReportsDefinition.GetUserInfoAuditDefinition(),
                ReportsDefinition.GetVendorInfoAuditDefinition(),
                ReportsDefinition.GetCostInfoDefinition(),
                ReportsDefinition.GetCostInfoAuditDefinition(),
                ReportsDefinition.GetBDRSVendorExportDefinition(),
                ReportsDefinition.GetPromtAuditReportDefinition(),
                ReportsDefinition.GetNotificationDistributionDefinition(),
                ReportsDefinition.GetEmailInfoDefinition(),
                ReportsDefinition.GetVendorImportInfoDefinition(),
                ReportsDefinition.GetQueriesInfoDefinition(),
                ReportsDefinition.GetIMVendorExportDefinition(),
                ReportsDefinition.GetScheduleReportAuditDefinition(),
                ReportsDefinition.GetRoleInfoAuditDefinition(),
                ReportsDefinition.GetUserGroupInfoAuditDefinition(),
            };
            foreach (var obj in list)
            {
                processer.ProcessRdl(obj);
                processer.ProcessRds(obj);
            }
        }

    }

    public class TransformProcesser
    {
        private XslCompiledTransform xsltRdl;
        private XslCompiledTransform xsltRdlAudit;
        private XslCompiledTransform xsltRds;
        private XmlSerializer serializer;

        public TransformProcesser()
        {
            Init();
        }

        public void Init()
        {
            xsltRdl = new XslCompiledTransform(true);
            xsltRdl.Load("Transform1.xslt");
            xsltRdlAudit = new XslCompiledTransform(true);
            xsltRdlAudit.Load("TransformAudit.xslt");
            xsltRds = new XslCompiledTransform(true);
            xsltRds.Load("TransformDataSet.xslt");
            serializer = new XmlSerializer(typeof(TransformObject));
        }

        public void ProcessRdl(TransformObject data)
        {
            var writer = new MemoryStream();
            serializer.Serialize(writer, data);
            writer.Position = 0;
            var reader = new StreamReader(writer);
            var xmlReader = XmlReader.Create(reader);
            var outputStream = File.Create(data.FileName + ".rdl");
            var xmlWriter = XmlWriter.Create(outputStream);
            if (data.NeedAuditHeader)
            {
                xsltRdlAudit.Transform(xmlReader, xmlWriter);
            }
            else
            {
                xsltRdlAudit.Transform(xmlReader, xmlWriter);
            }
        }

        public void ProcessRds(TransformObject data)
        {
            var writer = new MemoryStream();
            serializer.Serialize(writer, data);
            writer.Position = 0;
            var reader = new StreamReader(writer);
            var xmlReader = XmlReader.Create(reader);
            var outputStream = File.Create(data.FileName + ".rsd");
            var xmlWriter = XmlWriter.Create(outputStream);
            xsltRds.Transform(xmlReader, xmlWriter);
        }
    }

    public class FieldDef
    {
        public FieldDef()
        {
            CheckVisibility = true;
            Width = 1;
            TypeName = "System.String";
        }

        public FieldDef(string name, string title)
        {
            Name = name;
            Title = title;
            CheckVisibility = true;
            Width = 1;
            TypeName = "System.String";
        }

        public string Format { get; set; }

        public string CustomFunction { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string CalculatedField { get; set; }

        public bool IngnoreInDataSet { get; set; }

        public bool IsAuditField { get; set; }

        public bool StartAuditHeader { get; set; }

        public bool StartNormalHeader { get; set; }

        public bool FirstColumn { get; set; }

        /// <summary>
        /// FullName like System.Int32. Default = System.String
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// In inches, default - 1
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Default - True
        /// </summary>
        public bool CheckVisibility { get; set; }
    }

    public class ColumnDef
    {
        public int Width { get; set; }

        public string Name { get; set; }

    }

    public class TransformObject
    {
        public string Title { get; set; }

        public string DataSetName { get; set; }

        public string FileName { get; set; }

        public List<FieldDef> Fields { get; set; }

        public List<SortingProperty> Sorting { get; set; }


        public decimal TotalWidth
        {
            get
            {
                return new decimal(Fields.Sum(x => x.Width));
            }
            set
            {

            }
        }

        public bool NeedAuditHeader
        {
            get
            {
                return Fields.Any(x => x.StartAuditHeader);
            }
            set
            {

            }
        }

        public int AuditCount
        {
            get
            {
                return Fields.Count(x => x.IsAuditField);
            }
            set
            {

            }
        }

        public int NonAuditCount
        {
            get
            {
                return Fields.Count(x => !x.IsAuditField);
            }
            set
            {

            }
        }

        public Guid Guid { get; set; }

        public TransformObject()
        {
            Guid = Guid.NewGuid();
            Sorting = new List<SortingProperty>();
        }
    }

    public class SortingProperty
    {
        public SortingProperty()
        {
            SortDirection = SortingDirection.Asc;
        }

        public string Name { get; set; }

        public SortingDirection SortDirection { get; set; }

    }

    public enum SortingDirection
    {
        Asc,
        Desc
    }
}
