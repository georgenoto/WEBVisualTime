using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE66;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE66Service : CrudService<TABLE66, TABLE66Dto, CreateTABLE66Dto, UpdateTABLE66Dto, int>, ITABLE66Service
{
    public TABLE66Service(IRepository<TABLE66> repository)
        : base(repository, TABLE66MappingExtensions.ToDto, TABLE66MappingExtensions.ToEntity, TABLE66MappingExtensions.UpdateEntity) { }
}
