using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE251;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE251Service : CrudService<TABLE251, TABLE251Dto, CreateTABLE251Dto, UpdateTABLE251Dto, long>, ITABLE251Service
{
    public TABLE251Service(IRepository<TABLE251> repository)
        : base(repository, TABLE251MappingExtensions.ToDto, TABLE251MappingExtensions.ToEntity, TABLE251MappingExtensions.UpdateEntity) { }
}
