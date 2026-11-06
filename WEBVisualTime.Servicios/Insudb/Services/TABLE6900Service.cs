using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6900;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6900Service : CrudService<TABLE6900, TABLE6900Dto, CreateTABLE6900Dto, UpdateTABLE6900Dto, int>, ITABLE6900Service
{
    public TABLE6900Service(IRepository<TABLE6900> repository)
        : base(repository, TABLE6900MappingExtensions.ToDto, TABLE6900MappingExtensions.ToEntity, TABLE6900MappingExtensions.UpdateEntity) { }
}
