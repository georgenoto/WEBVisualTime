using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9025;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9025Service : CrudService<TABLE9025, TABLE9025Dto, CreateTABLE9025Dto, UpdateTABLE9025Dto, int>, ITABLE9025Service
{
    public TABLE9025Service(IRepository<TABLE9025> repository)
        : base(repository, TABLE9025MappingExtensions.ToDto, TABLE9025MappingExtensions.ToEntity, TABLE9025MappingExtensions.UpdateEntity) { }
}
