using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLORDER_HIS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLORDER_HISMappingExtensions
{
    public static CLORDER_HISDto ToDto(this CLORDER_HIS entity)
    {
        if (entity == null) return null!;
        return new CLORDER_HISDto
        {
            NCLAIM = entity.NCLAIM,
            CLAIM_ORDERNCLAIMSTYPECARE = entity.CLAIM_ORDERNCLAIM?.STYPECARE,
            NCASE_NUM = entity.NCASE_NUM,
            CLAIM_ORDERNCASE_NUMSTYPECARE = entity.CLAIM_ORDERNCASE_NUM?.STYPECARE,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            TABLE692SDESCRIPT = entity.TABLE692?.SDESCRIPT,
            NORDER_NUM = entity.NORDER_NUM,
            CLAIM_ORDERNORDER_NUMSTYPECARE = entity.CLAIM_ORDERNORDER_NUM?.STYPECARE,
            NMOVEMENT = entity.NMOVEMENT,
            DMOVEMENT_DATE = entity.DMOVEMENT_DATE,
            NSTATUS_ORDER = entity.NSTATUS_ORDER,
            TABLE9241SDESCRIPT = entity.TABLE9241?.SDESCRIPT,
            NATTENTCHANNEL = entity.NATTENTCHANNEL,
            TABLE9237SDESCRIPT = entity.TABLE9237?.SDESCRIPT,
            NTYPEDOC_PAY = entity.NTYPEDOC_PAY,
            TABLE9242SDESCRIPT = entity.TABLE9242?.SDESCRIPT,
            NCURREN_DOC = entity.NCURREN_DOC,
            TABLE11NCURREN_DOCSDESCRIPT = entity.TABLE11NCURREN_DOC?.SDESCRIPT,
            NCURREN_ORDER = entity.NCURREN_ORDER,
            TABLE11NCURREN_ORDERSDESCRIPT = entity.TABLE11NCURREN_ORDER?.SDESCRIPT,
            NPROVIDER = entity.NPROVIDER,
            STYPECARE = entity.STYPECARE,
            TABLE8604SDESCRIPT = entity.TABLE8604?.SDESCRIPT,
            SIND_REV = entity.SIND_REV,
            NEXCHANGE = entity.NEXCHANGE,
            DPOSTED = entity.DPOSTED,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NMOVEMENT_TYPE = entity.NMOVEMENT_TYPE,
            SCARECLASS = entity.SCARECLASS,
            NTRANSAC = entity.NTRANSAC,
            SPREAUTHORIZATION = entity.SPREAUTHORIZATION,
            SPROLTREATMENT = entity.SPROLTREATMENT,
            NPHYSICIAN = entity.NPHYSICIAN,
            NMEDICALINSTITUTE = entity.NMEDICALINSTITUTE,
            NCLAIMANTTYPE = entity.NCLAIMANTTYPE,
            DLEDGERDAT = entity.DLEDGERDAT,
            NORDER_NUM_ORIG = entity.NORDER_NUM_ORIG,
            NORDER_NUM_GEN = entity.NORDER_NUM_GEN,
        };
    }

    public static CLORDER_HIS ToEntity(this CreateCLORDER_HISDto dto)
    {
        if (dto == null) return null!;
        return new CLORDER_HIS
        {
            DMOVEMENT_DATE = dto.DMOVEMENT_DATE,
            NSTATUS_ORDER = dto.NSTATUS_ORDER,
            NATTENTCHANNEL = dto.NATTENTCHANNEL,
            NTYPEDOC_PAY = dto.NTYPEDOC_PAY,
            NCURREN_DOC = dto.NCURREN_DOC,
            NCURREN_ORDER = dto.NCURREN_ORDER,
            NPROVIDER = dto.NPROVIDER,
            STYPECARE = dto.STYPECARE,
            SIND_REV = dto.SIND_REV,
            NEXCHANGE = dto.NEXCHANGE,
            DPOSTED = dto.DPOSTED,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NMOVEMENT_TYPE = dto.NMOVEMENT_TYPE,
            SCARECLASS = dto.SCARECLASS,
            SPREAUTHORIZATION = dto.SPREAUTHORIZATION,
            SPROLTREATMENT = dto.SPROLTREATMENT,
            NPHYSICIAN = dto.NPHYSICIAN,
            NMEDICALINSTITUTE = dto.NMEDICALINSTITUTE,
            NCLAIMANTTYPE = dto.NCLAIMANTTYPE,
            DLEDGERDAT = dto.DLEDGERDAT,
            NORDER_NUM_ORIG = dto.NORDER_NUM_ORIG,
            NORDER_NUM_GEN = dto.NORDER_NUM_GEN,
        };
    }

    public static void UpdateEntity(this CLORDER_HIS entity, UpdateCLORDER_HISDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DMOVEMENT_DATE = dto.DMOVEMENT_DATE;
        entity.NSTATUS_ORDER = dto.NSTATUS_ORDER;
        entity.NATTENTCHANNEL = dto.NATTENTCHANNEL;
        entity.NTYPEDOC_PAY = dto.NTYPEDOC_PAY;
        entity.NCURREN_DOC = dto.NCURREN_DOC;
        entity.NCURREN_ORDER = dto.NCURREN_ORDER;
        entity.NPROVIDER = dto.NPROVIDER;
        entity.STYPECARE = dto.STYPECARE;
        entity.SIND_REV = dto.SIND_REV;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.DPOSTED = dto.DPOSTED;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NMOVEMENT_TYPE = dto.NMOVEMENT_TYPE;
        entity.SCARECLASS = dto.SCARECLASS;
        entity.SPREAUTHORIZATION = dto.SPREAUTHORIZATION;
        entity.SPROLTREATMENT = dto.SPROLTREATMENT;
        entity.NPHYSICIAN = dto.NPHYSICIAN;
        entity.NMEDICALINSTITUTE = dto.NMEDICALINSTITUTE;
        entity.NCLAIMANTTYPE = dto.NCLAIMANTTYPE;
        entity.DLEDGERDAT = dto.DLEDGERDAT;
        entity.NORDER_NUM_ORIG = dto.NORDER_NUM_ORIG;
        entity.NORDER_NUM_GEN = dto.NORDER_NUM_GEN;
    }
}
