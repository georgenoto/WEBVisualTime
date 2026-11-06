using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6059;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE6059Service : CrudService<TABLE6059, TABLE6059Dto, CreateTABLE6059Dto, UpdateTABLE6059Dto, int>, ITABLE6059Service
{
    public TABLE6059Service(IRepository<TABLE6059> repository)
        : base(repository, TABLE6059MappingExtensions.ToDto, TABLE6059MappingExtensions.ToEntity, TABLE6059MappingExtensions.UpdateEntity) { }
}
