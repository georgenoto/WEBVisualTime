using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETT_FILTERS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAIM_SETT_FILTERSMappingExtensions
{
    public static CLAIM_SETT_FILTERSDto ToDto(this CLAIM_SETT_FILTERS entity)
    {
        if (entity == null) return null!;
        return new CLAIM_SETT_FILTERSDto
        {
            NSETTLEMENT_NUM = entity.NSETTLEMENT_NUM,
            CLAIM_SETTLEMENTSCLIENT2 = entity.CLAIM_SETTLEMENT?.SCLIENT2,
            NCLAIMANTTYPE = entity.NCLAIMANTTYPE,
            NCLAIM = entity.NCLAIM,
            NCASE_NUM = entity.NCASE_NUM,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            SCLIENT = entity.SCLIENT,
            SCLIENT2 = entity.SCLIENT2,
            NORDER_NUM = entity.NORDER_NUM,
            NPROVIDER = entity.NPROVIDER,
            NTYPEPROV = entity.NTYPEPROV,
            DFROM = entity.DFROM,
            DTO = entity.DTO,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NCURRENCY = entity.NCURRENCY,
            NTYPEDOC_PAY = entity.NTYPEDOC_PAY,
            TABLE9242SDESCRIPT = entity.TABLE9242?.SDESCRIPT,
            NSETTLEMENT_CONC = entity.NSETTLEMENT_CONC,
            TABLE9249SDESCRIPT = entity.TABLE9249?.SDESCRIPT,
            NPHYSICIAN = entity.NPHYSICIAN,
            NCLINIC = entity.NCLINIC,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NBORDEREAUX_CL = entity.NBORDEREAUX_CL,
            NMASTERORDERTYPE = entity.NMASTERORDERTYPE,
            NMASTERORDER = entity.NMASTERORDER,
            DMASTERORDERFROM = entity.DMASTERORDERFROM,
            DMASTERORDERTO = entity.DMASTERORDERTO,
            SCLIENT_BENEF = entity.SCLIENT_BENEF,
            DLEDGERDAT = entity.DLEDGERDAT,
        };
    }

    public static CLAIM_SETT_FILTERS ToEntity(this CreateCLAIM_SETT_FILTERSDto dto)
    {
        if (dto == null) return null!;
        return new CLAIM_SETT_FILTERS
        {
            NCLAIMANTTYPE = dto.NCLAIMANTTYPE,
            NCLAIM = dto.NCLAIM,
            NCASE_NUM = dto.NCASE_NUM,
            NDEMAN_TYPE = dto.NDEMAN_TYPE,
            SCLIENT = dto.SCLIENT,
            SCLIENT2 = dto.SCLIENT2,
            NORDER_NUM = dto.NORDER_NUM,
            NPROVIDER = dto.NPROVIDER,
            NTYPEPROV = dto.NTYPEPROV,
            DFROM = dto.DFROM,
            DTO = dto.DTO,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NCURRENCY = dto.NCURRENCY,
            NTYPEDOC_PAY = dto.NTYPEDOC_PAY,
            NSETTLEMENT_CONC = dto.NSETTLEMENT_CONC,
            NPHYSICIAN = dto.NPHYSICIAN,
            NCLINIC = dto.NCLINIC,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NBORDEREAUX_CL = dto.NBORDEREAUX_CL,
            NMASTERORDERTYPE = dto.NMASTERORDERTYPE,
            NMASTERORDER = dto.NMASTERORDER,
            DMASTERORDERFROM = dto.DMASTERORDERFROM,
            DMASTERORDERTO = dto.DMASTERORDERTO,
            SCLIENT_BENEF = dto.SCLIENT_BENEF,
            DLEDGERDAT = dto.DLEDGERDAT,
        };
    }

    public static void UpdateEntity(this CLAIM_SETT_FILTERS entity, UpdateCLAIM_SETT_FILTERSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCLAIMANTTYPE = dto.NCLAIMANTTYPE;
        entity.NCLAIM = dto.NCLAIM;
        entity.NCASE_NUM = dto.NCASE_NUM;
        entity.NDEMAN_TYPE = dto.NDEMAN_TYPE;
        entity.SCLIENT = dto.SCLIENT;
        entity.SCLIENT2 = dto.SCLIENT2;
        entity.NORDER_NUM = dto.NORDER_NUM;
        entity.NPROVIDER = dto.NPROVIDER;
        entity.NTYPEPROV = dto.NTYPEPROV;
        entity.DFROM = dto.DFROM;
        entity.DTO = dto.DTO;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NTYPEDOC_PAY = dto.NTYPEDOC_PAY;
        entity.NSETTLEMENT_CONC = dto.NSETTLEMENT_CONC;
        entity.NPHYSICIAN = dto.NPHYSICIAN;
        entity.NCLINIC = dto.NCLINIC;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NBORDEREAUX_CL = dto.NBORDEREAUX_CL;
        entity.NMASTERORDERTYPE = dto.NMASTERORDERTYPE;
        entity.NMASTERORDER = dto.NMASTERORDER;
        entity.DMASTERORDERFROM = dto.DMASTERORDERFROM;
        entity.DMASTERORDERTO = dto.DMASTERORDERTO;
        entity.SCLIENT_BENEF = dto.SCLIENT_BENEF;
        entity.DLEDGERDAT = dto.DLEDGERDAT;
    }
}
