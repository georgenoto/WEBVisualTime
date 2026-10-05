using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MEDICAL_EVAL_ROL;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MEDICAL_EVAL_ROLMappingExtensions
{
    public static MEDICAL_EVAL_ROLDto ToDto(this MEDICAL_EVAL_ROL entity)
    {
        if (entity == null) return null!;
        return new MEDICAL_EVAL_ROLDto
        {
            SCERTYPE = entity.SCERTYPE,
            ROLESSCERTYPESSMOKING = entity.ROLESSCERTYPE?.SSMOKING,
            NBRANCH = entity.NBRANCH,
            ROLESNBRANCHSSMOKING = entity.ROLESNBRANCH?.SSMOKING,
            NPRODUCT = entity.NPRODUCT,
            ROLESNPRODUCTSSMOKING = entity.ROLESNPRODUCT?.SSMOKING,
            NPOLICY = entity.NPOLICY,
            ROLESNPOLICYSSMOKING = entity.ROLESNPOLICY?.SSMOKING,
            NCERTIF = entity.NCERTIF,
            ROLESNCERTIFSSMOKING = entity.ROLESNCERTIF?.SSMOKING,
            NROLE = entity.NROLE,
            ROLESNROLESSMOKING = entity.ROLESNROLE?.SSMOKING,
            SCLIENT = entity.SCLIENT,
            ROLESSCLIENTSSMOKING = entity.ROLESSCLIENT?.SSMOKING,
            NMEDICALSTAT = entity.NMEDICALSTAT,
            TABLE9216SDESCRIPT = entity.TABLE9216?.SDESCRIPT,
            NNOTENUM = entity.NNOTENUM,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            DEFFECDATE = entity.DEFFECDATE,
            ROLESDEFFECDATESSMOKING = entity.ROLESDEFFECDATE?.SSMOKING,
            NMONTHS = entity.NMONTHS,
        };
    }

    public static MEDICAL_EVAL_ROL ToEntity(this CreateMEDICAL_EVAL_ROLDto dto)
    {
        if (dto == null) return null!;
        return new MEDICAL_EVAL_ROL
        {
            NNOTENUM = dto.NNOTENUM,
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NMONTHS = dto.NMONTHS,
        };
    }

    public static void UpdateEntity(this MEDICAL_EVAL_ROL entity, UpdateMEDICAL_EVAL_ROLDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NMONTHS = dto.NMONTHS;
    }
}
