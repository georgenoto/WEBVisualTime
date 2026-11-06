using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7220;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7220Service : CrudService<TABLE7220, TABLE7220Dto, CreateTABLE7220Dto, UpdateTABLE7220Dto, int>, ITABLE7220Service
{
    public TABLE7220Service(IRepository<TABLE7220> repository)
        : base(repository, TABLE7220MappingExtensions.ToDto, TABLE7220MappingExtensions.ToEntity, TABLE7220MappingExtensions.UpdateEntity) { }
}
