using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE184;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE184Service : CrudService<TABLE184, TABLE184Dto, CreateTABLE184Dto, UpdateTABLE184Dto, int>, ITABLE184Service
{
    public TABLE184Service(IRepository<TABLE184> repository)
        : base(repository, TABLE184MappingExtensions.ToDto, TABLE184MappingExtensions.ToEntity, TABLE184MappingExtensions.UpdateEntity) { }
}
