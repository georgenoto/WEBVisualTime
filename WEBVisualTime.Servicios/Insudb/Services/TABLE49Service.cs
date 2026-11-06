using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE49;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE49Service : CrudService<TABLE49, TABLE49Dto, CreateTABLE49Dto, UpdateTABLE49Dto, string>, ITABLE49Service
{
    public TABLE49Service(IRepository<TABLE49> repository)
        : base(repository, TABLE49MappingExtensions.ToDto, TABLE49MappingExtensions.ToEntity, TABLE49MappingExtensions.UpdateEntity) { }
}
