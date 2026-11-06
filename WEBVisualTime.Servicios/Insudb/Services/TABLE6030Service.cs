using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6030;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6030Service : CrudService<TABLE6030, TABLE6030Dto, CreateTABLE6030Dto, UpdateTABLE6030Dto, int>, ITABLE6030Service
{
    public TABLE6030Service(IRepository<TABLE6030> repository)
        : base(repository, TABLE6030MappingExtensions.ToDto, TABLE6030MappingExtensions.ToEntity, TABLE6030MappingExtensions.UpdateEntity) { }
}
