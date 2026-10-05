using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.AGREEMENT;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class AGREEMENTMappingExtensions
{
    public static AGREEMENTDto ToDto(this AGREEMENT entity)
    {
        if (entity == null) return null!;
        return new AGREEMENTDto
        {
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NCOD_AGREE = entity.NCOD_AGREE,
            NQ_DRAFT = entity.NQ_DRAFT,
            NMAX_PERC_DCTO = entity.NMAX_PERC_DCTO,
            DINIT_DATE = entity.DINIT_DATE,
            DEND_DATE = entity.DEND_DATE,
            DCOMPDATE = entity.DCOMPDATE,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            NTYPEAGREE = entity.NTYPEAGREE,
            TABLE5529SDESCRIPT = entity.TABLE5529?.SDESCRIPT,
            NTYPE_REC = entity.NTYPE_REC,
            TABLE5581SDESCRIPT = entity.TABLE5581?.SDESCRIPT,
            NINTERMED = entity.NINTERMED,
            INTERMEDIASCOL_AGREE = entity.INTERMEDIA?.SCOL_AGREE,
            NAGENCY = entity.NAGENCY,
            TABLE5555SDESCRIPT = entity.TABLE5555?.SDESCRIPT,
            SEMAIL_CONTACT = entity.SEMAIL_CONTACT,
            SPHONE_CONTACT = entity.SPHONE_CONTACT,
            SCLIENAME = entity.SCLIENAME,
            SFIRSTNAME = entity.SFIRSTNAME,
            SLASTNAME = entity.SLASTNAME,
            NPOSITION = entity.NPOSITION,
            SEMAILA_CONTACT = entity.SEMAILA_CONTACT,
            SPHONEA_CONTACT = entity.SPHONEA_CONTACT,
            SPHONEFAX = entity.SPHONEFAX,
            SNAME_AGREE = entity.SNAME_AGREE,
            SNOCOLLECTION = entity.SNOCOLLECTION,
            NIMAGENUM = entity.NIMAGENUM,
            NPROV_GROUP = entity.NPROV_GROUP,
            NPROVIDER = entity.NPROVIDER,
        };
    }

    public static AGREEMENT ToEntity(this CreateAGREEMENTDto dto)
    {
        if (dto == null) return null!;
        return new AGREEMENT
        {
            SCLIENT = dto.SCLIENT,
            NQ_DRAFT = dto.NQ_DRAFT,
            NMAX_PERC_DCTO = dto.NMAX_PERC_DCTO,
            DINIT_DATE = dto.DINIT_DATE,
            DEND_DATE = dto.DEND_DATE,
            DCOMPDATE = dto.DCOMPDATE,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            NTYPEAGREE = dto.NTYPEAGREE,
            NTYPE_REC = dto.NTYPE_REC,
            NINTERMED = dto.NINTERMED,
            NAGENCY = dto.NAGENCY,
            SEMAIL_CONTACT = dto.SEMAIL_CONTACT,
            SPHONE_CONTACT = dto.SPHONE_CONTACT,
            SCLIENAME = dto.SCLIENAME,
            SFIRSTNAME = dto.SFIRSTNAME,
            SLASTNAME = dto.SLASTNAME,
            NPOSITION = dto.NPOSITION,
            SEMAILA_CONTACT = dto.SEMAILA_CONTACT,
            SPHONEA_CONTACT = dto.SPHONEA_CONTACT,
            SPHONEFAX = dto.SPHONEFAX,
            SNAME_AGREE = dto.SNAME_AGREE,
            SNOCOLLECTION = dto.SNOCOLLECTION,
            NIMAGENUM = dto.NIMAGENUM,
            NPROV_GROUP = dto.NPROV_GROUP,
            NPROVIDER = dto.NPROVIDER,
        };
    }

    public static void UpdateEntity(this AGREEMENT entity, UpdateAGREEMENTDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCLIENT = dto.SCLIENT;
        entity.NQ_DRAFT = dto.NQ_DRAFT;
        entity.NMAX_PERC_DCTO = dto.NMAX_PERC_DCTO;
        entity.DINIT_DATE = dto.DINIT_DATE;
        entity.DEND_DATE = dto.DEND_DATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NTYPEAGREE = dto.NTYPEAGREE;
        entity.NTYPE_REC = dto.NTYPE_REC;
        entity.NINTERMED = dto.NINTERMED;
        entity.NAGENCY = dto.NAGENCY;
        entity.SEMAIL_CONTACT = dto.SEMAIL_CONTACT;
        entity.SPHONE_CONTACT = dto.SPHONE_CONTACT;
        entity.SCLIENAME = dto.SCLIENAME;
        entity.SFIRSTNAME = dto.SFIRSTNAME;
        entity.SLASTNAME = dto.SLASTNAME;
        entity.NPOSITION = dto.NPOSITION;
        entity.SEMAILA_CONTACT = dto.SEMAILA_CONTACT;
        entity.SPHONEA_CONTACT = dto.SPHONEA_CONTACT;
        entity.SPHONEFAX = dto.SPHONEFAX;
        entity.SNAME_AGREE = dto.SNAME_AGREE;
        entity.SNOCOLLECTION = dto.SNOCOLLECTION;
        entity.NIMAGENUM = dto.NIMAGENUM;
        entity.NPROV_GROUP = dto.NPROV_GROUP;
        entity.NPROVIDER = dto.NPROVIDER;
    }
}
