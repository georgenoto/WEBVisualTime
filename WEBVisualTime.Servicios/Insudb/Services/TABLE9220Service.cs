using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9220;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9220Service : CrudService<TABLE9220, TABLE9220Dto, CreateTABLE9220Dto, UpdateTABLE9220Dto, int>, ITABLE9220Service
{
    public TABLE9220Service(IRepository<TABLE9220> repository)
        : base(repository, TABLE9220MappingExtensions.ToDto, TABLE9220MappingExtensions.ToEntity, TABLE9220MappingExtensions.UpdateEntity) { }
}
