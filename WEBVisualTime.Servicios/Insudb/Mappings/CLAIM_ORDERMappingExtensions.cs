using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_ORDER;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAIM_ORDERMappingExtensions
{
    public static CLAIM_ORDERDto ToDto(this CLAIM_ORDER entity)
    {
        if (entity == null) return null!;
        return new CLAIM_ORDERDto
        {
            NCLAIM = entity.NCLAIM,
            CLAIMSCERTYPE = entity.CLAIM?.SCERTYPE,
            NCASE_NUM = entity.NCASE_NUM,
            CLAIM_CASESSTACASE = entity.CLAIM_CASE?.SSTACASE,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            TABLE692SDESCRIPT = entity.TABLE692?.SDESCRIPT,
            NORDER_NUM = entity.NORDER_NUM,
            NCLAIMANTTYPE = entity.NCLAIMANTTYPE,
            TABLE9212SDESCRIPT = entity.TABLE9212?.SDESCRIPT,
            NATTENTCHANNEL = entity.NATTENTCHANNEL,
            TABLE9237SDESCRIPT = entity.TABLE9237?.SDESCRIPT,
            DORDERDATE = entity.DORDERDATE,
            NTYPEDOC_PAY = entity.NTYPEDOC_PAY,
            TABLE9242SDESCRIPT = entity.TABLE9242?.SDESCRIPT,
            DACCOUNTDOC = entity.DACCOUNTDOC,
            NCURREN_DOC = entity.NCURREN_DOC,
            TABLE11NCURREN_DOCSDESCRIPT = entity.TABLE11NCURREN_DOC?.SDESCRIPT,
            NPROVIDER = entity.NPROVIDER,
            TAB_PROVIDERSSTATREGT = entity.TAB_PROVIDER?.SSTATREGT,
            STYPECARE = entity.STYPECARE,
            TABLE8604SDESCRIPT = entity.TABLE8604?.SDESCRIPT,
            NCURREN_ORDER = entity.NCURREN_ORDER,
            TABLE11NCURREN_ORDERSDESCRIPT = entity.TABLE11NCURREN_ORDER?.SDESCRIPT,
            NSTATUS_ORDER = entity.NSTATUS_ORDER,
            TABLE9241SDESCRIPT = entity.TABLE9241?.SDESCRIPT,
            NORDERTYPE = entity.NORDERTYPE,
            TABLE9238SDESCRIPT = entity.TABLE9238?.SDESCRIPT,
            SPREAUTHORIZATION = entity.SPREAUTHORIZATION,
            NNOTENUM = entity.NNOTENUM,
            NMOVEMENT = entity.NMOVEMENT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SCARECLASS = entity.SCARECLASS,
            NUSER_AMEND = entity.NUSER_AMEND,
            NUSER_AUDITDOC = entity.NUSER_AUDITDOC,
            NEXCHANGE = entity.NEXCHANGE,
            NNULLCODE = entity.NNULLCODE,
            TABLE9263SDESCRIPT = entity.TABLE9263?.SDESCRIPT,
            NUSER_DERIVEDBY = entity.NUSER_DERIVEDBY,
            NMASTERORDER = entity.NMASTERORDER,
            MASTERCL_ORDERSNAMECLIENT = entity.MASTERCL_ORDER?.SNAMECLIENT,
            NPHYSICIAN = entity.NPHYSICIAN,
            NMEDICALINSTITUTE = entity.NMEDICALINSTITUTE,
            NREVALIDATIONS = entity.NREVALIDATIONS,
            SPROLTREATMENT = entity.SPROLTREATMENT,
            DPROLTREATFROM = entity.DPROLTREATFROM,
            DPROLTREATTO = entity.DPROLTREATTO,
            DORIGINALPREAUTH = entity.DORIGINALPREAUTH,
            DLASTPREAUTH = entity.DLASTPREAUTH,
            NIDMEDICALFEE = entity.NIDMEDICALFEE,
            NCASE_NUM_ORIG = entity.NCASE_NUM_ORIG,
            NDEMAN_TYPE_ORIG = entity.NDEMAN_TYPE_ORIG,
            NORDER_NUM_ORIG = entity.NORDER_NUM_ORIG,
            NAUDITDOCTOR = entity.NAUDITDOCTOR,
            SCALLCENTER = entity.SCALLCENTER,
            NDOCTORROL = entity.NDOCTORROL,
            TABLE8607SDESCRIPT = entity.TABLE8607?.SDESCRIPT,
            SFASTMEDICALEVAL = entity.SFASTMEDICALEVAL,
            SOBSV_AUDITDOC = entity.SOBSV_AUDITDOC,
            DLEDGERDAT = entity.DLEDGERDAT,
            SCLIENT_BENEF = entity.SCLIENT_BENEF,
            SCLIENT_REP = entity.SCLIENT_REP,
            NCLA_LI_TYP = entity.NCLA_LI_TYP,
            TABLE210SDESCRIPT = entity.TABLE210?.SDESCRIPT,
            NIND_REOPENCL = entity.NIND_REOPENCL,
            NCAUSEREOPENCL = entity.NCAUSEREOPENCL,
            NTYPE_COMMPAY = entity.NTYPE_COMMPAY,
            NORDER_NUM_GEN = entity.NORDER_NUM_GEN,
            NCOMMERCIALPAYASSOC = entity.NCOMMERCIALPAYASSOC,
            CL_COMMERTYPEPAYSDESCRIPT = entity.CL_COMMERTYPEPAY?.SDESCRIPT,
            SHISTORICAL_CLAIM = entity.SHISTORICAL_CLAIM,
            NCOUNTRY = entity.NCOUNTRY,
            NOFFICE = entity.NOFFICE,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
        };
    }

    public static CLAIM_ORDER ToEntity(this CreateCLAIM_ORDERDto dto)
    {
        if (dto == null) return null!;
        return new CLAIM_ORDER
        {
            NCLAIMANTTYPE = dto.NCLAIMANTTYPE,
            NATTENTCHANNEL = dto.NATTENTCHANNEL,
            DORDERDATE = dto.DORDERDATE,
            NTYPEDOC_PAY = dto.NTYPEDOC_PAY,
            DACCOUNTDOC = dto.DACCOUNTDOC,
            NCURREN_DOC = dto.NCURREN_DOC,
            NPROVIDER = dto.NPROVIDER,
            STYPECARE = dto.STYPECARE,
            NCURREN_ORDER = dto.NCURREN_ORDER,
            NSTATUS_ORDER = dto.NSTATUS_ORDER,
            NORDERTYPE = dto.NORDERTYPE,
            SPREAUTHORIZATION = dto.SPREAUTHORIZATION,
            NNOTENUM = dto.NNOTENUM,
            NMOVEMENT = dto.NMOVEMENT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SCARECLASS = dto.SCARECLASS,
            NUSER_AMEND = dto.NUSER_AMEND,
            NUSER_AUDITDOC = dto.NUSER_AUDITDOC,
            NEXCHANGE = dto.NEXCHANGE,
            NNULLCODE = dto.NNULLCODE,
            NUSER_DERIVEDBY = dto.NUSER_DERIVEDBY,
            NMASTERORDER = dto.NMASTERORDER,
            NPHYSICIAN = dto.NPHYSICIAN,
            NMEDICALINSTITUTE = dto.NMEDICALINSTITUTE,
            NREVALIDATIONS = dto.NREVALIDATIONS,
            SPROLTREATMENT = dto.SPROLTREATMENT,
            DPROLTREATFROM = dto.DPROLTREATFROM,
            DPROLTREATTO = dto.DPROLTREATTO,
            DORIGINALPREAUTH = dto.DORIGINALPREAUTH,
            DLASTPREAUTH = dto.DLASTPREAUTH,
            NIDMEDICALFEE = dto.NIDMEDICALFEE,
            NCASE_NUM_ORIG = dto.NCASE_NUM_ORIG,
            NDEMAN_TYPE_ORIG = dto.NDEMAN_TYPE_ORIG,
            NORDER_NUM_ORIG = dto.NORDER_NUM_ORIG,
            NAUDITDOCTOR = dto.NAUDITDOCTOR,
            SCALLCENTER = dto.SCALLCENTER,
            NDOCTORROL = dto.NDOCTORROL,
            SFASTMEDICALEVAL = dto.SFASTMEDICALEVAL,
            SOBSV_AUDITDOC = dto.SOBSV_AUDITDOC,
            DLEDGERDAT = dto.DLEDGERDAT,
            SCLIENT_BENEF = dto.SCLIENT_BENEF,
            SCLIENT_REP = dto.SCLIENT_REP,
            NCLA_LI_TYP = dto.NCLA_LI_TYP,
            NIND_REOPENCL = dto.NIND_REOPENCL,
            NCAUSEREOPENCL = dto.NCAUSEREOPENCL,
            NTYPE_COMMPAY = dto.NTYPE_COMMPAY,
            NORDER_NUM_GEN = dto.NORDER_NUM_GEN,
            NCOMMERCIALPAYASSOC = dto.NCOMMERCIALPAYASSOC,
            SHISTORICAL_CLAIM = dto.SHISTORICAL_CLAIM,
            NCOUNTRY = dto.NCOUNTRY,
            NOFFICE = dto.NOFFICE,
        };
    }

    public static void UpdateEntity(this CLAIM_ORDER entity, UpdateCLAIM_ORDERDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCLAIMANTTYPE = dto.NCLAIMANTTYPE;
        entity.NATTENTCHANNEL = dto.NATTENTCHANNEL;
        entity.DORDERDATE = dto.DORDERDATE;
        entity.NTYPEDOC_PAY = dto.NTYPEDOC_PAY;
        entity.DACCOUNTDOC = dto.DACCOUNTDOC;
        entity.NCURREN_DOC = dto.NCURREN_DOC;
        entity.NPROVIDER = dto.NPROVIDER;
        entity.STYPECARE = dto.STYPECARE;
        entity.NCURREN_ORDER = dto.NCURREN_ORDER;
        entity.NSTATUS_ORDER = dto.NSTATUS_ORDER;
        entity.NORDERTYPE = dto.NORDERTYPE;
        entity.SPREAUTHORIZATION = dto.SPREAUTHORIZATION;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.NMOVEMENT = dto.NMOVEMENT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SCARECLASS = dto.SCARECLASS;
        entity.NUSER_AMEND = dto.NUSER_AMEND;
        entity.NUSER_AUDITDOC = dto.NUSER_AUDITDOC;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.NNULLCODE = dto.NNULLCODE;
        entity.NUSER_DERIVEDBY = dto.NUSER_DERIVEDBY;
        entity.NMASTERORDER = dto.NMASTERORDER;
        entity.NPHYSICIAN = dto.NPHYSICIAN;
        entity.NMEDICALINSTITUTE = dto.NMEDICALINSTITUTE;
        entity.NREVALIDATIONS = dto.NREVALIDATIONS;
        entity.SPROLTREATMENT = dto.SPROLTREATMENT;
        entity.DPROLTREATFROM = dto.DPROLTREATFROM;
        entity.DPROLTREATTO = dto.DPROLTREATTO;
        entity.DORIGINALPREAUTH = dto.DORIGINALPREAUTH;
        entity.DLASTPREAUTH = dto.DLASTPREAUTH;
        entity.NIDMEDICALFEE = dto.NIDMEDICALFEE;
        entity.NCASE_NUM_ORIG = dto.NCASE_NUM_ORIG;
        entity.NDEMAN_TYPE_ORIG = dto.NDEMAN_TYPE_ORIG;
        entity.NORDER_NUM_ORIG = dto.NORDER_NUM_ORIG;
        entity.NAUDITDOCTOR = dto.NAUDITDOCTOR;
        entity.SCALLCENTER = dto.SCALLCENTER;
        entity.NDOCTORROL = dto.NDOCTORROL;
        entity.SFASTMEDICALEVAL = dto.SFASTMEDICALEVAL;
        entity.SOBSV_AUDITDOC = dto.SOBSV_AUDITDOC;
        entity.DLEDGERDAT = dto.DLEDGERDAT;
        entity.SCLIENT_BENEF = dto.SCLIENT_BENEF;
        entity.SCLIENT_REP = dto.SCLIENT_REP;
        entity.NCLA_LI_TYP = dto.NCLA_LI_TYP;
        entity.NIND_REOPENCL = dto.NIND_REOPENCL;
        entity.NCAUSEREOPENCL = dto.NCAUSEREOPENCL;
        entity.NTYPE_COMMPAY = dto.NTYPE_COMMPAY;
        entity.NORDER_NUM_GEN = dto.NORDER_NUM_GEN;
        entity.NCOMMERCIALPAYASSOC = dto.NCOMMERCIALPAYASSOC;
        entity.SHISTORICAL_CLAIM = dto.SHISTORICAL_CLAIM;
        entity.NCOUNTRY = dto.NCOUNTRY;
        entity.NOFFICE = dto.NOFFICE;
    }
}
