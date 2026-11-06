using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE124;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE124Service : CrudService<TABLE124, TABLE124Dto, CreateTABLE124Dto, UpdateTABLE124Dto, long>, ITABLE124Service
{
    public TABLE124Service(IRepository<TABLE124> repository)
        : base(repository, TABLE124MappingExtensions.ToDto, TABLE124MappingExtensions.ToEntity, TABLE124MappingExtensions.UpdateEntity) { }
}
