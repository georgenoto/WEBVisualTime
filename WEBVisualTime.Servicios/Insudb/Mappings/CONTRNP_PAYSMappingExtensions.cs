using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRNP_PAYS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CONTRNP_PAYSMappingExtensions
{
    public static CONTRNP_PAYSDto ToDto(this CONTRNP_PAYS entity)
    {
        if (entity == null) return null!;
        return new CONTRNP_PAYSDto
        {
            NBRANCH_REI = entity.NBRANCH_REI,
            CONTRNPRONBRANCH_REISDESCRIPT = entity.CONTRNPRONBRANCH_REI?.SDESCRIPT,
            DEFFECDATE = entity.DEFFECDATE,
            CONTRNPRODEFFECDATESDESCRIPT = entity.CONTRNPRODEFFECDATE?.SDESCRIPT,
            NNUMBER = entity.NNUMBER,
            CONTRNPRONNUMBERSDESCRIPT = entity.CONTRNPRONNUMBER?.SDESCRIPT,
            NTYPE = entity.NTYPE,
            CONTRNPRONTYPESDESCRIPT = entity.CONTRNPRONTYPE?.SDESCRIPT,
            NMONTH = entity.NMONTH,
            NYEAR = entity.NYEAR,
            NAMOUNT = entity.NAMOUNT,
            SCUENTECN = entity.SCUENTECN,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static CONTRNP_PAYS ToEntity(this CreateCONTRNP_PAYSDto dto)
    {
        if (dto == null) return null!;
        return new CONTRNP_PAYS
        {
            NAMOUNT = dto.NAMOUNT,
            SCUENTECN = dto.SCUENTECN,
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this CONTRNP_PAYS entity, UpdateCONTRNP_PAYSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.SCUENTECN = dto.SCUENTECN;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
