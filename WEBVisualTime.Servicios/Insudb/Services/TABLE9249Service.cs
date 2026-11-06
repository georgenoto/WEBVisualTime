using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9249;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9249Service : CrudService<TABLE9249, TABLE9249Dto, CreateTABLE9249Dto, UpdateTABLE9249Dto, int>, ITABLE9249Service
{
    public TABLE9249Service(IRepository<TABLE9249> repository)
        : base(repository, TABLE9249MappingExtensions.ToDto, TABLE9249MappingExtensions.ToEntity, TABLE9249MappingExtensions.UpdateEntity) { }
}
