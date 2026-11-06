using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE182;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE182Service : CrudService<TABLE182, TABLE182Dto, CreateTABLE182Dto, UpdateTABLE182Dto, string>, ITABLE182Service
{
    public TABLE182Service(IRepository<TABLE182> repository)
        : base(repository, TABLE182MappingExtensions.ToDto, TABLE182MappingExtensions.ToEntity, TABLE182MappingExtensions.UpdateEntity) { }
}
