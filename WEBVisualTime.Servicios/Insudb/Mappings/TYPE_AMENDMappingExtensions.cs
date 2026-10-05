using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TYPE_AMEND;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TYPE_AMENDMappingExtensions
{
    public static TYPE_AMENDDto ToDto(this TYPE_AMEND entity)
    {
        if (entity == null) return null!;
        return new TYPE_AMENDDto
        {
            NBRANCH = entity.NBRANCH,
            TABLE10SDESCRIPT = entity.TABLE10?.SDESCRIPT,
            NPRODUCT = entity.NPRODUCT,
            NTYPE_AMEND = entity.NTYPE_AMEND,
            TABLE6059SDESCRIPT = entity.TABLE6059?.SDESCRIPT,
            DEFFECDATE = entity.DEFFECDATE,
            DNULLDATE = entity.DNULLDATE,
            SIND_ORDER_SERV = entity.SIND_ORDER_SERV,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            NTYPEISSUE = entity.NTYPEISSUE,
            TABLE5569SDESCRIPT = entity.TABLE5569?.SDESCRIPT,
            NLEVEL = entity.NLEVEL,
            SRETARIF = entity.SRETARIF,
            SDESCRIPT = entity.SDESCRIPT,
            NTYPE_EV_ENDOR = entity.NTYPE_EV_ENDOR,
            TABLE9232SDESCRIPT = entity.TABLE9232?.SDESCRIPT,
            SRESOLUTION = entity.SRESOLUTION,
            SGOVAPRNAME = entity.SGOVAPRNAME,
            DRESDATE = entity.DRESDATE,
            SCONDSVS = entity.SCONDSVS,
            NTYPEA_AMEND = entity.NTYPEA_AMEND,
            SSHOWSTATUS = entity.SSHOWSTATUS,
        };
    }

    public static TYPE_AMEND ToEntity(this CreateTYPE_AMENDDto dto)
    {
        if (dto == null) return null!;
        return new TYPE_AMEND
        {
            DNULLDATE = dto.DNULLDATE,
            SIND_ORDER_SERV = dto.SIND_ORDER_SERV,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NTYPEISSUE = dto.NTYPEISSUE,
            NLEVEL = dto.NLEVEL,
            SRETARIF = dto.SRETARIF,
            SDESCRIPT = dto.SDESCRIPT,
            NTYPE_EV_ENDOR = dto.NTYPE_EV_ENDOR,
            SRESOLUTION = dto.SRESOLUTION,
            SGOVAPRNAME = dto.SGOVAPRNAME,
            DRESDATE = dto.DRESDATE,
            SCONDSVS = dto.SCONDSVS,
            NTYPEA_AMEND = dto.NTYPEA_AMEND,
            SSHOWSTATUS = dto.SSHOWSTATUS,
        };
    }

    public static void UpdateEntity(this TYPE_AMEND entity, UpdateTYPE_AMENDDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.SIND_ORDER_SERV = dto.SIND_ORDER_SERV;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NTYPEISSUE = dto.NTYPEISSUE;
        entity.NLEVEL = dto.NLEVEL;
        entity.SRETARIF = dto.SRETARIF;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NTYPE_EV_ENDOR = dto.NTYPE_EV_ENDOR;
        entity.SRESOLUTION = dto.SRESOLUTION;
        entity.SGOVAPRNAME = dto.SGOVAPRNAME;
        entity.DRESDATE = dto.DRESDATE;
        entity.SCONDSVS = dto.SCONDSVS;
        entity.NTYPEA_AMEND = dto.NTYPEA_AMEND;
        entity.SSHOWSTATUS = dto.SSHOWSTATUS;
    }
}
