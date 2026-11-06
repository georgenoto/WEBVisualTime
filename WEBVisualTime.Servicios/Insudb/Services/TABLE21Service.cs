using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE21;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE21Service : CrudService<TABLE21, TABLE21Dto, CreateTABLE21Dto, UpdateTABLE21Dto, long>, ITABLE21Service
{
    public TABLE21Service(IRepository<TABLE21> repository)
        : base(repository, TABLE21MappingExtensions.ToDto, TABLE21MappingExtensions.ToEntity, TABLE21MappingExtensions.UpdateEntity) { }
}
