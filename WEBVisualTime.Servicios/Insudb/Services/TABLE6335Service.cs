using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6335;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6335Service : CrudService<TABLE6335, TABLE6335Dto, CreateTABLE6335Dto, UpdateTABLE6335Dto, int>, ITABLE6335Service
{
    public TABLE6335Service(IRepository<TABLE6335> repository)
        : base(repository, TABLE6335MappingExtensions.ToDto, TABLE6335MappingExtensions.ToEntity, TABLE6335MappingExtensions.UpdateEntity) { }
}
