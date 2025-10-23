namespace Logix.Application.DTOs.RPT
{
    public class RptReportsFieldAddDto
    {


        public long Id { get; set; }


        public long? ReportId { get; set; }

        public long? FieldId { get; set; }


        public int? SortNo { get; set; }



        public int? Output { get; set; }


        public int? SortType { get; set; }


        public long? SortOrder { get; set; }

        public string? Filter { get; set; }


        public string? OtherConditions { get; set; }

        public int? GroupType { get; set; }
    }
    public class RptReportsFieldDto
    {


        public long Id { get; set; }


        public long? ReportId { get; set; }

        public long? FieldId { get; set; }


        public int? SortNo { get; set; }



        public int? Output { get; set; }


        public int? SortType { get; set; }


        public long? SortOrder { get; set; }

        public string? Filter { get; set; }


        public string? OtherConditions { get; set; }

        public int? GroupType { get; set; }
    }
}
