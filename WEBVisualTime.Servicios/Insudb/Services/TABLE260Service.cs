using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE260;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE260Service : CrudService<TABLE260, TABLE260Dto, CreateTABLE260Dto, UpdateTABLE260Dto, long>, ITABLE260Service
{
    public TABLE260Service(IRepository<TABLE260> repository)
        : base(repository, TABLE260MappingExtensions.ToDto, TABLE260MappingExtensions.ToEntity, TABLE260MappingExtensions.UpdateEntity) { }
}
