using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERCL_ORDER;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MASTERCL_ORDERMappingExtensions
{
    public static MASTERCL_ORDERDto ToDto(this MASTERCL_ORDER entity)
    {
        if (entity == null) return null!;
        return new MASTERCL_ORDERDto
        {
            NMASTERORDER = entity.NMASTERORDER,
            NOFFICE = entity.NOFFICE,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            SNAMECLIENT = entity.SNAMECLIENT,
            NPROVIDER = entity.NPROVIDER,
            NATTENTCHANNEL = entity.NATTENTCHANNEL,
            DACCOUNTDOC = entity.DACCOUNTDOC,
            NTYPEDOC_PAY = entity.NTYPEDOC_PAY,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NSTATORDER_MAST = entity.NSTATORDER_MAST,
            TABLE9264SDESCRIPT = entity.TABLE9264?.SDESCRIPT,
            NNOTENUM = entity.NNOTENUM,
            DORDERDATE = entity.DORDERDATE,
            NUSER_AMEND = entity.NUSER_AMEND,
            NUSER_AUDITDOC = entity.NUSER_AUDITDOC,
            NUSER_DERIVEDBY = entity.NUSER_DERIVEDBY,
            NMASTERORDERTYPE = entity.NMASTERORDERTYPE,
            TABLE9265SDESCRIPT = entity.TABLE9265?.SDESCRIPT,
            SPREAUTHORIZATION = entity.SPREAUTHORIZATION,
            NCLAIMANTTYPE = entity.NCLAIMANTTYPE,
            TABLE9212SDESCRIPT = entity.TABLE9212?.SDESCRIPT,
            NREVALIDATIONS = entity.NREVALIDATIONS,
            DORIGINALPREAUTH = entity.DORIGINALPREAUTH,
            DLASTPREAUTH = entity.DLASTPREAUTH,
            STYPECARE = entity.STYPECARE,
            TABLE8604SDESCRIPT = entity.TABLE8604?.SDESCRIPT,
            SCARECLASS = entity.SCARECLASS,
            TABLE8605SDESCRIPT = entity.TABLE8605?.SDESCRIPT,
            NCURREN_DOC = entity.NCURREN_DOC,
            NCURREN_ORDER = entity.NCURREN_ORDER,
            SCALLCENTER = entity.SCALLCENTER,
            NEXCHANGE = entity.NEXCHANGE,
            DPRESENTDATE = entity.DPRESENTDATE,
            NCLAIM = entity.NCLAIM,
            NNULLCODE = entity.NNULLCODE,
            TABLE9263SDESCRIPT = entity.TABLE9263?.SDESCRIPT,
            DLEDGERDAT = entity.DLEDGERDAT,
            NCLA_LI_TYP = entity.NCLA_LI_TYP,
            TABLE210SDESCRIPT = entity.TABLE210?.SDESCRIPT,
            NIND_REOPENCL = entity.NIND_REOPENCL,
            NCAUSEREOPENCL = entity.NCAUSEREOPENCL,
            NTYPE_COMMPAY = entity.NTYPE_COMMPAY,
            NMASTERORDER_NUM_ORIG = entity.NMASTERORDER_NUM_ORIG,
            NMASTERORDEN_NUM_GEN = entity.NMASTERORDEN_NUM_GEN,
            SHISTORICAL_CLAIM = entity.SHISTORICAL_CLAIM,
            NCOUNTRY = entity.NCOUNTRY,
            NSEQUENCE_ID = entity.NSEQUENCE_ID,
        };
    }

    public static MASTERCL_ORDER ToEntity(this CreateMASTERCL_ORDERDto dto)
    {
        if (dto == null) return null!;
        return new MASTERCL_ORDER
        {
            NOFFICE = dto.NOFFICE,
            SNAMECLIENT = dto.SNAMECLIENT,
            NPROVIDER = dto.NPROVIDER,
            NATTENTCHANNEL = dto.NATTENTCHANNEL,
            DACCOUNTDOC = dto.DACCOUNTDOC,
            NTYPEDOC_PAY = dto.NTYPEDOC_PAY,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NSTATORDER_MAST = dto.NSTATORDER_MAST,
            NNOTENUM = dto.NNOTENUM,
            DORDERDATE = dto.DORDERDATE,
            NUSER_AMEND = dto.NUSER_AMEND,
            NUSER_AUDITDOC = dto.NUSER_AUDITDOC,
            NUSER_DERIVEDBY = dto.NUSER_DERIVEDBY,
            NMASTERORDERTYPE = dto.NMASTERORDERTYPE,
            SPREAUTHORIZATION = dto.SPREAUTHORIZATION,
            NCLAIMANTTYPE = dto.NCLAIMANTTYPE,
            NREVALIDATIONS = dto.NREVALIDATIONS,
            DORIGINALPREAUTH = dto.DORIGINALPREAUTH,
            DLASTPREAUTH = dto.DLASTPREAUTH,
            STYPECARE = dto.STYPECARE,
            SCARECLASS = dto.SCARECLASS,
            NCURREN_DOC = dto.NCURREN_DOC,
            NCURREN_ORDER = dto.NCURREN_ORDER,
            SCALLCENTER = dto.SCALLCENTER,
            NEXCHANGE = dto.NEXCHANGE,
            DPRESENTDATE = dto.DPRESENTDATE,
            NCLAIM = dto.NCLAIM,
            NNULLCODE = dto.NNULLCODE,
            DLEDGERDAT = dto.DLEDGERDAT,
            NCLA_LI_TYP = dto.NCLA_LI_TYP,
            NIND_REOPENCL = dto.NIND_REOPENCL,
            NCAUSEREOPENCL = dto.NCAUSEREOPENCL,
            NTYPE_COMMPAY = dto.NTYPE_COMMPAY,
            NMASTERORDER_NUM_ORIG = dto.NMASTERORDER_NUM_ORIG,
            NMASTERORDEN_NUM_GEN = dto.NMASTERORDEN_NUM_GEN,
            SHISTORICAL_CLAIM = dto.SHISTORICAL_CLAIM,
            NCOUNTRY = dto.NCOUNTRY,
            NSEQUENCE_ID = dto.NSEQUENCE_ID,
        };
    }

    public static void UpdateEntity(this MASTERCL_ORDER entity, UpdateMASTERCL_ORDERDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NOFFICE = dto.NOFFICE;
        entity.SNAMECLIENT = dto.SNAMECLIENT;
        entity.NPROVIDER = dto.NPROVIDER;
        entity.NATTENTCHANNEL = dto.NATTENTCHANNEL;
        entity.DACCOUNTDOC = dto.DACCOUNTDOC;
        entity.NTYPEDOC_PAY = dto.NTYPEDOC_PAY;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NSTATORDER_MAST = dto.NSTATORDER_MAST;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.DORDERDATE = dto.DORDERDATE;
        entity.NUSER_AMEND = dto.NUSER_AMEND;
        entity.NUSER_AUDITDOC = dto.NUSER_AUDITDOC;
        entity.NUSER_DERIVEDBY = dto.NUSER_DERIVEDBY;
        entity.NMASTERORDERTYPE = dto.NMASTERORDERTYPE;
        entity.SPREAUTHORIZATION = dto.SPREAUTHORIZATION;
        entity.NCLAIMANTTYPE = dto.NCLAIMANTTYPE;
        entity.NREVALIDATIONS = dto.NREVALIDATIONS;
        entity.DORIGINALPREAUTH = dto.DORIGINALPREAUTH;
        entity.DLASTPREAUTH = dto.DLASTPREAUTH;
        entity.STYPECARE = dto.STYPECARE;
        entity.SCARECLASS = dto.SCARECLASS;
        entity.NCURREN_DOC = dto.NCURREN_DOC;
        entity.NCURREN_ORDER = dto.NCURREN_ORDER;
        entity.SCALLCENTER = dto.SCALLCENTER;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.DPRESENTDATE = dto.DPRESENTDATE;
        entity.NCLAIM = dto.NCLAIM;
        entity.NNULLCODE = dto.NNULLCODE;
        entity.DLEDGERDAT = dto.DLEDGERDAT;
        entity.NCLA_LI_TYP = dto.NCLA_LI_TYP;
        entity.NIND_REOPENCL = dto.NIND_REOPENCL;
        entity.NCAUSEREOPENCL = dto.NCAUSEREOPENCL;
        entity.NTYPE_COMMPAY = dto.NTYPE_COMMPAY;
        entity.NMASTERORDER_NUM_ORIG = dto.NMASTERORDER_NUM_ORIG;
        entity.NMASTERORDEN_NUM_GEN = dto.NMASTERORDEN_NUM_GEN;
        entity.SHISTORICAL_CLAIM = dto.SHISTORICAL_CLAIM;
        entity.NCOUNTRY = dto.NCOUNTRY;
        entity.NSEQUENCE_ID = dto.NSEQUENCE_ID;
    }
}
