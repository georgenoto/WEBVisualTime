using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRNPRO;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CONTRNPROMappingExtensions
{
    public static CONTRNPRODto ToDto(this CONTRNPRO entity)
    {
        if (entity == null) return null!;
        return new CONTRNPRODto
        {
            NNUMBER = entity.NNUMBER,
            CONTRMASTERNNUMBERSSTATREGT = entity.CONTRMASTERNNUMBER?.SSTATREGT,
            NBRANCH = entity.NBRANCH,
            CONTRMASTERNBRANCHSSTATREGT = entity.CONTRMASTERNBRANCH?.SSTATREGT,
            DEFFECDATE = entity.DEFFECDATE,
            NTYPE = entity.NTYPE,
            CONTRMASTERNTYPESSTATREGT = entity.CONTRMASTERNTYPE?.SSTATREGT,
            NAMOUNT = entity.NAMOUNT,
            NTYPE_REL = entity.NTYPE_REL,
            CONTRMASTERNTYPE_RELSSTATREGT = entity.CONTRMASTERNTYPE_REL?.SSTATREGT,
            NCESSION = entity.NCESSION,
            NCLAUSULE = entity.NCLAUSULE,
            DCOMPDATE = entity.DCOMPDATE,
            NDEDUCIBLE = entity.NDEDUCIBLE,
            SDESCRIPT = entity.SDESCRIPT,
            NEXCESS = entity.NEXCESS,
            NMAX_EVEN = entity.NMAX_EVEN,
            DNULLDATE = entity.DNULLDATE,
            NNUMBER_REP = entity.NNUMBER_REP,
            NPORC_REP = entity.NPORC_REP,
            NPREM_DEP = entity.NPREM_DEP,
            NPREM_FIJ = entity.NPREM_FIJ,
            NPREM_MIN = entity.NPREM_MIN,
            NRATE_FIJ = entity.NRATE_FIJ,
            NRATE_MAX = entity.NRATE_MAX,
            NRATE_MIN = entity.NRATE_MIN,
            SREINSURAN = entity.SREINSURAN,
            NRETENTION = entity.NRETENTION,
            NUSERCODE = entity.NUSERCODE,
            NCURR_PAY = entity.NCURR_PAY,
            NINTEREST = entity.NINTEREST,
            NFREQPAY = entity.NFREQPAY,
            TABLE97NFREQPAYSDESCRIPT = entity.TABLE97NFREQPAY?.SDESCRIPT,
            NNEXTMONTHPA = entity.NNEXTMONTHPA,
            NNEXTYEARPA = entity.NNEXTYEARPA,
            NFREQCT = entity.NFREQCT,
            TABLE97NFREQCTSDESCRIPT = entity.TABLE97NFREQCT?.SDESCRIPT,
            NNEXTMONTHC = entity.NNEXTMONTHC,
            NNEXTYEARC = entity.NNEXTYEARC,
            SROUCESSPR = entity.SROUCESSPR,
            SROUCESSCL = entity.SROUCESSCL,
            SAGREEMENTPAYS = entity.SAGREEMENTPAYS,
            SROUNETRET = entity.SROUNETRET,
            NRATE_NRIFV = entity.NRATE_NRIFV,
            NCLAIMSCATAS = entity.NCLAIMSCATAS,
            NMAXRESPEVEN = entity.NMAXRESPEVEN,
            NNUMBERREPEVEN = entity.NNUMBERREPEVEN,
            SPRORATEREP = entity.SPRORATEREP,
            NPORC_PAY = entity.NPORC_PAY,
            NPREMIUM_DEVENG = entity.NPREMIUM_DEVENG,
            NEPI = entity.NEPI,
            NTAX = entity.NTAX,
            NCLAIMADJ = entity.NCLAIMADJ,
            NCAPITALREF = entity.NCAPITALREF,
            NLIFENUM = entity.NLIFENUM,
            NSPCPRIORITY = entity.NSPCPRIORITY,
            NSPCLIMIT = entity.NSPCLIMIT,
        };
    }

    public static CONTRNPRO ToEntity(this CreateCONTRNPRODto dto)
    {
        if (dto == null) return null!;
        return new CONTRNPRO
        {
            NAMOUNT = dto.NAMOUNT,
            NTYPE_REL = dto.NTYPE_REL,
            NCESSION = dto.NCESSION,
            NCLAUSULE = dto.NCLAUSULE,
            DCOMPDATE = dto.DCOMPDATE,
            NDEDUCIBLE = dto.NDEDUCIBLE,
            SDESCRIPT = dto.SDESCRIPT,
            NEXCESS = dto.NEXCESS,
            NMAX_EVEN = dto.NMAX_EVEN,
            DNULLDATE = dto.DNULLDATE,
            NNUMBER_REP = dto.NNUMBER_REP,
            NPORC_REP = dto.NPORC_REP,
            NPREM_DEP = dto.NPREM_DEP,
            NPREM_FIJ = dto.NPREM_FIJ,
            NPREM_MIN = dto.NPREM_MIN,
            NRATE_FIJ = dto.NRATE_FIJ,
            NRATE_MAX = dto.NRATE_MAX,
            NRATE_MIN = dto.NRATE_MIN,
            SREINSURAN = dto.SREINSURAN,
            NRETENTION = dto.NRETENTION,
            NUSERCODE = dto.NUSERCODE,
            NCURR_PAY = dto.NCURR_PAY,
            NINTEREST = dto.NINTEREST,
            NFREQPAY = dto.NFREQPAY,
            NNEXTMONTHPA = dto.NNEXTMONTHPA,
            NNEXTYEARPA = dto.NNEXTYEARPA,
            NFREQCT = dto.NFREQCT,
            NNEXTMONTHC = dto.NNEXTMONTHC,
            NNEXTYEARC = dto.NNEXTYEARC,
            SROUCESSPR = dto.SROUCESSPR,
            SROUCESSCL = dto.SROUCESSCL,
            SAGREEMENTPAYS = dto.SAGREEMENTPAYS,
            SROUNETRET = dto.SROUNETRET,
            NRATE_NRIFV = dto.NRATE_NRIFV,
            NCLAIMSCATAS = dto.NCLAIMSCATAS,
            NMAXRESPEVEN = dto.NMAXRESPEVEN,
            NNUMBERREPEVEN = dto.NNUMBERREPEVEN,
            SPRORATEREP = dto.SPRORATEREP,
            NPORC_PAY = dto.NPORC_PAY,
            NPREMIUM_DEVENG = dto.NPREMIUM_DEVENG,
            NEPI = dto.NEPI,
            NTAX = dto.NTAX,
            NCLAIMADJ = dto.NCLAIMADJ,
            NCAPITALREF = dto.NCAPITALREF,
            NLIFENUM = dto.NLIFENUM,
            NSPCPRIORITY = dto.NSPCPRIORITY,
            NSPCLIMIT = dto.NSPCLIMIT,
        };
    }

    public static void UpdateEntity(this CONTRNPRO entity, UpdateCONTRNPRODto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NTYPE_REL = dto.NTYPE_REL;
        entity.NCESSION = dto.NCESSION;
        entity.NCLAUSULE = dto.NCLAUSULE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NDEDUCIBLE = dto.NDEDUCIBLE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NEXCESS = dto.NEXCESS;
        entity.NMAX_EVEN = dto.NMAX_EVEN;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NNUMBER_REP = dto.NNUMBER_REP;
        entity.NPORC_REP = dto.NPORC_REP;
        entity.NPREM_DEP = dto.NPREM_DEP;
        entity.NPREM_FIJ = dto.NPREM_FIJ;
        entity.NPREM_MIN = dto.NPREM_MIN;
        entity.NRATE_FIJ = dto.NRATE_FIJ;
        entity.NRATE_MAX = dto.NRATE_MAX;
        entity.NRATE_MIN = dto.NRATE_MIN;
        entity.SREINSURAN = dto.SREINSURAN;
        entity.NRETENTION = dto.NRETENTION;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NCURR_PAY = dto.NCURR_PAY;
        entity.NINTEREST = dto.NINTEREST;
        entity.NFREQPAY = dto.NFREQPAY;
        entity.NNEXTMONTHPA = dto.NNEXTMONTHPA;
        entity.NNEXTYEARPA = dto.NNEXTYEARPA;
        entity.NFREQCT = dto.NFREQCT;
        entity.NNEXTMONTHC = dto.NNEXTMONTHC;
        entity.NNEXTYEARC = dto.NNEXTYEARC;
        entity.SROUCESSPR = dto.SROUCESSPR;
        entity.SROUCESSCL = dto.SROUCESSCL;
        entity.SAGREEMENTPAYS = dto.SAGREEMENTPAYS;
        entity.SROUNETRET = dto.SROUNETRET;
        entity.NRATE_NRIFV = dto.NRATE_NRIFV;
        entity.NCLAIMSCATAS = dto.NCLAIMSCATAS;
        entity.NMAXRESPEVEN = dto.NMAXRESPEVEN;
        entity.NNUMBERREPEVEN = dto.NNUMBERREPEVEN;
        entity.SPRORATEREP = dto.SPRORATEREP;
        entity.NPORC_PAY = dto.NPORC_PAY;
        entity.NPREMIUM_DEVENG = dto.NPREMIUM_DEVENG;
        entity.NEPI = dto.NEPI;
        entity.NTAX = dto.NTAX;
        entity.NCLAIMADJ = dto.NCLAIMADJ;
        entity.NCAPITALREF = dto.NCAPITALREF;
        entity.NLIFENUM = dto.NLIFENUM;
        entity.NSPCPRIORITY = dto.NSPCPRIORITY;
        entity.NSPCLIMIT = dto.NSPCLIMIT;
    }
}
