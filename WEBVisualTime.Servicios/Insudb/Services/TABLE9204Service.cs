using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9204;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9204Service : CrudService<TABLE9204, TABLE9204Dto, CreateTABLE9204Dto, UpdateTABLE9204Dto, int>, ITABLE9204Service
{
    public TABLE9204Service(IRepository<TABLE9204> repository)
        : base(repository, TABLE9204MappingExtensions.ToDto, TABLE9204MappingExtensions.ToEntity, TABLE9204MappingExtensions.UpdateEntity) { }
}
