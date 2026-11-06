using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6003;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6003Service : CrudService<TABLE6003, TABLE6003Dto, CreateTABLE6003Dto, UpdateTABLE6003Dto, int>, ITABLE6003Service
{
    public TABLE6003Service(IRepository<TABLE6003> repository)
        : base(repository, TABLE6003MappingExtensions.ToDto, TABLE6003MappingExtensions.ToEntity, TABLE6003MappingExtensions.UpdateEntity) { }
}
