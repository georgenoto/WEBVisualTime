using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class INTERMEDIAMappingExtensions
{
    public static INTERMEDIADto ToDto(this INTERMEDIA entity)
    {
        if (entity == null) return null!;
        return new INTERMEDIADto
        {
            NINTERMED = entity.NINTERMED,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            DCOMPDATE = entity.DCOMPDATE,
            NCOMTABGE = entity.NCOMTABGE,
            NCOMTABLI = entity.NCOMTABLI,
            TAB_COMLIFSDESCRIPT = entity.TAB_COMLIF?.SDESCRIPT,
            DINPDATE = entity.DINPDATE,
            NINT_STATUS = entity.NINT_STATUS,
            TABLE200SDESCRIPT = entity.TABLE200?.SDESCRIPT,
            NINTERTYP = entity.NINTERTYP,
            INTERM_TYPSDESCRIPT = entity.INTERM_TYP?.SDESCRIPT,
            NNULLCODE = entity.NNULLCODE,
            TABLE163SDESCRIPT = entity.TABLE163?.SDESCRIPT,
            DNULLDATE = entity.DNULLDATE,
            NOFFICE = entity.NOFFICE,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            NSUPERVIS = entity.NSUPERVIS,
            NTABLE_COD = entity.NTABLE_COD,
            NTAX = entity.NTAX,
            NUSERCODE = entity.NUSERCODE,
            SCOL_AGREE = entity.SCOL_AGREE,
            NNOTENUM = entity.NNOTENUM,
            NECO_SCHE = entity.NECO_SCHE,
            DISEX_INT_MSDESCRIPT = entity.DISEX_INT_M?.SDESCRIPT,
            SINTER_ID = entity.SINTER_ID,
            SAGREEINT = entity.SAGREEINT,
            SLIFE = entity.SLIFE,
            SNONLIFE = entity.SNONLIFE,
            NLIFE_SCHE = entity.NLIFE_SCHE,
            TABLE5500NLIFE_SCHESDESCRIPT = entity.TABLE5500NLIFE_SCHE?.SDESCRIPT,
            NGEN_SCHE = entity.NGEN_SCHE,
            TABLE5500NGEN_SCHESDESCRIPT = entity.TABLE5500NGEN_SCHE?.SDESCRIPT,
            NLEGAL_SCH = entity.NLEGAL_SCH,
            TABLE5501SDESCRIPT = entity.TABLE5501?.SDESCRIPT,
            NSUP_GEN = entity.NSUP_GEN,
            NINSU_ASSIST = entity.NINSU_ASSIST,
            NGOAL_GEN = entity.NGOAL_GEN,
            NGOAL_LIFE = entity.NGOAL_LIFE,
            NINSU_ASSISTLIF = entity.NINSU_ASSISTLIF,
            NAGENCY = entity.NAGENCY,
            TABLE5555SDESCRIPT = entity.TABLE5555?.SDESCRIPT,
            NOFFICEAGEN = entity.NOFFICEAGEN,
            TABLE5556SDESCRIPT = entity.TABLE5556?.SDESCRIPT,
            NSLC_TAB_NR = entity.NSLC_TAB_NR,
            DCOMMIDATE = entity.DCOMMIDATE,
            SVALID = entity.SVALID,
            NCONTRAT = entity.NCONTRAT,
            NRECEPTYP = entity.NRECEPTYP,
            TABLE9211SDESCRIPT = entity.TABLE9211?.SDESCRIPT,
            NCOM_CHANNEL = entity.NCOM_CHANNEL,
            SPERSIS = entity.SPERSIS,
            NUSER_RETENC = entity.NUSER_RETENC,
            DDATE_RETENC = entity.DDATE_RETENC,
            NUSER_LIBRET = entity.NUSER_LIBRET,
            DDATE_LIBRET = entity.DDATE_LIBRET,
            SCODAGENT_SCAB = entity.SCODAGENT_SCAB,
        };
    }

    public static INTERMEDIA ToEntity(this CreateINTERMEDIADto dto)
    {
        if (dto == null) return null!;
        return new INTERMEDIA
        {
            SCLIENT = dto.SCLIENT,
            DCOMPDATE = dto.DCOMPDATE,
            NCOMTABGE = dto.NCOMTABGE,
            NCOMTABLI = dto.NCOMTABLI,
            DINPDATE = dto.DINPDATE,
            NINT_STATUS = dto.NINT_STATUS,
            NINTERTYP = dto.NINTERTYP,
            NNULLCODE = dto.NNULLCODE,
            DNULLDATE = dto.DNULLDATE,
            NOFFICE = dto.NOFFICE,
            NSUPERVIS = dto.NSUPERVIS,
            NTABLE_COD = dto.NTABLE_COD,
            NTAX = dto.NTAX,
            NUSERCODE = dto.NUSERCODE,
            SCOL_AGREE = dto.SCOL_AGREE,
            NNOTENUM = dto.NNOTENUM,
            NECO_SCHE = dto.NECO_SCHE,
            SINTER_ID = dto.SINTER_ID,
            SAGREEINT = dto.SAGREEINT,
            SLIFE = dto.SLIFE,
            SNONLIFE = dto.SNONLIFE,
            NLIFE_SCHE = dto.NLIFE_SCHE,
            NGEN_SCHE = dto.NGEN_SCHE,
            NLEGAL_SCH = dto.NLEGAL_SCH,
            NSUP_GEN = dto.NSUP_GEN,
            NINSU_ASSIST = dto.NINSU_ASSIST,
            NGOAL_GEN = dto.NGOAL_GEN,
            NGOAL_LIFE = dto.NGOAL_LIFE,
            NINSU_ASSISTLIF = dto.NINSU_ASSISTLIF,
            NAGENCY = dto.NAGENCY,
            NOFFICEAGEN = dto.NOFFICEAGEN,
            NSLC_TAB_NR = dto.NSLC_TAB_NR,
            DCOMMIDATE = dto.DCOMMIDATE,
            SVALID = dto.SVALID,
            NCONTRAT = dto.NCONTRAT,
            NRECEPTYP = dto.NRECEPTYP,
            NCOM_CHANNEL = dto.NCOM_CHANNEL,
            SPERSIS = dto.SPERSIS,
            NUSER_RETENC = dto.NUSER_RETENC,
            DDATE_RETENC = dto.DDATE_RETENC,
            NUSER_LIBRET = dto.NUSER_LIBRET,
            DDATE_LIBRET = dto.DDATE_LIBRET,
            SCODAGENT_SCAB = dto.SCODAGENT_SCAB,
        };
    }

    public static void UpdateEntity(this INTERMEDIA entity, UpdateINTERMEDIADto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCLIENT = dto.SCLIENT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCOMTABGE = dto.NCOMTABGE;
        entity.NCOMTABLI = dto.NCOMTABLI;
        entity.DINPDATE = dto.DINPDATE;
        entity.NINT_STATUS = dto.NINT_STATUS;
        entity.NINTERTYP = dto.NINTERTYP;
        entity.NNULLCODE = dto.NNULLCODE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NOFFICE = dto.NOFFICE;
        entity.NSUPERVIS = dto.NSUPERVIS;
        entity.NTABLE_COD = dto.NTABLE_COD;
        entity.NTAX = dto.NTAX;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SCOL_AGREE = dto.SCOL_AGREE;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.NECO_SCHE = dto.NECO_SCHE;
        entity.SINTER_ID = dto.SINTER_ID;
        entity.SAGREEINT = dto.SAGREEINT;
        entity.SLIFE = dto.SLIFE;
        entity.SNONLIFE = dto.SNONLIFE;
        entity.NLIFE_SCHE = dto.NLIFE_SCHE;
        entity.NGEN_SCHE = dto.NGEN_SCHE;
        entity.NLEGAL_SCH = dto.NLEGAL_SCH;
        entity.NSUP_GEN = dto.NSUP_GEN;
        entity.NINSU_ASSIST = dto.NINSU_ASSIST;
        entity.NGOAL_GEN = dto.NGOAL_GEN;
        entity.NGOAL_LIFE = dto.NGOAL_LIFE;
        entity.NINSU_ASSISTLIF = dto.NINSU_ASSISTLIF;
        entity.NAGENCY = dto.NAGENCY;
        entity.NOFFICEAGEN = dto.NOFFICEAGEN;
        entity.NSLC_TAB_NR = dto.NSLC_TAB_NR;
        entity.DCOMMIDATE = dto.DCOMMIDATE;
        entity.SVALID = dto.SVALID;
        entity.NCONTRAT = dto.NCONTRAT;
        entity.NRECEPTYP = dto.NRECEPTYP;
        entity.NCOM_CHANNEL = dto.NCOM_CHANNEL;
        entity.SPERSIS = dto.SPERSIS;
        entity.NUSER_RETENC = dto.NUSER_RETENC;
        entity.DDATE_RETENC = dto.DDATE_RETENC;
        entity.NUSER_LIBRET = dto.NUSER_LIBRET;
        entity.DDATE_LIBRET = dto.DDATE_LIBRET;
        entity.SCODAGENT_SCAB = dto.SCODAGENT_SCAB;
    }
}
