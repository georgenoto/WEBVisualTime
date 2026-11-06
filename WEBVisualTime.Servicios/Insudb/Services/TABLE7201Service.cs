using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7201;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7201Service : CrudService<TABLE7201, TABLE7201Dto, CreateTABLE7201Dto, UpdateTABLE7201Dto, int>, ITABLE7201Service
{
    public TABLE7201Service(IRepository<TABLE7201> repository)
        : base(repository, TABLE7201MappingExtensions.ToDto, TABLE7201MappingExtensions.ToEntity, TABLE7201MappingExtensions.UpdateEntity) { }
}
