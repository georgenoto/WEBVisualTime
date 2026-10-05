using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERCL_HIS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MASTERCL_HISMappingExtensions
{
    public static MASTERCL_HISDto ToDto(this MASTERCL_HIS entity)
    {
        if (entity == null) return null!;
        return new MASTERCL_HISDto
        {
            NMASTERORDER = entity.NMASTERORDER,
            NMOVEMENT = entity.NMOVEMENT,
            DMOVEMENT_DATE = entity.DMOVEMENT_DATE,
            NSTATORDER_MAST = entity.NSTATORDER_MAST,
            TABLE9264SDESCRIPT = entity.TABLE9264?.SDESCRIPT,
            NATTENTCHANNEL = entity.NATTENTCHANNEL,
            TABLE9237SDESCRIPT = entity.TABLE9237?.SDESCRIPT,
            NTYPEDOC_PAY = entity.NTYPEDOC_PAY,
            TABLE9242SDESCRIPT = entity.TABLE9242?.SDESCRIPT,
            NCURREN_DOC = entity.NCURREN_DOC,
            NCURREN_ORDER = entity.NCURREN_ORDER,
            NPROVIDER = entity.NPROVIDER,
            STYPECARE = entity.STYPECARE,
            TABLE8604SDESCRIPT = entity.TABLE8604?.SDESCRIPT,
            SCARECLASS = entity.SCARECLASS,
            SIND_REV = entity.SIND_REV,
            NEXCHANGE = entity.NEXCHANGE,
            NMOVEMENT_TYPE = entity.NMOVEMENT_TYPE,
            TABLE9243SDESCRIPT = entity.TABLE9243?.SDESCRIPT,
            NTRANSAC = entity.NTRANSAC,
            SPREAUTHORIZATION = entity.SPREAUTHORIZATION,
            NCLAIMANTTYPE = entity.NCLAIMANTTYPE,
            TABLE9212SDESCRIPT = entity.TABLE9212?.SDESCRIPT,
            NCLAIM = entity.NCLAIM,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            DLEDGERDAT = entity.DLEDGERDAT,
            NMASTERORDER_NUM_ORIG = entity.NMASTERORDER_NUM_ORIG,
            NMASTERORDER_NUM_GEN = entity.NMASTERORDER_NUM_GEN,
        };
    }

    public static MASTERCL_HIS ToEntity(this CreateMASTERCL_HISDto dto)
    {
        if (dto == null) return null!;
        return new MASTERCL_HIS
        {
            DMOVEMENT_DATE = dto.DMOVEMENT_DATE,
            NSTATORDER_MAST = dto.NSTATORDER_MAST,
            NATTENTCHANNEL = dto.NATTENTCHANNEL,
            NTYPEDOC_PAY = dto.NTYPEDOC_PAY,
            NCURREN_DOC = dto.NCURREN_DOC,
            NCURREN_ORDER = dto.NCURREN_ORDER,
            NPROVIDER = dto.NPROVIDER,
            STYPECARE = dto.STYPECARE,
            SCARECLASS = dto.SCARECLASS,
            SIND_REV = dto.SIND_REV,
            NEXCHANGE = dto.NEXCHANGE,
            NMOVEMENT_TYPE = dto.NMOVEMENT_TYPE,
            NTRANSAC = dto.NTRANSAC,
            SPREAUTHORIZATION = dto.SPREAUTHORIZATION,
            NCLAIMANTTYPE = dto.NCLAIMANTTYPE,
            NCLAIM = dto.NCLAIM,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            DLEDGERDAT = dto.DLEDGERDAT,
            NMASTERORDER_NUM_ORIG = dto.NMASTERORDER_NUM_ORIG,
            NMASTERORDER_NUM_GEN = dto.NMASTERORDER_NUM_GEN,
        };
    }

    public static void UpdateEntity(this MASTERCL_HIS entity, UpdateMASTERCL_HISDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DMOVEMENT_DATE = dto.DMOVEMENT_DATE;
        entity.NSTATORDER_MAST = dto.NSTATORDER_MAST;
        entity.NATTENTCHANNEL = dto.NATTENTCHANNEL;
        entity.NTYPEDOC_PAY = dto.NTYPEDOC_PAY;
        entity.NCURREN_DOC = dto.NCURREN_DOC;
        entity.NCURREN_ORDER = dto.NCURREN_ORDER;
        entity.NPROVIDER = dto.NPROVIDER;
        entity.STYPECARE = dto.STYPECARE;
        entity.SCARECLASS = dto.SCARECLASS;
        entity.SIND_REV = dto.SIND_REV;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.NMOVEMENT_TYPE = dto.NMOVEMENT_TYPE;
        entity.NTRANSAC = dto.NTRANSAC;
        entity.SPREAUTHORIZATION = dto.SPREAUTHORIZATION;
        entity.NCLAIMANTTYPE = dto.NCLAIMANTTYPE;
        entity.NCLAIM = dto.NCLAIM;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DLEDGERDAT = dto.DLEDGERDAT;
        entity.NMASTERORDER_NUM_ORIG = dto.NMASTERORDER_NUM_ORIG;
        entity.NMASTERORDER_NUM_GEN = dto.NMASTERORDER_NUM_GEN;
    }
}
