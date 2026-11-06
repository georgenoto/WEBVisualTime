using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7501;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7501Service : CrudService<TABLE7501, TABLE7501Dto, CreateTABLE7501Dto, UpdateTABLE7501Dto, long>, ITABLE7501Service
{
    public TABLE7501Service(IRepository<TABLE7501> repository)
        : base(repository, TABLE7501MappingExtensions.ToDto, TABLE7501MappingExtensions.ToEntity, TABLE7501MappingExtensions.UpdateEntity) { }
}
