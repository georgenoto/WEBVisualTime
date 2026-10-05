using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.USER_OFFICE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class USER_OFFICEMappingExtensions
{
    public static USER_OFFICEDto ToDto(this USER_OFFICE entity)
    {
        if (entity == null) return null!;
        return new USER_OFFICEDto
        {
            NUSER = entity.NUSER,
            NOFFICEAGEN = entity.NOFFICEAGEN,
            TABLE5556SDESCRIPT = entity.TABLE5556?.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static USER_OFFICE ToEntity(this CreateUSER_OFFICEDto dto)
    {
        if (dto == null) return null!;
        return new USER_OFFICE
        {
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this USER_OFFICE entity, UpdateUSER_OFFICEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
