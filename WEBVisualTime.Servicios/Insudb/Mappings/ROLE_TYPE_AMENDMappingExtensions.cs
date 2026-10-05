using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ROLE_TYPE_AMEND;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class ROLE_TYPE_AMENDMappingExtensions
{
    public static ROLE_TYPE_AMENDDto ToDto(this ROLE_TYPE_AMEND entity)
    {
        if (entity == null) return null!;
        return new ROLE_TYPE_AMENDDto
        {
            NBRANCH = entity.NBRANCH,
            TYPE_AMENDNBRANCHSIND_ORDER_SERV = entity.TYPE_AMENDNBRANCH?.SIND_ORDER_SERV,
            NPRODUCT = entity.NPRODUCT,
            TYPE_AMENDNPRODUCTSIND_ORDER_SERV = entity.TYPE_AMENDNPRODUCT?.SIND_ORDER_SERV,
            DEFFECDATE = entity.DEFFECDATE,
            TYPE_AMENDDEFFECDATESIND_ORDER_SERV = entity.TYPE_AMENDDEFFECDATE?.SIND_ORDER_SERV,
            NTYPE_AMEND = entity.NTYPE_AMEND,
            TYPE_AMENDNTYPE_AMENDSIND_ORDER_SERV = entity.TYPE_AMENDNTYPE_AMEND?.SIND_ORDER_SERV,
            NROLEID = entity.NROLEID,
        };
    }

    public static ROLE_TYPE_AMEND ToEntity(this CreateROLE_TYPE_AMENDDto dto)
    {
        if (dto == null) return null!;
        return new ROLE_TYPE_AMEND
        {
        };
    }

    public static void UpdateEntity(this ROLE_TYPE_AMEND entity, UpdateROLE_TYPE_AMENDDto dto)
    {
        if (entity == null || dto == null) return;
    }
}
