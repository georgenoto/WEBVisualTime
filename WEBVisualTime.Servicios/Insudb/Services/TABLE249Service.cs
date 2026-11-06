using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE249;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE249Service : CrudService<TABLE249, TABLE249Dto, CreateTABLE249Dto, UpdateTABLE249Dto, long>, ITABLE249Service
{
    public TABLE249Service(IRepository<TABLE249> repository)
        : base(repository, TABLE249MappingExtensions.ToDto, TABLE249MappingExtensions.ToEntity, TABLE249MappingExtensions.UpdateEntity) { }
}
