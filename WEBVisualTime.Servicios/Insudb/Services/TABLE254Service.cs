using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE254;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE254Service : CrudService<TABLE254, TABLE254Dto, CreateTABLE254Dto, UpdateTABLE254Dto, long>, ITABLE254Service
{
    public TABLE254Service(IRepository<TABLE254> repository)
        : base(repository, TABLE254MappingExtensions.ToDto, TABLE254MappingExtensions.ToEntity, TABLE254MappingExtensions.UpdateEntity) { }
}
