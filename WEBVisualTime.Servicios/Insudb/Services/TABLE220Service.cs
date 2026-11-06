using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE220;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE220Service : CrudService<TABLE220, TABLE220Dto, CreateTABLE220Dto, UpdateTABLE220Dto, int>, ITABLE220Service
{
    public TABLE220Service(IRepository<TABLE220> repository)
        : base(repository, TABLE220MappingExtensions.ToDto, TABLE220MappingExtensions.ToEntity, TABLE220MappingExtensions.UpdateEntity) { }
}
