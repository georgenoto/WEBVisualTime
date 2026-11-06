using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6002;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6002Service : CrudService<TABLE6002, TABLE6002Dto, CreateTABLE6002Dto, UpdateTABLE6002Dto, int>, ITABLE6002Service
{
    public TABLE6002Service(IRepository<TABLE6002> repository)
        : base(repository, TABLE6002MappingExtensions.ToDto, TABLE6002MappingExtensions.ToEntity, TABLE6002MappingExtensions.UpdateEntity) { }
}
