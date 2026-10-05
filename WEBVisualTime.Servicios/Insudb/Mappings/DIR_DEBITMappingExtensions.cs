using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DIR_DEBIT;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class DIR_DEBITMappingExtensions
{
    public static DIR_DEBITDto ToDto(this DIR_DEBIT entity)
    {
        if (entity == null) return null!;
        return new DIR_DEBITDto
        {
            SCERTYPE = entity.SCERTYPE,
            CERTIFICATSCERTYPESCUMUL_CODE = entity.CERTIFICATSCERTYPE?.SCUMUL_CODE,
            NBRANCH = entity.NBRANCH,
            CERTIFICATNBRANCHSCUMUL_CODE = entity.CERTIFICATNBRANCH?.SCUMUL_CODE,
            NPRODUCT = entity.NPRODUCT,
            CERTIFICATNPRODUCTSCUMUL_CODE = entity.CERTIFICATNPRODUCT?.SCUMUL_CODE,
            NPOLICY = entity.NPOLICY,
            CERTIFICATNPOLICYSCUMUL_CODE = entity.CERTIFICATNPOLICY?.SCUMUL_CODE,
            NCERTIF = entity.NCERTIF,
            CERTIFICATNCERTIFSCUMUL_CODE = entity.CERTIFICATNCERTIF?.SCUMUL_CODE,
            DEFFECDATE = entity.DEFFECDATE,
            SACCOUNT = entity.SACCOUNT,
            NBANKEXT = entity.NBANKEXT,
            TABLE7SDESCRIPT = entity.TABLE7?.SDESCRIPT,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            DNULLDATE = entity.DNULLDATE,
            SCREDI_CARD = entity.SCREDI_CARD,
            NTYP_CRECARD = entity.NTYP_CRECARD,
            TABLE183SDESCRIPT = entity.TABLE183?.SDESCRIPT,
            STYP_DIRDEB = entity.STYP_DIRDEB,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            DCARDEXPIR = entity.DCARDEXPIR,
            SBANKAUTH = entity.SBANKAUTH,
            SREUSE = entity.SREUSE,
            NTYP_ACC = entity.NTYP_ACC,
            NSTATUS_BANKAUTH = entity.NSTATUS_BANKAUTH,
            NIDCOLLECT = entity.NIDCOLLECT,
            NBILL_DAYINI = entity.NBILL_DAYINI,
            DBANKAUTH = entity.DBANKAUTH,
            SDEBIT_CARD = entity.SDEBIT_CARD,
            NBILL_DAYEND = entity.NBILL_DAYEND,
        };
    }

    public static DIR_DEBIT ToEntity(this CreateDIR_DEBITDto dto)
    {
        if (dto == null) return null!;
        return new DIR_DEBIT
        {
            SACCOUNT = dto.SACCOUNT,
            NBANKEXT = dto.NBANKEXT,
            SCLIENT = dto.SCLIENT,
            DNULLDATE = dto.DNULLDATE,
            SCREDI_CARD = dto.SCREDI_CARD,
            NTYP_CRECARD = dto.NTYP_CRECARD,
            STYP_DIRDEB = dto.STYP_DIRDEB,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            DCARDEXPIR = dto.DCARDEXPIR,
            SBANKAUTH = dto.SBANKAUTH,
            SREUSE = dto.SREUSE,
            NTYP_ACC = dto.NTYP_ACC,
            NSTATUS_BANKAUTH = dto.NSTATUS_BANKAUTH,
            NIDCOLLECT = dto.NIDCOLLECT,
            NBILL_DAYINI = dto.NBILL_DAYINI,
            DBANKAUTH = dto.DBANKAUTH,
            SDEBIT_CARD = dto.SDEBIT_CARD,
            NBILL_DAYEND = dto.NBILL_DAYEND,
        };
    }

    public static void UpdateEntity(this DIR_DEBIT entity, UpdateDIR_DEBITDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SACCOUNT = dto.SACCOUNT;
        entity.NBANKEXT = dto.NBANKEXT;
        entity.SCLIENT = dto.SCLIENT;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.SCREDI_CARD = dto.SCREDI_CARD;
        entity.NTYP_CRECARD = dto.NTYP_CRECARD;
        entity.STYP_DIRDEB = dto.STYP_DIRDEB;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCARDEXPIR = dto.DCARDEXPIR;
        entity.SBANKAUTH = dto.SBANKAUTH;
        entity.SREUSE = dto.SREUSE;
        entity.NTYP_ACC = dto.NTYP_ACC;
        entity.NSTATUS_BANKAUTH = dto.NSTATUS_BANKAUTH;
        entity.NIDCOLLECT = dto.NIDCOLLECT;
        entity.NBILL_DAYINI = dto.NBILL_DAYINI;
        entity.DBANKAUTH = dto.DBANKAUTH;
        entity.SDEBIT_CARD = dto.SDEBIT_CARD;
        entity.NBILL_DAYEND = dto.NBILL_DAYEND;
    }
}
