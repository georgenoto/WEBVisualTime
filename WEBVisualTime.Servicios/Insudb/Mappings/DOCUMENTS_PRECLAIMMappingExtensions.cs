using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DOCUMENTS_PRECLAIM;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class DOCUMENTS_PRECLAIMMappingExtensions
{
    public static DOCUMENTS_PRECLAIMDto ToDto(this DOCUMENTS_PRECLAIM entity)
    {
        if (entity == null) return null!;
        return new DOCUMENTS_PRECLAIMDto
        {
            NIDPRECLAIM = entity.NIDPRECLAIM,
            NCONSEC = entity.NCONSEC,
            NDOC_CODE = entity.NDOC_CODE,
            NDOCNUMBE = entity.NDOCNUMBE,
            DRECEPDATE = entity.DRECEPDATE,
            DPROPO_DATE = entity.DPROPO_DATE,
            DPRESCDATE = entity.DPRESCDATE,
            NSTATUS_DOC = entity.NSTATUS_DOC,
            TABLE203SDESCRIPT = entity.TABLE203?.SDESCRIPT,
            NAMOUNT = entity.NAMOUNT,
            NCURRENCY = entity.NCURRENCY,
            NQUANTITY = entity.NQUANTITY,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            DCOMPDATE = entity.DCOMPDATE,
            NDOC_TYPE = entity.NDOC_TYPE,
            TABLE9217SDESCRIPT = entity.TABLE9217?.SDESCRIPT,
            NPROVIDER = entity.NPROVIDER,
            TAB_PROVIDERSSTATREGT = entity.TAB_PROVIDER?.SSTATREGT,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NID_SECUENCIA = entity.NID_SECUENCIA,
            NCLASS_DOC = entity.NCLASS_DOC,
            TABLE9219SDESCRIPT = entity.TABLE9219?.SDESCRIPT,
            SOBSERVATIONS = entity.SOBSERVATIONS,
        };
    }

    public static DOCUMENTS_PRECLAIM ToEntity(this CreateDOCUMENTS_PRECLAIMDto dto)
    {
        if (dto == null) return null!;
        return new DOCUMENTS_PRECLAIM
        {
            NDOC_CODE = dto.NDOC_CODE,
            NDOCNUMBE = dto.NDOCNUMBE,
            DRECEPDATE = dto.DRECEPDATE,
            DPROPO_DATE = dto.DPROPO_DATE,
            DPRESCDATE = dto.DPRESCDATE,
            NSTATUS_DOC = dto.NSTATUS_DOC,
            NAMOUNT = dto.NAMOUNT,
            NCURRENCY = dto.NCURRENCY,
            NQUANTITY = dto.NQUANTITY,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            NDOC_TYPE = dto.NDOC_TYPE,
            NPROVIDER = dto.NPROVIDER,
            SCLIENT = dto.SCLIENT,
            NID_SECUENCIA = dto.NID_SECUENCIA,
            NCLASS_DOC = dto.NCLASS_DOC,
            SOBSERVATIONS = dto.SOBSERVATIONS,
        };
    }

    public static void UpdateEntity(this DOCUMENTS_PRECLAIM entity, UpdateDOCUMENTS_PRECLAIMDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NDOC_CODE = dto.NDOC_CODE;
        entity.NDOCNUMBE = dto.NDOCNUMBE;
        entity.DRECEPDATE = dto.DRECEPDATE;
        entity.DPROPO_DATE = dto.DPROPO_DATE;
        entity.DPRESCDATE = dto.DPRESCDATE;
        entity.NSTATUS_DOC = dto.NSTATUS_DOC;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NQUANTITY = dto.NQUANTITY;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NDOC_TYPE = dto.NDOC_TYPE;
        entity.NPROVIDER = dto.NPROVIDER;
        entity.SCLIENT = dto.SCLIENT;
        entity.NID_SECUENCIA = dto.NID_SECUENCIA;
        entity.NCLASS_DOC = dto.NCLASS_DOC;
        entity.SOBSERVATIONS = dto.SOBSERVATIONS;
    }
}
