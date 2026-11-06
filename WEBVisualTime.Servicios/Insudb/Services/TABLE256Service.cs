using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE256;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE256Service : CrudService<TABLE256, TABLE256Dto, CreateTABLE256Dto, UpdateTABLE256Dto, long>, ITABLE256Service
{
    public TABLE256Service(IRepository<TABLE256> repository)
        : base(repository, TABLE256MappingExtensions.ToDto, TABLE256MappingExtensions.ToEntity, TABLE256MappingExtensions.UpdateEntity) { }
}
