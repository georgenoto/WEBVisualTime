using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMISSION;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class COMMISSIONMappingExtensions
{
    public static COMMISSIONDto ToDto(this COMMISSION entity)
    {
        if (entity == null) return null!;
        return new COMMISSIONDto
        {
            SCERTYPE = entity.SCERTYPE,
            CERTIFICATSCERTYPESCUMUL_CODE = entity.CERTIFICATSCERTYPE?.SCUMUL_CODE,
            NBRANCH = entity.NBRANCH,
            CERTIFICATNBRANCHSCUMUL_CODE = entity.CERTIFICATNBRANCH?.SCUMUL_CODE,
            NPRODUCT = entity.NPRODUCT,
            CERTIFICATNPRODUCTSCUMUL_CODE = entity.CERTIFICATNPRODUCT?.SCUMUL_CODE,
            NPOLICY = entity.NPOLICY,
            CERTIFICATNPOLICYSCUMUL_CODE = entity.CERTIFICATNPOLICY?.SCUMUL_CODE,
            NINTERTYP = entity.NINTERTYP,
            INTERM_TYPSDESCRIPT = entity.INTERM_TYP?.SDESCRIPT,
            NINTERMED = entity.NINTERMED,
            INTERMEDIASCOL_AGREE = entity.INTERMEDIA?.SCOL_AGREE,
            DEFFECDATE = entity.DEFFECDATE,
            NAMOUNT = entity.NAMOUNT,
            SCOMMITYP = entity.SCOMMITYP,
            TABLE47SDESCRIPT = entity.TABLE47?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            DNULLDATE = entity.DNULLDATE,
            NPERCENT = entity.NPERCENT,
            NSHARE = entity.NSHARE,
            NUSERCODE = entity.NUSERCODE,
            NPERDISCOUNT = entity.NPERDISCOUNT,
            SPLUSCOLLEC = entity.SPLUSCOLLEC,
            SPLUSOFFICE = entity.SPLUSOFFICE,
            SPLUSQUALITY = entity.SPLUSQUALITY,
            NAGREEMENT = entity.NAGREEMENT,
            NPERCENT_CE = entity.NPERCENT_CE,
            NCERTIF = entity.NCERTIF,
            CERTIFICATNCERTIFSCUMUL_CODE = entity.CERTIFICATNCERTIF?.SCUMUL_CODE,
            NINSTALLCOM = entity.NINSTALLCOM,
            NCATEGORY = entity.NCATEGORY,
            NID_CAMPAIGN = entity.NID_CAMPAIGN,
            DDATEEND_CAMP = entity.DDATEEND_CAMP,
            NMOVEMENT = entity.NMOVEMENT,
            NMOVEMENT_NULL = entity.NMOVEMENT_NULL,
        };
    }

    public static COMMISSION ToEntity(this CreateCOMMISSIONDto dto)
    {
        if (dto == null) return null!;
        return new COMMISSION
        {
            NAMOUNT = dto.NAMOUNT,
            SCOMMITYP = dto.SCOMMITYP,
            DCOMPDATE = dto.DCOMPDATE,
            DNULLDATE = dto.DNULLDATE,
            NPERCENT = dto.NPERCENT,
            NSHARE = dto.NSHARE,
            NUSERCODE = dto.NUSERCODE,
            NPERDISCOUNT = dto.NPERDISCOUNT,
            SPLUSCOLLEC = dto.SPLUSCOLLEC,
            SPLUSOFFICE = dto.SPLUSOFFICE,
            SPLUSQUALITY = dto.SPLUSQUALITY,
            NAGREEMENT = dto.NAGREEMENT,
            NPERCENT_CE = dto.NPERCENT_CE,
            NINSTALLCOM = dto.NINSTALLCOM,
            NCATEGORY = dto.NCATEGORY,
            NID_CAMPAIGN = dto.NID_CAMPAIGN,
            DDATEEND_CAMP = dto.DDATEEND_CAMP,
            NMOVEMENT = dto.NMOVEMENT,
            NMOVEMENT_NULL = dto.NMOVEMENT_NULL,
        };
    }

    public static void UpdateEntity(this COMMISSION entity, UpdateCOMMISSIONDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.SCOMMITYP = dto.SCOMMITYP;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NPERCENT = dto.NPERCENT;
        entity.NSHARE = dto.NSHARE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NPERDISCOUNT = dto.NPERDISCOUNT;
        entity.SPLUSCOLLEC = dto.SPLUSCOLLEC;
        entity.SPLUSOFFICE = dto.SPLUSOFFICE;
        entity.SPLUSQUALITY = dto.SPLUSQUALITY;
        entity.NAGREEMENT = dto.NAGREEMENT;
        entity.NPERCENT_CE = dto.NPERCENT_CE;
        entity.NINSTALLCOM = dto.NINSTALLCOM;
        entity.NCATEGORY = dto.NCATEGORY;
        entity.NID_CAMPAIGN = dto.NID_CAMPAIGN;
        entity.DDATEEND_CAMP = dto.DDATEEND_CAMP;
        entity.NMOVEMENT = dto.NMOVEMENT;
        entity.NMOVEMENT_NULL = dto.NMOVEMENT_NULL;
    }
}
