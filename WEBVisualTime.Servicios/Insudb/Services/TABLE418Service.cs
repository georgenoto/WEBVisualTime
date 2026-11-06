using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE418;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE418Service : CrudService<TABLE418, TABLE418Dto, CreateTABLE418Dto, UpdateTABLE418Dto, long>, ITABLE418Service
{
    public TABLE418Service(IRepository<TABLE418> repository)
        : base(repository, TABLE418MappingExtensions.ToDto, TABLE418MappingExtensions.ToEntity, TABLE418MappingExtensions.UpdateEntity) { }
}
