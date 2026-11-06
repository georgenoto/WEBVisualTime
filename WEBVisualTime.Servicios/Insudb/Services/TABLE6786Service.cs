using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6786;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6786Service : CrudService<TABLE6786, TABLE6786Dto, CreateTABLE6786Dto, UpdateTABLE6786Dto, int>, ITABLE6786Service
{
    public TABLE6786Service(IRepository<TABLE6786> repository)
        : base(repository, TABLE6786MappingExtensions.ToDto, TABLE6786MappingExtensions.ToEntity, TABLE6786MappingExtensions.UpdateEntity) { }
}
