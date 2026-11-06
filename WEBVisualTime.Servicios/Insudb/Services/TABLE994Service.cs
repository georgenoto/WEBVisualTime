using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE994;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE994Service : CrudService<TABLE994, TABLE994Dto, CreateTABLE994Dto, UpdateTABLE994Dto, int>, ITABLE994Service
{
    public TABLE994Service(IRepository<TABLE994> repository)
        : base(repository, TABLE994MappingExtensions.ToDto, TABLE994MappingExtensions.ToEntity, TABLE994MappingExtensions.UpdateEntity) { }
}
