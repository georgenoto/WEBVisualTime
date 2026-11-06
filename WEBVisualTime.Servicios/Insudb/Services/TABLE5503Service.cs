using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5503;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5503Service : CrudService<TABLE5503, TABLE5503Dto, CreateTABLE5503Dto, UpdateTABLE5503Dto, long>, ITABLE5503Service
{
    public TABLE5503Service(IRepository<TABLE5503> repository)
        : base(repository, TABLE5503MappingExtensions.ToDto, TABLE5503MappingExtensions.ToEntity, TABLE5503MappingExtensions.UpdateEntity) { }
}
