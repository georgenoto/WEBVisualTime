using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.NOTIFICA_ERP;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class NOTIFICA_ERPMappingExtensions
{
    public static NOTIFICA_ERPDto ToDto(this NOTIFICA_ERP entity)
    {
        if (entity == null) return null!;
        return new NOTIFICA_ERPDto
        {
            SPROCESO = entity.SPROCESO,
            SKEY = entity.SKEY,
            SESTADO = entity.SESTADO,
            DFECHA_PROCESO = entity.DFECHA_PROCESO,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            DOPERDATE = entity.DOPERDATE,
        };
    }

    public static NOTIFICA_ERP ToEntity(this CreateNOTIFICA_ERPDto dto)
    {
        if (dto == null) return null!;
        return new NOTIFICA_ERP
        {
            SPROCESO = dto.SPROCESO,
            SESTADO = dto.SESTADO,
            DFECHA_PROCESO = dto.DFECHA_PROCESO,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            DOPERDATE = dto.DOPERDATE,
        };
    }

    public static void UpdateEntity(this NOTIFICA_ERP entity, UpdateNOTIFICA_ERPDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SPROCESO = dto.SPROCESO;
        entity.SESTADO = dto.SESTADO;
        entity.DFECHA_PROCESO = dto.DFECHA_PROCESO;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DOPERDATE = dto.DOPERDATE;
    }
}
