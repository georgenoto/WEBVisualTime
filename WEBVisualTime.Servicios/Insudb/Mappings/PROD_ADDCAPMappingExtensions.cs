using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PROD_ADDCAP;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PROD_ADDCAPMappingExtensions
{
    public static PROD_ADDCAPDto ToDto(this PROD_ADDCAP entity)
    {
        if (entity == null) return null!;
        return new PROD_ADDCAPDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NCOVERGEN = entity.NCOVERGEN,
            TAB_LIFCOVSCACALFRI = entity.TAB_LIFCOV?.SCACALFRI,
            NUSERCODE = entity.NUSERCODE,
            NBRANCHADD = entity.NBRANCHADD,
            DCOMPDATE = entity.DCOMPDATE,
            NPRODUCTADD = entity.NPRODUCTADD,
            NID = entity.NID,
            DEFFECDATE = entity.DEFFECDATE,
            DNULLDATE = entity.DNULLDATE,
            NROLE = entity.NROLE,
            NCAPITAL = entity.NCAPITAL,
            NCOVERADD = entity.NCOVERADD,
            NROLEADD = entity.NROLEADD,
            NTYP_CUMUL = entity.NTYP_CUMUL,
        };
    }

    public static PROD_ADDCAP ToEntity(this CreatePROD_ADDCAPDto dto)
    {
        if (dto == null) return null!;
        return new PROD_ADDCAP
        {
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            DNULLDATE = dto.DNULLDATE,
            NROLE = dto.NROLE,
            NCAPITAL = dto.NCAPITAL,
            NCOVERADD = dto.NCOVERADD,
            NROLEADD = dto.NROLEADD,
            NTYP_CUMUL = dto.NTYP_CUMUL,
        };
    }

    public static void UpdateEntity(this PROD_ADDCAP entity, UpdatePROD_ADDCAPDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NROLE = dto.NROLE;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.NCOVERADD = dto.NCOVERADD;
        entity.NROLEADD = dto.NROLEADD;
        entity.NTYP_CUMUL = dto.NTYP_CUMUL;
    }
}
