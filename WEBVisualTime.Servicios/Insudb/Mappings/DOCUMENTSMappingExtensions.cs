using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DOCUMENTS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class DOCUMENTSMappingExtensions
{
    public static DOCUMENTSDto ToDto(this DOCUMENTS entity)
    {
        if (entity == null) return null!;
        return new DOCUMENTSDto
        {
            NCLAIM = entity.NCLAIM,
            CLAIMBENEFNCLAIMSDEMANDANT = entity.CLAIMBENEFNCLAIM?.SDEMANDANT,
            NDOC_CODE = entity.NDOC_CODE,
            NCASE_NUM = entity.NCASE_NUM,
            CLAIMBENEFNCASE_NUMSDEMANDANT = entity.CLAIMBENEFNCASE_NUM?.SDEMANDANT,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            TABLE692SDESCRIPT = entity.TABLE692?.SDESCRIPT,
            SCLIENT = entity.SCLIENT,
            CLAIMBENEFSCLIENTSDEMANDANT = entity.CLAIMBENEFSCLIENT?.SDEMANDANT,
            NID = entity.NID,
            CLAIMBENEFNIDSDEMANDANT = entity.CLAIMBENEFNID?.SDEMANDANT,
            DCOMPDATE = entity.DCOMPDATE,
            DEFFECDATE = entity.DEFFECDATE,
            DLETFIRSDAT = entity.DLETFIRSDAT,
            DLETLASTDAT = entity.DLETLASTDAT,
            DRECEPDATE = entity.DRECEPDATE,
            NSTATUS_DOC = entity.NSTATUS_DOC,
            TABLE203SDESCRIPT = entity.TABLE203?.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            NDOCNUMBE = entity.NDOCNUMBE,
            NQUANTITY = entity.NQUANTITY,
            DPROPO_DATE = entity.DPROPO_DATE,
            DPRESCDATE = entity.DPRESCDATE,
            NCONSEC = entity.NCONSEC,
            SDESCRIPT = entity.SDESCRIPT,
            NAMOUNT = entity.NAMOUNT,
            NCURRENCY = entity.NCURRENCY,
            NDOC_TYPE = entity.NDOC_TYPE,
            TABLE9217SDESCRIPT = entity.TABLE9217?.SDESCRIPT,
            NPROVIDER = entity.NPROVIDER,
            TAB_PROVIDERSSTATREGT = entity.TAB_PROVIDER?.SSTATREGT,
            NID_SECUENCIA = entity.NID_SECUENCIA,
            NCLASS_DOC = entity.NCLASS_DOC,
            SOBSERVATIONS = entity.SOBSERVATIONS,
        };
    }

    public static DOCUMENTS ToEntity(this CreateDOCUMENTSDto dto)
    {
        if (dto == null) return null!;
        return new DOCUMENTS
        {
            DCOMPDATE = dto.DCOMPDATE,
            DEFFECDATE = dto.DEFFECDATE,
            DLETFIRSDAT = dto.DLETFIRSDAT,
            DLETLASTDAT = dto.DLETLASTDAT,
            DRECEPDATE = dto.DRECEPDATE,
            NSTATUS_DOC = dto.NSTATUS_DOC,
            NUSERCODE = dto.NUSERCODE,
            NDOCNUMBE = dto.NDOCNUMBE,
            NQUANTITY = dto.NQUANTITY,
            DPROPO_DATE = dto.DPROPO_DATE,
            DPRESCDATE = dto.DPRESCDATE,
            SDESCRIPT = dto.SDESCRIPT,
            NAMOUNT = dto.NAMOUNT,
            NCURRENCY = dto.NCURRENCY,
            NDOC_TYPE = dto.NDOC_TYPE,
            NPROVIDER = dto.NPROVIDER,
            NID_SECUENCIA = dto.NID_SECUENCIA,
            NCLASS_DOC = dto.NCLASS_DOC,
            SOBSERVATIONS = dto.SOBSERVATIONS,
        };
    }

    public static void UpdateEntity(this DOCUMENTS entity, UpdateDOCUMENTSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.DLETFIRSDAT = dto.DLETFIRSDAT;
        entity.DLETLASTDAT = dto.DLETLASTDAT;
        entity.DRECEPDATE = dto.DRECEPDATE;
        entity.NSTATUS_DOC = dto.NSTATUS_DOC;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NDOCNUMBE = dto.NDOCNUMBE;
        entity.NQUANTITY = dto.NQUANTITY;
        entity.DPROPO_DATE = dto.DPROPO_DATE;
        entity.DPRESCDATE = dto.DPRESCDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NDOC_TYPE = dto.NDOC_TYPE;
        entity.NPROVIDER = dto.NPROVIDER;
        entity.NID_SECUENCIA = dto.NID_SECUENCIA;
        entity.NCLASS_DOC = dto.NCLASS_DOC;
        entity.SOBSERVATIONS = dto.SOBSERVATIONS;
    }
}
