using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE304;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE304Service : CrudService<TABLE304, TABLE304Dto, CreateTABLE304Dto, UpdateTABLE304Dto, long>, ITABLE304Service
{
    public TABLE304Service(IRepository<TABLE304> repository)
        : base(repository, TABLE304MappingExtensions.ToDto, TABLE304MappingExtensions.ToEntity, TABLE304MappingExtensions.UpdateEntity) { }
}
