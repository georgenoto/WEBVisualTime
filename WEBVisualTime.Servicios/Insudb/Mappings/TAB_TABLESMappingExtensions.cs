using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_TABLES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_TABLESMappingExtensions
{
    public static TAB_TABLESDto ToDto(this TAB_TABLES entity)
    {
        if (entity == null) return null!;
        return new TAB_TABLESDto
        {
            STAB_CODE = entity.STAB_CODE,
            NCOUNT_ITEM = entity.NCOUNT_ITEM,
            SCODE_ITEM = entity.SCODE_ITEM,
            SDESC_ITEM = entity.SDESC_ITEM,
            NCOUNT_TABL = entity.NCOUNT_TABL,
            SDESCRIPT = entity.SDESCRIPT,
            SDS_SELECT = entity.SDS_SELECT,
            SQ_VALUE = entity.SQ_VALUE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SSHOWNUM = entity.SSHOWNUM,
            SINITQUERY = entity.SINITQUERY,
            SINDSP = entity.SINDSP,
            SKEY = entity.SKEY,
        };
    }

    public static TAB_TABLES ToEntity(this CreateTAB_TABLESDto dto)
    {
        if (dto == null) return null!;
        return new TAB_TABLES
        {
            NCOUNT_ITEM = dto.NCOUNT_ITEM,
            SCODE_ITEM = dto.SCODE_ITEM,
            SDESC_ITEM = dto.SDESC_ITEM,
            NCOUNT_TABL = dto.NCOUNT_TABL,
            SDESCRIPT = dto.SDESCRIPT,
            SDS_SELECT = dto.SDS_SELECT,
            SQ_VALUE = dto.SQ_VALUE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SSHOWNUM = dto.SSHOWNUM,
            SINITQUERY = dto.SINITQUERY,
            SINDSP = dto.SINDSP,
            SKEY = dto.SKEY,
        };
    }

    public static void UpdateEntity(this TAB_TABLES entity, UpdateTAB_TABLESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCOUNT_ITEM = dto.NCOUNT_ITEM;
        entity.SCODE_ITEM = dto.SCODE_ITEM;
        entity.SDESC_ITEM = dto.SDESC_ITEM;
        entity.NCOUNT_TABL = dto.NCOUNT_TABL;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SDS_SELECT = dto.SDS_SELECT;
        entity.SQ_VALUE = dto.SQ_VALUE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSHOWNUM = dto.SSHOWNUM;
        entity.SINITQUERY = dto.SINITQUERY;
        entity.SINDSP = dto.SINDSP;
        entity.SKEY = dto.SKEY;
    }
}
