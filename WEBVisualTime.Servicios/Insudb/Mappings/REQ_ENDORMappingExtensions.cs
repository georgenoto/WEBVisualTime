using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REQ_ENDOR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class REQ_ENDORMappingExtensions
{
    public static REQ_ENDORDto ToDto(this REQ_ENDOR entity)
    {
        if (entity == null) return null!;
        return new REQ_ENDORDto
        {
            NREQENDOR = entity.NREQENDOR,
            SCERTYPE = entity.SCERTYPE,
            CERTIFICATSCERTYPESCUMUL_CODE = entity.CERTIFICATSCERTYPE?.SCUMUL_CODE,
            NBRANCH = entity.NBRANCH,
            CERTIFICATNBRANCHSCUMUL_CODE = entity.CERTIFICATNBRANCH?.SCUMUL_CODE,
            NPRODUCT = entity.NPRODUCT,
            CERTIFICATNPRODUCTSCUMUL_CODE = entity.CERTIFICATNPRODUCT?.SCUMUL_CODE,
            NPOLICY = entity.NPOLICY,
            CERTIFICATNPOLICYSCUMUL_CODE = entity.CERTIFICATNPOLICY?.SCUMUL_CODE,
            NCERTIF = entity.NCERTIF,
            CERTIFICATNCERTIFSCUMUL_CODE = entity.CERTIFICATNCERTIF?.SCUMUL_CODE,
            DREQSTARTENDOR = entity.DREQSTARTENDOR,
            NTYPEENDOR = entity.NTYPEENDOR,
            TABLE6059SDESCRIPT = entity.TABLE6059?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            USERSNUSERCODESACCESSWO = entity.USERSNUSERCODE?.SACCESSWO,
            NUNDERWRITINGCASEID = entity.NUNDERWRITINGCASEID,
            NINTERMED = entity.NINTERMED,
            NOFFICE = entity.NOFFICE,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            NAGENCY = entity.NAGENCY,
            TABLE5555SDESCRIPT = entity.TABLE5555?.SDESCRIPT,
            SCERTYPEENDOR = entity.SCERTYPEENDOR,
            NPOLICYENDOR = entity.NPOLICYENDOR,
            SOBS = entity.SOBS,
            SREASON_REJECT = entity.SREASON_REJECT,
            NUSERCODE_REJECT = entity.NUSERCODE_REJECT,
            USERSNUSERCODE_REJECTSACCESSWO = entity.USERSNUSERCODE_REJECT?.SACCESSWO,
            DREJECT = entity.DREJECT,
            NID_SECUENCIA = entity.NID_SECUENCIA,
            NUSERCODE_REQ = entity.NUSERCODE_REQ,
            USERSNUSERCODE_REQSACCESSWO = entity.USERSNUSERCODE_REQ?.SACCESSWO,
        };
    }

    public static REQ_ENDOR ToEntity(this CreateREQ_ENDORDto dto)
    {
        if (dto == null) return null!;
        return new REQ_ENDOR
        {
            SCERTYPE = dto.SCERTYPE,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NCERTIF = dto.NCERTIF,
            DREQSTARTENDOR = dto.DREQSTARTENDOR,
            NTYPEENDOR = dto.NTYPEENDOR,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NUNDERWRITINGCASEID = dto.NUNDERWRITINGCASEID,
            NINTERMED = dto.NINTERMED,
            NOFFICE = dto.NOFFICE,
            NAGENCY = dto.NAGENCY,
            SCERTYPEENDOR = dto.SCERTYPEENDOR,
            NPOLICYENDOR = dto.NPOLICYENDOR,
            SOBS = dto.SOBS,
            SREASON_REJECT = dto.SREASON_REJECT,
            NUSERCODE_REJECT = dto.NUSERCODE_REJECT,
            DREJECT = dto.DREJECT,
            NID_SECUENCIA = dto.NID_SECUENCIA,
            NUSERCODE_REQ = dto.NUSERCODE_REQ,
        };
    }

    public static void UpdateEntity(this REQ_ENDOR entity, UpdateREQ_ENDORDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NCERTIF = dto.NCERTIF;
        entity.DREQSTARTENDOR = dto.DREQSTARTENDOR;
        entity.NTYPEENDOR = dto.NTYPEENDOR;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NUNDERWRITINGCASEID = dto.NUNDERWRITINGCASEID;
        entity.NINTERMED = dto.NINTERMED;
        entity.NOFFICE = dto.NOFFICE;
        entity.NAGENCY = dto.NAGENCY;
        entity.SCERTYPEENDOR = dto.SCERTYPEENDOR;
        entity.NPOLICYENDOR = dto.NPOLICYENDOR;
        entity.SOBS = dto.SOBS;
        entity.SREASON_REJECT = dto.SREASON_REJECT;
        entity.NUSERCODE_REJECT = dto.NUSERCODE_REJECT;
        entity.DREJECT = dto.DREJECT;
        entity.NID_SECUENCIA = dto.NID_SECUENCIA;
        entity.NUSERCODE_REQ = dto.NUSERCODE_REQ;
    }
}
