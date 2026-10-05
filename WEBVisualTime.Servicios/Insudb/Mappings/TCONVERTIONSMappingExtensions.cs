using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TCONVERTIONS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TCONVERTIONSMappingExtensions
{
    public static TCONVERTIONSDto ToDto(this TCONVERTIONS entity)
    {
        if (entity == null) return null!;
        return new TCONVERTIONSDto
        {
            NPROPONUM = entity.NPROPONUM,
            SKEY = entity.SKEY,
            NPOLICY = entity.NPOLICY,
            NINDEX = entity.NINDEX,
            NNUM_DOC = entity.NNUM_DOC,
            SPEN_DOC = entity.SPEN_DOC,
            DDATE_INIT = entity.DDATE_INIT,
            NSTATUS = entity.NSTATUS,
            DSTAT_DATE = entity.DSTAT_DATE,
            NNULLCODE = entity.NNULLCODE,
            NROLE = entity.NROLE,
            DEFFECDATE = entity.DEFFECDATE,
            DEXPIRDAT = entity.DEXPIRDAT,
            DLIMIT_DATE = entity.DLIMIT_DATE,
            SOBSERV = entity.SOBSERV,
            NSERV_ORDER = entity.NSERV_ORDER,
            NSTATUS_ORD = entity.NSTATUS_ORD,
            NBORDEREAUX = entity.NBORDEREAUX,
            NFIRST_PREM = entity.NFIRST_PREM,
            NPREM_CURR = entity.NPREM_CURR,
            SPREM_CHE = entity.SPREM_CHE,
            SPAY_ORDER = entity.SPAY_ORDER,
            NEXPENSES = entity.NEXPENSES,
            SDEVOLUT = entity.SDEVOLUT,
            SCERTYPE = entity.SCERTYPE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NORIGIN = entity.NORIGIN,
            SCLIENT = entity.SCLIENT,
            NCERTIF = entity.NCERTIF,
            NNO_CONVERS = entity.NNO_CONVERS,
            NPOL_QUOT = entity.NPOL_QUOT,
            NWAIT_CODE = entity.NWAIT_CODE,
            NTYPE_AMEND = entity.NTYPE_AMEND,
            NEXCHANGE = entity.NEXCHANGE,
            NORIG_PREM = entity.NORIG_PREM,
            NORIG_CURR = entity.NORIG_CURR,
            NOFFICEAGEN = entity.NOFFICEAGEN,
            NOFFICE = entity.NOFFICE,
            NAGENCY = entity.NAGENCY,
            SAPPLYCOSTFP = entity.SAPPLYCOSTFP,
            NROUTINE = entity.NROUTINE,
            NHEALTHEXP = entity.NHEALTHEXP,
            SPENSTATUS_POL = entity.SPENSTATUS_POL,
        };
    }

    public static TCONVERTIONS ToEntity(this CreateTCONVERTIONSDto dto)
    {
        if (dto == null) return null!;
        return new TCONVERTIONS
        {
            NPROPONUM = dto.NPROPONUM,
            NPOLICY = dto.NPOLICY,
            NNUM_DOC = dto.NNUM_DOC,
            SPEN_DOC = dto.SPEN_DOC,
            DDATE_INIT = dto.DDATE_INIT,
            NSTATUS = dto.NSTATUS,
            DSTAT_DATE = dto.DSTAT_DATE,
            NNULLCODE = dto.NNULLCODE,
            NROLE = dto.NROLE,
            DEFFECDATE = dto.DEFFECDATE,
            DEXPIRDAT = dto.DEXPIRDAT,
            DLIMIT_DATE = dto.DLIMIT_DATE,
            SOBSERV = dto.SOBSERV,
            NSERV_ORDER = dto.NSERV_ORDER,
            NSTATUS_ORD = dto.NSTATUS_ORD,
            NBORDEREAUX = dto.NBORDEREAUX,
            NFIRST_PREM = dto.NFIRST_PREM,
            NPREM_CURR = dto.NPREM_CURR,
            SPREM_CHE = dto.SPREM_CHE,
            SPAY_ORDER = dto.SPAY_ORDER,
            NEXPENSES = dto.NEXPENSES,
            SDEVOLUT = dto.SDEVOLUT,
            SCERTYPE = dto.SCERTYPE,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NORIGIN = dto.NORIGIN,
            SCLIENT = dto.SCLIENT,
            NCERTIF = dto.NCERTIF,
            NNO_CONVERS = dto.NNO_CONVERS,
            NPOL_QUOT = dto.NPOL_QUOT,
            NWAIT_CODE = dto.NWAIT_CODE,
            NTYPE_AMEND = dto.NTYPE_AMEND,
            NEXCHANGE = dto.NEXCHANGE,
            NORIG_PREM = dto.NORIG_PREM,
            NORIG_CURR = dto.NORIG_CURR,
            NOFFICEAGEN = dto.NOFFICEAGEN,
            NOFFICE = dto.NOFFICE,
            NAGENCY = dto.NAGENCY,
            SAPPLYCOSTFP = dto.SAPPLYCOSTFP,
            NROUTINE = dto.NROUTINE,
            NHEALTHEXP = dto.NHEALTHEXP,
            SPENSTATUS_POL = dto.SPENSTATUS_POL,
        };
    }

    public static void UpdateEntity(this TCONVERTIONS entity, UpdateTCONVERTIONSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NPROPONUM = dto.NPROPONUM;
        entity.NPOLICY = dto.NPOLICY;
        entity.NNUM_DOC = dto.NNUM_DOC;
        entity.SPEN_DOC = dto.SPEN_DOC;
        entity.DDATE_INIT = dto.DDATE_INIT;
        entity.NSTATUS = dto.NSTATUS;
        entity.DSTAT_DATE = dto.DSTAT_DATE;
        entity.NNULLCODE = dto.NNULLCODE;
        entity.NROLE = dto.NROLE;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.DEXPIRDAT = dto.DEXPIRDAT;
        entity.DLIMIT_DATE = dto.DLIMIT_DATE;
        entity.SOBSERV = dto.SOBSERV;
        entity.NSERV_ORDER = dto.NSERV_ORDER;
        entity.NSTATUS_ORD = dto.NSTATUS_ORD;
        entity.NBORDEREAUX = dto.NBORDEREAUX;
        entity.NFIRST_PREM = dto.NFIRST_PREM;
        entity.NPREM_CURR = dto.NPREM_CURR;
        entity.SPREM_CHE = dto.SPREM_CHE;
        entity.SPAY_ORDER = dto.SPAY_ORDER;
        entity.NEXPENSES = dto.NEXPENSES;
        entity.SDEVOLUT = dto.SDEVOLUT;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NORIGIN = dto.NORIGIN;
        entity.SCLIENT = dto.SCLIENT;
        entity.NCERTIF = dto.NCERTIF;
        entity.NNO_CONVERS = dto.NNO_CONVERS;
        entity.NPOL_QUOT = dto.NPOL_QUOT;
        entity.NWAIT_CODE = dto.NWAIT_CODE;
        entity.NTYPE_AMEND = dto.NTYPE_AMEND;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.NORIG_PREM = dto.NORIG_PREM;
        entity.NORIG_CURR = dto.NORIG_CURR;
        entity.NOFFICEAGEN = dto.NOFFICEAGEN;
        entity.NOFFICE = dto.NOFFICE;
        entity.NAGENCY = dto.NAGENCY;
        entity.SAPPLYCOSTFP = dto.SAPPLYCOSTFP;
        entity.NROUTINE = dto.NROUTINE;
        entity.NHEALTHEXP = dto.NHEALTHEXP;
        entity.SPENSTATUS_POL = dto.SPENSTATUS_POL;
    }
}
