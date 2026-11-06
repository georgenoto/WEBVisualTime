using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE92;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE92Service : CrudService<TABLE92, TABLE92Dto, CreateTABLE92Dto, UpdateTABLE92Dto, string>, ITABLE92Service
{
    public TABLE92Service(IRepository<TABLE92> repository)
        : base(repository, TABLE92MappingExtensions.ToDto, TABLE92MappingExtensions.ToEntity, TABLE92MappingExtensions.UpdateEntity) { }
}
