using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5651;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5651Service : CrudService<TABLE5651, TABLE5651Dto, CreateTABLE5651Dto, UpdateTABLE5651Dto, int>, ITABLE5651Service
{
    public TABLE5651Service(IRepository<TABLE5651> repository)
        : base(repository, TABLE5651MappingExtensions.ToDto, TABLE5651MappingExtensions.ToEntity, TABLE5651MappingExtensions.UpdateEntity) { }
}
