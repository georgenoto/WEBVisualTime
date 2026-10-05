using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAIMMappingExtensions
{
    public static CLAIMDto ToDto(this CLAIM entity)
    {
        if (entity == null) return null!;
        return new CLAIMDto
        {
            NCLAIM = entity.NCLAIM,
            SCERTYPE = entity.SCERTYPE,
            CERTIFICATSCERTYPESCUMUL_CODE = entity.CERTIFICATSCERTYPE?.SCUMUL_CODE,
            NPRODUCT = entity.NPRODUCT,
            CERTIFICATNPRODUCTSCUMUL_CODE = entity.CERTIFICATNPRODUCT?.SCUMUL_CODE,
            NPOLICY = entity.NPOLICY,
            CERTIFICATNPOLICYSCUMUL_CODE = entity.CERTIFICATNPOLICY?.SCUMUL_CODE,
            NBRANCH = entity.NBRANCH,
            CERTIFICATNBRANCHSCUMUL_CODE = entity.CERTIFICATNBRANCH?.SCUMUL_CODE,
            SCLAIMTYP = entity.SCLAIMTYP,
            TABLE132SDESCRIPT = entity.TABLE132?.SDESCRIPT,
            NCAUSECOD = entity.NCAUSECOD,
            NCERTIF = entity.NCERTIF,
            CERTIFICATNCERTIFSCUMUL_CODE = entity.CERTIFICATNCERTIF?.SCUMUL_CODE,
            SCLIENT = entity.SCLIENT,
            CLIENTSCLIENTSACCOUNT_IN = entity.CLIENTSCLIENT?.SACCOUNT_IN,
            SCOINSURI = entity.SCOINSURI,
            DCOMPDATE = entity.DCOMPDATE,
            DDECLADAT = entity.DDECLADAT,
            SINS_CLAIM = entity.SINS_CLAIM,
            SLEADCIAL = entity.SLEADCIAL,
            NLOC_COS_RE = entity.NLOC_COS_RE,
            NLOC_OUT_AM = entity.NLOC_OUT_AM,
            NLOC_PAY_AM = entity.NLOC_PAY_AM,
            NLOC_REC_AM = entity.NLOC_REC_AM,
            NLOC_RESERV = entity.NLOC_RESERV,
            SMAILNUMB = entity.SMAILNUMB,
            NMOVEMENT = entity.NMOVEMENT,
            NNOTENUM = entity.NNOTENUM,
            NNULLCODE = entity.NNULLCODE,
            TABLE136SDESCRIPT = entity.TABLE136?.SDESCRIPT,
            DOCCURDAT = entity.DOCCURDAT,
            NOFFICE = entity.NOFFICE,
            TABLE9NOFFICESDESCRIPT = entity.TABLE9NOFFICE?.SDESCRIPT,
            NOFFICE_OWN = entity.NOFFICE_OWN,
            TABLE9NOFFICE_OWNSDESCRIPT = entity.TABLE9NOFFICE_OWN?.SDESCRIPT,
            NOFFICTRA = entity.NOFFICTRA,
            TABLE9NOFFICTRASDESCRIPT = entity.TABLE9NOFFICTRA?.SDESCRIPT,
            DPRESCDAT = entity.DPRESCDAT,
            SPRINTED = entity.SPRINTED,
            SREINSURI = entity.SREINSURI,
            DSHOW_DATE = entity.DSHOW_DATE,
            SSHOW_STATU = entity.SSHOW_STATU,
            SSTACLAIM = entity.SSTACLAIM,
            TABLE135SDESCRIPT = entity.TABLE135?.SDESCRIPT,
            NUNACCODE = entity.NUNACCODE,
            TABLE133SDESCRIPT = entity.TABLE133?.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            SNUMFORM = entity.SNUMFORM,
            NTAX_AMO = entity.NTAX_AMO,
            NIMAGENUM = entity.NIMAGENUM,
            SCESS_NPR = entity.SCESS_NPR,
            SCLIENT2 = entity.SCLIENT2,
            CLIENTSCLIENT2SACCOUNT_IN = entity.CLIENTSCLIENT2?.SACCOUNT_IN,
            NBORDEREAUX_CL = entity.NBORDEREAUX_CL,
            CLAIM_MASTERSCLIENT = entity.CLAIM_MASTER?.SCLIENT,
            DLIMIT_PAY = entity.DLIMIT_PAY,
            NIDCATAS = entity.NIDCATAS,
            NOFFICE_PAY = entity.NOFFICE_PAY,
            TABLE9NOFFICE_PAYSDESCRIPT = entity.TABLE9NOFFICE_PAY?.SDESCRIPT,
            NWAITCL_CODE = entity.NWAITCL_CODE,
            TABLE5604SDESCRIPT = entity.TABLE5604?.SDESCRIPT,
            NRELASHIP = entity.NRELASHIP,
            TABLE15SDESCRIPT = entity.TABLE15?.SDESCRIPT,
            NOFFICEAGEN = entity.NOFFICEAGEN,
            TABLE5556NOFFICEAGENSDESCRIPT = entity.TABLE5556NOFFICEAGEN?.SDESCRIPT,
            NAGENCY = entity.NAGENCY,
            AGENCIESNAGENCYSPAY = entity.AGENCIESNAGENCY?.SPAY,
            NAGENCY_PAY = entity.NAGENCY_PAY,
            AGENCIESNAGENCY_PAYSPAY = entity.AGENCIESNAGENCY_PAY?.SPAY,
            NOFFICEAGEN_PAY = entity.NOFFICEAGEN_PAY,
            TABLE5556NOFFICEAGEN_PAYSDESCRIPT = entity.TABLE5556NOFFICEAGEN_PAY?.SDESCRIPT,
            NCLAIMPARENT = entity.NCLAIMPARENT,
            SUNIQUEID = entity.SUNIQUEID,
            DMC_OCCURDAT = entity.DMC_OCCURDAT,
            DCOMPLETDATE = entity.DCOMPLETDATE,
            DPAYDATE = entity.DPAYDATE,
            NIDPRECLAIM = entity.NIDPRECLAIM,
            PRECLAIMSCERTYPE = entity.PRECLAIM?.SCERTYPE,
            NPRECLAIM = entity.NPRECLAIM,
            NCLAIMANTTYPE = entity.NCLAIMANTTYPE,
            TABLE9212SDESCRIPT = entity.TABLE9212?.SDESCRIPT,
            DPRESENTDATE = entity.DPRESENTDATE,
            NIND_REOPENCL = entity.NIND_REOPENCL,
            NCAUSEREOPENCL = entity.NCAUSEREOPENCL,
            NTYPE_COMMPAY = entity.NTYPE_COMMPAY,
            SHISTORICAL_CLAIM = entity.SHISTORICAL_CLAIM,
        };
    }

    public static CLAIM ToEntity(this CreateCLAIMDto dto)
    {
        if (dto == null) return null!;
        return new CLAIM
        {
            SCERTYPE = dto.SCERTYPE,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NBRANCH = dto.NBRANCH,
            SCLAIMTYP = dto.SCLAIMTYP,
            NCAUSECOD = dto.NCAUSECOD,
            NCERTIF = dto.NCERTIF,
            SCLIENT = dto.SCLIENT,
            SCOINSURI = dto.SCOINSURI,
            DCOMPDATE = dto.DCOMPDATE,
            DDECLADAT = dto.DDECLADAT,
            SINS_CLAIM = dto.SINS_CLAIM,
            SLEADCIAL = dto.SLEADCIAL,
            NLOC_COS_RE = dto.NLOC_COS_RE,
            NLOC_OUT_AM = dto.NLOC_OUT_AM,
            NLOC_PAY_AM = dto.NLOC_PAY_AM,
            NLOC_REC_AM = dto.NLOC_REC_AM,
            NLOC_RESERV = dto.NLOC_RESERV,
            SMAILNUMB = dto.SMAILNUMB,
            NMOVEMENT = dto.NMOVEMENT,
            NNOTENUM = dto.NNOTENUM,
            NNULLCODE = dto.NNULLCODE,
            DOCCURDAT = dto.DOCCURDAT,
            NOFFICE = dto.NOFFICE,
            NOFFICE_OWN = dto.NOFFICE_OWN,
            NOFFICTRA = dto.NOFFICTRA,
            DPRESCDAT = dto.DPRESCDAT,
            SPRINTED = dto.SPRINTED,
            SREINSURI = dto.SREINSURI,
            DSHOW_DATE = dto.DSHOW_DATE,
            SSHOW_STATU = dto.SSHOW_STATU,
            SSTACLAIM = dto.SSTACLAIM,
            NUNACCODE = dto.NUNACCODE,
            NUSERCODE = dto.NUSERCODE,
            SNUMFORM = dto.SNUMFORM,
            NTAX_AMO = dto.NTAX_AMO,
            NIMAGENUM = dto.NIMAGENUM,
            SCESS_NPR = dto.SCESS_NPR,
            SCLIENT2 = dto.SCLIENT2,
            NBORDEREAUX_CL = dto.NBORDEREAUX_CL,
            DLIMIT_PAY = dto.DLIMIT_PAY,
            NIDCATAS = dto.NIDCATAS,
            NOFFICE_PAY = dto.NOFFICE_PAY,
            NWAITCL_CODE = dto.NWAITCL_CODE,
            NRELASHIP = dto.NRELASHIP,
            NOFFICEAGEN = dto.NOFFICEAGEN,
            NAGENCY = dto.NAGENCY,
            NAGENCY_PAY = dto.NAGENCY_PAY,
            NOFFICEAGEN_PAY = dto.NOFFICEAGEN_PAY,
            NCLAIMPARENT = dto.NCLAIMPARENT,
            SUNIQUEID = dto.SUNIQUEID,
            DMC_OCCURDAT = dto.DMC_OCCURDAT,
            DCOMPLETDATE = dto.DCOMPLETDATE,
            DPAYDATE = dto.DPAYDATE,
            NIDPRECLAIM = dto.NIDPRECLAIM,
            NPRECLAIM = dto.NPRECLAIM,
            NCLAIMANTTYPE = dto.NCLAIMANTTYPE,
            DPRESENTDATE = dto.DPRESENTDATE,
            NIND_REOPENCL = dto.NIND_REOPENCL,
            NCAUSEREOPENCL = dto.NCAUSEREOPENCL,
            NTYPE_COMMPAY = dto.NTYPE_COMMPAY,
            SHISTORICAL_CLAIM = dto.SHISTORICAL_CLAIM,
        };
    }

    public static void UpdateEntity(this CLAIM entity, UpdateCLAIMDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NBRANCH = dto.NBRANCH;
        entity.SCLAIMTYP = dto.SCLAIMTYP;
        entity.NCAUSECOD = dto.NCAUSECOD;
        entity.NCERTIF = dto.NCERTIF;
        entity.SCLIENT = dto.SCLIENT;
        entity.SCOINSURI = dto.SCOINSURI;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DDECLADAT = dto.DDECLADAT;
        entity.SINS_CLAIM = dto.SINS_CLAIM;
        entity.SLEADCIAL = dto.SLEADCIAL;
        entity.NLOC_COS_RE = dto.NLOC_COS_RE;
        entity.NLOC_OUT_AM = dto.NLOC_OUT_AM;
        entity.NLOC_PAY_AM = dto.NLOC_PAY_AM;
        entity.NLOC_REC_AM = dto.NLOC_REC_AM;
        entity.NLOC_RESERV = dto.NLOC_RESERV;
        entity.SMAILNUMB = dto.SMAILNUMB;
        entity.NMOVEMENT = dto.NMOVEMENT;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.NNULLCODE = dto.NNULLCODE;
        entity.DOCCURDAT = dto.DOCCURDAT;
        entity.NOFFICE = dto.NOFFICE;
        entity.NOFFICE_OWN = dto.NOFFICE_OWN;
        entity.NOFFICTRA = dto.NOFFICTRA;
        entity.DPRESCDAT = dto.DPRESCDAT;
        entity.SPRINTED = dto.SPRINTED;
        entity.SREINSURI = dto.SREINSURI;
        entity.DSHOW_DATE = dto.DSHOW_DATE;
        entity.SSHOW_STATU = dto.SSHOW_STATU;
        entity.SSTACLAIM = dto.SSTACLAIM;
        entity.NUNACCODE = dto.NUNACCODE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SNUMFORM = dto.SNUMFORM;
        entity.NTAX_AMO = dto.NTAX_AMO;
        entity.NIMAGENUM = dto.NIMAGENUM;
        entity.SCESS_NPR = dto.SCESS_NPR;
        entity.SCLIENT2 = dto.SCLIENT2;
        entity.NBORDEREAUX_CL = dto.NBORDEREAUX_CL;
        entity.DLIMIT_PAY = dto.DLIMIT_PAY;
        entity.NIDCATAS = dto.NIDCATAS;
        entity.NOFFICE_PAY = dto.NOFFICE_PAY;
        entity.NWAITCL_CODE = dto.NWAITCL_CODE;
        entity.NRELASHIP = dto.NRELASHIP;
        entity.NOFFICEAGEN = dto.NOFFICEAGEN;
        entity.NAGENCY = dto.NAGENCY;
        entity.NAGENCY_PAY = dto.NAGENCY_PAY;
        entity.NOFFICEAGEN_PAY = dto.NOFFICEAGEN_PAY;
        entity.NCLAIMPARENT = dto.NCLAIMPARENT;
        entity.SUNIQUEID = dto.SUNIQUEID;
        entity.DMC_OCCURDAT = dto.DMC_OCCURDAT;
        entity.DCOMPLETDATE = dto.DCOMPLETDATE;
        entity.DPAYDATE = dto.DPAYDATE;
        entity.NIDPRECLAIM = dto.NIDPRECLAIM;
        entity.NPRECLAIM = dto.NPRECLAIM;
        entity.NCLAIMANTTYPE = dto.NCLAIMANTTYPE;
        entity.DPRESENTDATE = dto.DPRESENTDATE;
        entity.NIND_REOPENCL = dto.NIND_REOPENCL;
        entity.NCAUSEREOPENCL = dto.NCAUSEREOPENCL;
        entity.NTYPE_COMMPAY = dto.NTYPE_COMMPAY;
        entity.SHISTORICAL_CLAIM = dto.SHISTORICAL_CLAIM;
    }
}
