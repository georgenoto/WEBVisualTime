using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9244;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9244Service : CrudService<TABLE9244, TABLE9244Dto, CreateTABLE9244Dto, UpdateTABLE9244Dto, int>, ITABLE9244Service
{
    public TABLE9244Service(IRepository<TABLE9244> repository)
        : base(repository, TABLE9244MappingExtensions.ToDto, TABLE9244MappingExtensions.ToEntity, TABLE9244MappingExtensions.UpdateEntity) { }
}
