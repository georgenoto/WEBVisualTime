using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_AM_EXC;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_AM_EXCMappingExtensions
{
    public static TAB_AM_EXCDto ToDto(this TAB_AM_EXC entity)
    {
        if (entity == null) return null!;
        return new TAB_AM_EXCDto
        {
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
            NTARIFF = entity.NTARIFF,
            SILLNESS = entity.SILLNESS,
            TAB_AM_ILLSDESCRIPT = entity.TAB_AM_ILL?.SDESCRIPT,
            DEFFECDATE = entity.DEFFECDATE,
            NID = entity.NID,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NEXC_CODE = entity.NEXC_CODE,
            TABLE271SDESCRIPT = entity.TABLE271?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            DINIT_DATE = entity.DINIT_DATE,
            DNULLDATE = entity.DNULLDATE,
            NUSERCODE = entity.NUSERCODE,
            DEND_DATE = entity.DEND_DATE,
            STYPE_EXC = entity.STYPE_EXC,
            NMODULEC = entity.NMODULEC,
            NCOVER = entity.NCOVER,
            SPREEXISTING = entity.SPREEXISTING,
            SCARENCY = entity.SCARENCY,
            SPERMANENT = entity.SPERMANENT,
            SDESCRIPT = entity.SDESCRIPT,
            NMOVEMENT = entity.NMOVEMENT,
            SSEL = entity.SSEL,
            NMOVEMENT_NULL = entity.NMOVEMENT_NULL,
        };
    }

    public static TAB_AM_EXC ToEntity(this CreateTAB_AM_EXCDto dto)
    {
        if (dto == null) return null!;
        return new TAB_AM_EXC
        {
            SCLIENT = dto.SCLIENT,
            NEXC_CODE = dto.NEXC_CODE,
            DCOMPDATE = dto.DCOMPDATE,
            DINIT_DATE = dto.DINIT_DATE,
            DNULLDATE = dto.DNULLDATE,
            NUSERCODE = dto.NUSERCODE,
            DEND_DATE = dto.DEND_DATE,
            STYPE_EXC = dto.STYPE_EXC,
            NMODULEC = dto.NMODULEC,
            NCOVER = dto.NCOVER,
            SPREEXISTING = dto.SPREEXISTING,
            SCARENCY = dto.SCARENCY,
            SPERMANENT = dto.SPERMANENT,
            SDESCRIPT = dto.SDESCRIPT,
            NMOVEMENT = dto.NMOVEMENT,
            SSEL = dto.SSEL,
            NMOVEMENT_NULL = dto.NMOVEMENT_NULL,
        };
    }

    public static void UpdateEntity(this TAB_AM_EXC entity, UpdateTAB_AM_EXCDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCLIENT = dto.SCLIENT;
        entity.NEXC_CODE = dto.NEXC_CODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DINIT_DATE = dto.DINIT_DATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DEND_DATE = dto.DEND_DATE;
        entity.STYPE_EXC = dto.STYPE_EXC;
        entity.NMODULEC = dto.NMODULEC;
        entity.NCOVER = dto.NCOVER;
        entity.SPREEXISTING = dto.SPREEXISTING;
        entity.SCARENCY = dto.SCARENCY;
        entity.SPERMANENT = dto.SPERMANENT;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NMOVEMENT = dto.NMOVEMENT;
        entity.SSEL = dto.SSEL;
        entity.NMOVEMENT_NULL = dto.NMOVEMENT_NULL;
    }
}
