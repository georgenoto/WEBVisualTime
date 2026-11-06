using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9238;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9238Service : CrudService<TABLE9238, TABLE9238Dto, CreateTABLE9238Dto, UpdateTABLE9238Dto, int>, ITABLE9238Service
{
    public TABLE9238Service(IRepository<TABLE9238> repository)
        : base(repository, TABLE9238MappingExtensions.ToDto, TABLE9238MappingExtensions.ToEntity, TABLE9238MappingExtensions.UpdateEntity) { }
}
