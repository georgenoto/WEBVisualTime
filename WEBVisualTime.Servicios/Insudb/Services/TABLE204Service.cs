using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE204;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE204Service : CrudService<TABLE204, TABLE204Dto, CreateTABLE204Dto, UpdateTABLE204Dto, int>, ITABLE204Service
{
    public TABLE204Service(IRepository<TABLE204> repository)
        : base(repository, TABLE204MappingExtensions.ToDto, TABLE204MappingExtensions.ToEntity, TABLE204MappingExtensions.UpdateEntity) { }
}
