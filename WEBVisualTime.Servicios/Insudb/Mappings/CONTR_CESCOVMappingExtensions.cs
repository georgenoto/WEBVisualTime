using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTR_CESCOV;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CONTR_CESCOVMappingExtensions
{
    public static CONTR_CESCOVDto ToDto(this CONTR_CESCOV entity)
    {
        if (entity == null) return null!;
        return new CONTR_CESCOVDto
        {
            NBRANCH_REI = entity.NBRANCH_REI,
            DEFFECDATE = entity.DEFFECDATE,
            NNUMBER = entity.NNUMBER,
            NTYPE = entity.NTYPE,
            NINSUR_AREA = entity.NINSUR_AREA,
            TABLE5001SDESCRIPT = entity.TABLE5001?.SDESCRIPT,
            NCOVERGEN = entity.NCOVERGEN,
            DNULLDATE = entity.DNULLDATE,
            NTYPECAP = entity.NTYPECAP,
            TABLE5552SDESCRIPT = entity.TABLE5552?.SDESCRIPT,
            SROUCESS = entity.SROUCESS,
            NRATE = entity.NRATE,
            NCESSPRFIX = entity.NCESSPRFIX,
            SINOTHERCOV = entity.SINOTHERCOV,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NCOMPANY = entity.NCOMPANY,
            NCOVERGEN_OTHER = entity.NCOVERGEN_OTHER,
            NSHARE_CIA = entity.NSHARE_CIA,
            NAGEMAX = entity.NAGEMAX,
            NRATE_EXPREM = entity.NRATE_EXPREM,
            SMORTACOF = entity.SMORTACOF,
            SMORTACOM = entity.SMORTACOM,
        };
    }

    public static CONTR_CESCOV ToEntity(this CreateCONTR_CESCOVDto dto)
    {
        if (dto == null) return null!;
        return new CONTR_CESCOV
        {
            DNULLDATE = dto.DNULLDATE,
            NTYPECAP = dto.NTYPECAP,
            SROUCESS = dto.SROUCESS,
            NRATE = dto.NRATE,
            NCESSPRFIX = dto.NCESSPRFIX,
            SINOTHERCOV = dto.SINOTHERCOV,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NCOVERGEN_OTHER = dto.NCOVERGEN_OTHER,
            NSHARE_CIA = dto.NSHARE_CIA,
            NAGEMAX = dto.NAGEMAX,
            NRATE_EXPREM = dto.NRATE_EXPREM,
            SMORTACOF = dto.SMORTACOF,
            SMORTACOM = dto.SMORTACOM,
        };
    }

    public static void UpdateEntity(this CONTR_CESCOV entity, UpdateCONTR_CESCOVDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NTYPECAP = dto.NTYPECAP;
        entity.SROUCESS = dto.SROUCESS;
        entity.NRATE = dto.NRATE;
        entity.NCESSPRFIX = dto.NCESSPRFIX;
        entity.SINOTHERCOV = dto.SINOTHERCOV;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NCOVERGEN_OTHER = dto.NCOVERGEN_OTHER;
        entity.NSHARE_CIA = dto.NSHARE_CIA;
        entity.NAGEMAX = dto.NAGEMAX;
        entity.NRATE_EXPREM = dto.NRATE_EXPREM;
        entity.SMORTACOF = dto.SMORTACOF;
        entity.SMORTACOM = dto.SMORTACOM;
    }
}
