using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6072;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6072Service : CrudService<TABLE6072, TABLE6072Dto, CreateTABLE6072Dto, UpdateTABLE6072Dto, int>, ITABLE6072Service
{
    public TABLE6072Service(IRepository<TABLE6072> repository)
        : base(repository, TABLE6072MappingExtensions.ToDto, TABLE6072MappingExtensions.ToEntity, TABLE6072MappingExtensions.UpdateEntity) { }
}
