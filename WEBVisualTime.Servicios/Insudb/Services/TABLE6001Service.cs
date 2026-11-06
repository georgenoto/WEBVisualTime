using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6001;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6001Service : CrudService<TABLE6001, TABLE6001Dto, CreateTABLE6001Dto, UpdateTABLE6001Dto, int>, ITABLE6001Service
{
    public TABLE6001Service(IRepository<TABLE6001> repository)
        : base(repository, TABLE6001MappingExtensions.ToDto, TABLE6001MappingExtensions.ToEntity, TABLE6001MappingExtensions.UpdateEntity) { }
}
