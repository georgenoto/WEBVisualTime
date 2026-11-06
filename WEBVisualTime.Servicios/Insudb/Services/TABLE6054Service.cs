using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6054;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6054Service : CrudService<TABLE6054, TABLE6054Dto, CreateTABLE6054Dto, UpdateTABLE6054Dto, int>, ITABLE6054Service
{
    public TABLE6054Service(IRepository<TABLE6054> repository)
        : base(repository, TABLE6054MappingExtensions.ToDto, TABLE6054MappingExtensions.ToEntity, TABLE6054MappingExtensions.UpdateEntity) { }
}
