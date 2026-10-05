using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_DFLT_USER_PREF_USAGES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CDI_DFLT_USER_PREF_USAGESMappingExtensions
{
    public static CDI_DFLT_USER_PREF_USAGESDto ToDto(this CDI_DFLT_USER_PREF_USAGES entity)
    {
        if (entity == null) return null!;
        return new CDI_DFLT_USER_PREF_USAGESDto
        {
            P_SNAME = entity.P_SNAME,
            P_CGVERSION = entity.P_CGVERSION,
            PF_SEQ = entity.PF_SEQ,
            DUP_SNAME = entity.DUP_SNAME,
            VALUE = entity.VALUE,
            DUP_INTERNAL = entity.DUP_INTERNAL,
            DUP_TYPE = entity.DUP_TYPE,
            DESCRIPTION_MSGID = entity.DESCRIPTION_MSGID,
            MANDATORY = entity.MANDATORY,
            CHR_DOMAIN = entity.CHR_DOMAIN,
            CHR_MAXLEN = entity.CHR_MAXLEN,
            NUM_HIVAL = entity.NUM_HIVAL,
            NUM_LOVAL = entity.NUM_LOVAL,
            DOM = entity.DOM,
            TAB = entity.TAB,
            CON = entity.CON,
            COL = entity.COL,
            MOD = entity.MOD,
            DTU = entity.DTU,
            CONU = entity.CONU,
            IGRP = entity.IGRP,
            DCU = entity.DCU,
            ABT = entity.ABT,
            VAT = entity.VAT,
            OBT = entity.OBT,
            TME = entity.TME,
            ARL = entity.ARL,
            TAT = entity.TAT,
            TOP = entity.TOP,
            OPP = entity.OPP,
            VVA = entity.VVA,
            ABTABT = entity.ABTABT,
            TCO = entity.TCO,
            GES = entity.GES,
            PCK = entity.PCK,
            LOV = entity.LOV,
            SUB = entity.SUB,
            ACI = entity.ACI,
            NLS_LANG = entity.NLS_LANG,
            DESCRIPTION = entity.DESCRIPTION,
        };
    }

    public static CDI_DFLT_USER_PREF_USAGES ToEntity(this CreateCDI_DFLT_USER_PREF_USAGESDto dto)
    {
        if (dto == null) return null!;
        return new CDI_DFLT_USER_PREF_USAGES
        {
            P_SNAME = dto.P_SNAME,
            P_CGVERSION = dto.P_CGVERSION,
            PF_SEQ = dto.PF_SEQ,
            DUP_SNAME = dto.DUP_SNAME,
            VALUE = dto.VALUE,
            DUP_INTERNAL = dto.DUP_INTERNAL,
            DUP_TYPE = dto.DUP_TYPE,
            DESCRIPTION_MSGID = dto.DESCRIPTION_MSGID,
            MANDATORY = dto.MANDATORY,
            CHR_DOMAIN = dto.CHR_DOMAIN,
            CHR_MAXLEN = dto.CHR_MAXLEN,
            NUM_HIVAL = dto.NUM_HIVAL,
            NUM_LOVAL = dto.NUM_LOVAL,
            DOM = dto.DOM,
            TAB = dto.TAB,
            CON = dto.CON,
            COL = dto.COL,
            MOD = dto.MOD,
            DTU = dto.DTU,
            CONU = dto.CONU,
            IGRP = dto.IGRP,
            DCU = dto.DCU,
            ABT = dto.ABT,
            VAT = dto.VAT,
            OBT = dto.OBT,
            TME = dto.TME,
            ARL = dto.ARL,
            TAT = dto.TAT,
            TOP = dto.TOP,
            OPP = dto.OPP,
            VVA = dto.VVA,
            ABTABT = dto.ABTABT,
            TCO = dto.TCO,
            GES = dto.GES,
            PCK = dto.PCK,
            LOV = dto.LOV,
            SUB = dto.SUB,
            ACI = dto.ACI,
            NLS_LANG = dto.NLS_LANG,
            DESCRIPTION = dto.DESCRIPTION,
        };
    }

    public static void UpdateEntity(this CDI_DFLT_USER_PREF_USAGES entity, UpdateCDI_DFLT_USER_PREF_USAGESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.P_SNAME = dto.P_SNAME;
        entity.P_CGVERSION = dto.P_CGVERSION;
        entity.PF_SEQ = dto.PF_SEQ;
        entity.DUP_SNAME = dto.DUP_SNAME;
        entity.VALUE = dto.VALUE;
        entity.DUP_INTERNAL = dto.DUP_INTERNAL;
        entity.DUP_TYPE = dto.DUP_TYPE;
        entity.DESCRIPTION_MSGID = dto.DESCRIPTION_MSGID;
        entity.MANDATORY = dto.MANDATORY;
        entity.CHR_DOMAIN = dto.CHR_DOMAIN;
        entity.CHR_MAXLEN = dto.CHR_MAXLEN;
        entity.NUM_HIVAL = dto.NUM_HIVAL;
        entity.NUM_LOVAL = dto.NUM_LOVAL;
        entity.DOM = dto.DOM;
        entity.TAB = dto.TAB;
        entity.CON = dto.CON;
        entity.COL = dto.COL;
        entity.MOD = dto.MOD;
        entity.DTU = dto.DTU;
        entity.CONU = dto.CONU;
        entity.IGRP = dto.IGRP;
        entity.DCU = dto.DCU;
        entity.ABT = dto.ABT;
        entity.VAT = dto.VAT;
        entity.OBT = dto.OBT;
        entity.TME = dto.TME;
        entity.ARL = dto.ARL;
        entity.TAT = dto.TAT;
        entity.TOP = dto.TOP;
        entity.OPP = dto.OPP;
        entity.VVA = dto.VVA;
        entity.ABTABT = dto.ABTABT;
        entity.TCO = dto.TCO;
        entity.GES = dto.GES;
        entity.PCK = dto.PCK;
        entity.LOV = dto.LOV;
        entity.SUB = dto.SUB;
        entity.ACI = dto.ACI;
        entity.NLS_LANG = dto.NLS_LANG;
        entity.DESCRIPTION = dto.DESCRIPTION;
    }
}
