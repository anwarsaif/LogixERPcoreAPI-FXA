
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Logix.Application.DTOs.Main
{
    public class SysDepartmentFilterDto
    {
        public int? TypeId { get; set; }
        public string? Name { get; set; }
        public int? StatusId { get; set; }
        public int? CatId { get; set; }
        public string? CatName { get; set; }
        public int? StructureId { get; set; }
        public string? StructureName { get; set; }
        ///////////////
        public long? Id { get; set; }
        public long? Code { get; set; }
        public long? ProjectId { get; set; }
        public long? CustomerId { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? Tel { get; set; }
        public string? EmpName { get; set; }


    }

    //public class SysDepartmentDto
    //{
    //    public long Id { get; set; }
    //    public string? Name { get; set; } = null!;
    //    public long? Code { get; set; }
    //    public long ParentId { get; set; }

    //    public string? Tel { get; set; }
    //    [StringLength(20)]
    //    public string? Fax { get; set; }
    //    [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$",
    //    ErrorMessage = "*")]

    //    public string? Email { get; set; }
    //    public string? Mobile { get; set; }
    //    public string? Note { get; set; }

    //    public int? LevelNo { get; set; }

    //    public int? TypeId { get; set; }
    //    public int? CityId { get; set; }
    //    public bool? IsDeleted { get; set; }

    //    public int? CatId { get; set; }

    //    public long? CcId { get; set; }
    //    public long? CcId2 { get; set; }
    //    public long? CcId3 { get; set; }
    //    public long? CcId4 { get; set; }
    //    public long? CcId5 { get; set; }
    //    public long? ProjectId { get; set; }

    //    public string? Name2 { get; set; }

    //    public long? DepMangerId { get; set; }
    //    public int? StatusId { get; set; }

    //    public long? FacilityId { get; set; }
    //    public bool IsShare { get; set; }
    //    public string? Address { get; set; }

    //    public string? Latitude { get; set; }

    //    public string? Longitude { get; set; }
    //    public string? ContactPerson { get; set; }
    //    public long? CustomerID { get; set; }
    //    public bool IsResidence { get; set; } = false;

    //    //addition variables using only for display (for popUps)
    //    public string? CostCenterCode { get; set; }
    //    public string? CostCenterName { get; set; }
    //    public string? EmpCode { get; set; }
    //    public string? EmpName { get; set; }
    //    public string? ProjectCode { get; set; }
    //    public string? ProjectName { get; set; }
    //    public int? BranchId { get; set; }
    //    public string? CustomerCode { get; set; }
    //    public string? CustomerName { get; set; }

    //}


    public class SysDepartmentDto
    {
        public long Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; } = null!;

        public long? Code { get; set; }

        [Column("Parent_Id")]
        public long? ParentId { get; set; }

        [StringLength(20)]
        public string? Tel { get; set; }

        [StringLength(20)]
        public string? Fax { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$",
        ErrorMessage = "*")]

        public string? Email { get; set; }

        [StringLength(50)]
        public string? Mobile { get; set; }

        [StringLength(200)]
        public string? Note { get; set; }

        [Column("Level_No")]
        public int? LevelNo { get; set; }

        [Column("Type_ID")]
        public int? TypeId { get; set; }

        [Column("City_ID")]
        public int? CityId { get; set; }

        public int? Isdel { get; set; }

        [Column("Cat_ID")]
        public int? CatId { get; set; }

        public long? CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }

        [Column("CC_ID")]
        public long? CcId { get; set; }

        [Column("Project_ID")]
        public long? ProjectId { get; set; }

        [StringLength(200)]
        public string? Name2 { get; set; }

        [Column("Dep_Manger_ID")]
        public long? DepMangerId { get; set; }

        [Column("Status_ID")]
        public int? StatusId { get; set; }

        [Column("Facility_ID")]
        public long? FacilityId { get; set; }

        public bool? IsShare { get; set; }

        public string? Address { get; set; }

        [StringLength(250)]
        public string? Latitude { get; set; }

        [StringLength(250)]
        public string? Longitude { get; set; }

        [StringLength(250)]
        public string? ContactPerson { get; set; }

        [Column("CustomerID")]
        public long? CustomerId { get; set; }

        public bool? IsResidence { get; set; }

        [Column("BRANCH_ID")]
        public int? BranchId { get; set; }

        [Column("CC_ID2")]
        public long? CcId2 { get; set; }

        [Column("CC_ID3")]
        public long? CcId3 { get; set; }

        [Column("CC_ID4")]
        public long? CcId4 { get; set; }

        [Column("CC_ID5")]
        public long? CcId5 { get; set; }

        [Column("Structure_ID")]
        public int? StructureId { get; set; }

        //addition variables using only for display (for popUps)
        public string? CostCenterCode { get; set; }
        public string? CostCenterName { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public string? ProjectCode { get; set; }
        public string? ProjectName { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
    }

    //public class SysDepartmentEditDto
    //{
    //    public long Id { get; set; }
    //    public string Name { get; set; } = null!;

    //    public string Name2 { get; set; }
    //    public long ParentId { get; set; }
    //    public string? Tel { get; set; }
    //    public string? Fax { get; set; }
    //    [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$",
    //    ErrorMessage = "Invalid email address")]
    //    public string? Email { get; set; }
    //    public string? Mobile { get; set; }
    //    public string? Note { get; set; }
    //    public int? LevelNo { get; set; }

    //    public int? TypeId { get; set; }
    //    public int? CityId { get; set; }
    //    public int? CatId { get; set; }
    //    public long? CcId { get; set; }
    //    public long? ProjectId { get; set; }
    //    public long? DepMangerId { get; set; }
    //    public int? StatusId { get; set; }
    //    public bool IsShare { get; set; }

    //    public long Code { get; set; }

    //    public string? Address { get; set; }
    //    public string? Latitude { get; set; }
    //    public string? Longitude { get; set; }

    //    public string? ContactPerson { get; set; }
    //    public bool IsResidence { get; set; }

    //    //addition variables using only for display (for popUps)
    //    public string? CostCenterCode { get; set; }
    //    public string? CostCenterName { get; set; }
    //    public string? EmpCode { get; set; }
    //    public string? EmpName { get; set; }
    //    public string? ProjectCode { get; set; }
    //    public string? ProjectName { get; set; }
    //    public int? BranchId { get; set; }
    //}


    public class SysDepartmentEditDto
    {
        public long Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; } = null!;

        public long Code { get; set; }

        [Column("Parent_Id")]
        public long ParentId { get; set; }

        [StringLength(20)]
        public string? Tel { get; set; }

        [StringLength(20)]
        public string? Fax { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$",
        ErrorMessage = "*")]

        public string? Email { get; set; }

        [StringLength(50)]
        public string? Mobile { get; set; }

        [StringLength(200)]
        public string? Note { get; set; }

        [Column("Level_No")]
        public int? LevelNo { get; set; }

        [Column("Type_ID")]
        public int? TypeId { get; set; }

        [Column("City_ID")]
        public int? CityId { get; set; }

        public int? Isdel { get; set; }

        [Column("Cat_ID")]
        public int? CatId { get; set; }

        public long? CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }

        [Column("CC_ID")]
        public long? CcId { get; set; }

        [Column("Project_ID")]
        public long? ProjectId { get; set; }

        [StringLength(200)]
        public string? Name2 { get; set; }

        [Column("Dep_Manger_ID")]
        public long? DepMangerId { get; set; }

        [Column("Status_ID")]
        public int? StatusId { get; set; }

        [Column("Facility_ID")]
        public long? FacilityId { get; set; }

        public bool? IsShare { get; set; }

        public string? Address { get; set; }

        [StringLength(250)]
        public string? Latitude { get; set; }

        [StringLength(250)]
        public string? Longitude { get; set; }

        [StringLength(250)]
        public string? ContactPerson { get; set; }

        [Column("CustomerID")]
        public long? CustomerId { get; set; }

        public bool? IsResidence { get; set; }

        [Column("BRANCH_ID")]
        public int? BranchId { get; set; }

        [Column("CC_ID2")]
        public long? CcId2 { get; set; }

        [Column("CC_ID3")]
        public long? CcId3 { get; set; }

        [Column("CC_ID4")]
        public long? CcId4 { get; set; }

        [Column("CC_ID5")]
        public long? CcId5 { get; set; }

        [Column("Structure_ID")]
        public int? StructureId { get; set; }

        //addition variables using only for display (for popUps)
        public string? CostCenterCode { get; set; }
        public string? CostCenterName { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public long? ProjectCode { get; set; }
        public string? ProjectName { get; set; }
    }

}
