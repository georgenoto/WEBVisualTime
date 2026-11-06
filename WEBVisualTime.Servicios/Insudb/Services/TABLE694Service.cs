using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE694;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE694Service : CrudService<TABLE694, TABLE694Dto, CreateTABLE694Dto, UpdateTABLE694Dto, int>, ITABLE694Service
{
    public TABLE694Service(IRepository<TABLE694> repository)
        : base(repository, TABLE694MappingExtensions.ToDto, TABLE694MappingExtensions.ToEntity, TABLE694MappingExtensions.UpdateEntity) { }
}
