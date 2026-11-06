using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE245;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE245Service : CrudService<TABLE245, TABLE245Dto, CreateTABLE245Dto, UpdateTABLE245Dto, long>, ITABLE245Service
{
    public TABLE245Service(IRepository<TABLE245> repository)
        : base(repository, TABLE245MappingExtensions.ToDto, TABLE245MappingExtensions.ToEntity, TABLE245MappingExtensions.UpdateEntity) { }
}
