using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7801;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7801Service : CrudService<TABLE7801, TABLE7801Dto, CreateTABLE7801Dto, UpdateTABLE7801Dto, int>, ITABLE7801Service
{
    public TABLE7801Service(IRepository<TABLE7801> repository)
        : base(repository, TABLE7801MappingExtensions.ToDto, TABLE7801MappingExtensions.ToEntity, TABLE7801MappingExtensions.UpdateEntity) { }
}
