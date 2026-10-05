using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_AUXILIAR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_AUXILIARMappingExtensions
{
    public static TAB_AUXILIARDto ToDto(this TAB_AUXILIAR entity)
    {
        if (entity == null) return null!;
        return new TAB_AUXILIARDto
        {
            CARACTER = entity.CARACTER,
            NUMERO = entity.NUMERO,
            FECHA = entity.FECHA,
        };
    }

    public static TAB_AUXILIAR ToEntity(this CreateTAB_AUXILIARDto dto)
    {
        if (dto == null) return null!;
        return new TAB_AUXILIAR
        {
            CARACTER = dto.CARACTER,
            NUMERO = dto.NUMERO,
            FECHA = dto.FECHA,
        };
    }

    public static void UpdateEntity(this TAB_AUXILIAR entity, UpdateTAB_AUXILIARDto dto)
    {
        if (entity == null || dto == null) return;
        entity.CARACTER = dto.CARACTER;
        entity.NUMERO = dto.NUMERO;
        entity.FECHA = dto.FECHA;
    }
}
