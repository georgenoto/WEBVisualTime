using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE416;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE416Service : CrudService<TABLE416, TABLE416Dto, CreateTABLE416Dto, UpdateTABLE416Dto, long>, ITABLE416Service
{
    public TABLE416Service(IRepository<TABLE416> repository)
        : base(repository, TABLE416MappingExtensions.ToDto, TABLE416MappingExtensions.ToEntity, TABLE416MappingExtensions.UpdateEntity) { }
}
