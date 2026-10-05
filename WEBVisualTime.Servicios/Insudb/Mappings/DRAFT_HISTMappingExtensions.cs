using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DRAFT_HIST;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class DRAFT_HISTMappingExtensions
{
    public static DRAFT_HISTDto ToDto(this DRAFT_HIST entity)
    {
        if (entity == null) return null!;
        return new DRAFT_HISTDto
        {
            NAMOUNT = entity.NAMOUNT,
            DCOMPDATE = entity.DCOMPDATE,
            NCONTRAT = entity.NCONTRAT,
            NTRANSAC = entity.NTRANSAC,
            NCURRENCY = entity.NCURRENCY,
            NDRAFT = entity.NDRAFT,
            NDSCTO_PAG = entity.NDSCTO_PAG,
            NEXPENSIVE = entity.NEXPENSIVE,
            NINTEREST = entity.NINTEREST,
            SINTERMEI = entity.SINTERMEI,
            DSTAT_DATE = entity.DSTAT_DATE,
            NTYPE = entity.NTYPE,
            TABLE260SDESCRIPT = entity.TABLE260?.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            NBANK_CODE = entity.NBANK_CODE,
            TABLE7SDESCRIPT = entity.TABLE7?.SDESCRIPT,
            SDOCNUMBE = entity.SDOCNUMBE,
            SPAY_FORM = entity.SPAY_FORM,
            TABLE182SDESCRIPT = entity.TABLE182?.SDESCRIPT,
            SCHANGE_ACC = entity.SCHANGE_ACC,
            SAUX_ACCOUN = entity.SAUX_ACCOUN,
            NCASHNUM = entity.NCASHNUM,
            NPAYREJECT = entity.NPAYREJECT,
            NCOLLECTOR = entity.NCOLLECTOR,
            DLEDGERDAT = entity.DLEDGERDAT,
            DPOSTED = entity.DPOSTED,
            SCESSICOI = entity.SCESSICOI,
            NBILLNUM = entity.NBILLNUM,
            SIND_REVER = entity.SIND_REVER,
        };
    }

    public static DRAFT_HIST ToEntity(this CreateDRAFT_HISTDto dto)
    {
        if (dto == null) return null!;
        return new DRAFT_HIST
        {
            NAMOUNT = dto.NAMOUNT,
            DCOMPDATE = dto.DCOMPDATE,
            NCURRENCY = dto.NCURRENCY,
            NDSCTO_PAG = dto.NDSCTO_PAG,
            NEXPENSIVE = dto.NEXPENSIVE,
            NINTEREST = dto.NINTEREST,
            SINTERMEI = dto.SINTERMEI,
            DSTAT_DATE = dto.DSTAT_DATE,
            NTYPE = dto.NTYPE,
            NUSERCODE = dto.NUSERCODE,
            NBANK_CODE = dto.NBANK_CODE,
            SDOCNUMBE = dto.SDOCNUMBE,
            SPAY_FORM = dto.SPAY_FORM,
            SCHANGE_ACC = dto.SCHANGE_ACC,
            SAUX_ACCOUN = dto.SAUX_ACCOUN,
            NCASHNUM = dto.NCASHNUM,
            NPAYREJECT = dto.NPAYREJECT,
            NCOLLECTOR = dto.NCOLLECTOR,
            DLEDGERDAT = dto.DLEDGERDAT,
            DPOSTED = dto.DPOSTED,
            SCESSICOI = dto.SCESSICOI,
            NBILLNUM = dto.NBILLNUM,
            SIND_REVER = dto.SIND_REVER,
        };
    }

    public static void UpdateEntity(this DRAFT_HIST entity, UpdateDRAFT_HISTDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NDSCTO_PAG = dto.NDSCTO_PAG;
        entity.NEXPENSIVE = dto.NEXPENSIVE;
        entity.NINTEREST = dto.NINTEREST;
        entity.SINTERMEI = dto.SINTERMEI;
        entity.DSTAT_DATE = dto.DSTAT_DATE;
        entity.NTYPE = dto.NTYPE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NBANK_CODE = dto.NBANK_CODE;
        entity.SDOCNUMBE = dto.SDOCNUMBE;
        entity.SPAY_FORM = dto.SPAY_FORM;
        entity.SCHANGE_ACC = dto.SCHANGE_ACC;
        entity.SAUX_ACCOUN = dto.SAUX_ACCOUN;
        entity.NCASHNUM = dto.NCASHNUM;
        entity.NPAYREJECT = dto.NPAYREJECT;
        entity.NCOLLECTOR = dto.NCOLLECTOR;
        entity.DLEDGERDAT = dto.DLEDGERDAT;
        entity.DPOSTED = dto.DPOSTED;
        entity.SCESSICOI = dto.SCESSICOI;
        entity.NBILLNUM = dto.NBILLNUM;
        entity.SIND_REVER = dto.SIND_REVER;
    }
}
