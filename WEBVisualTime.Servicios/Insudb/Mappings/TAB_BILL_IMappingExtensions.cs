using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_BILL_I;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_BILL_IMappingExtensions
{
    public static TAB_BILL_IDto ToDto(this TAB_BILL_I entity)
    {
        if (entity == null) return null!;
        return new TAB_BILL_IDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NBILL_ITEM = entity.NBILL_ITEM,
            DEFFECDATE = entity.DEFFECDATE,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            DNULLDATE = entity.DNULLDATE,
            SSHORT_DES = entity.SSHORT_DES,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TAB_BILL_I ToEntity(this CreateTAB_BILL_IDto dto)
    {
        if (dto == null) return null!;
        return new TAB_BILL_I
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            DNULLDATE = dto.DNULLDATE,
            SSHORT_DES = dto.SSHORT_DES,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TAB_BILL_I entity, UpdateTAB_BILL_IDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
