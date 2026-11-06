using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7204;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7204Service : CrudService<TABLE7204, TABLE7204Dto, CreateTABLE7204Dto, UpdateTABLE7204Dto, long>, ITABLE7204Service
{
    public TABLE7204Service(IRepository<TABLE7204> repository)
        : base(repository, TABLE7204MappingExtensions.ToDto, TABLE7204MappingExtensions.ToEntity, TABLE7204MappingExtensions.UpdateEntity) { }
}
