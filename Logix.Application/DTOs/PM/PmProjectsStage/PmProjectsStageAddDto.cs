using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.PM.PmProjectsStage
{
    public class PmProjectsStageAddDto
    {
        public long Id { get; set; }
        [StringLength(250)]
        public string? Name { get; set; }
        [StringLength(250)]
        public string? Name2 { get; set; }

        public long? FacilityId { get; set; }

        public int? ParentId { get; set; }
        public int? DurationDay { get; set; }

        public int? ColorId { get; set; }
        public string? Notes { get; set; }


    }
}
