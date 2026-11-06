using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6Service : CrudService<TABLE6, TABLE6Dto, CreateTABLE6Dto, UpdateTABLE6Dto, int>, ITABLE6Service
{
    public TABLE6Service(IRepository<TABLE6> repository)
        : base(repository, TABLE6MappingExtensions.ToDto, TABLE6MappingExtensions.ToEntity, TABLE6MappingExtensions.UpdateEntity) { }
}
