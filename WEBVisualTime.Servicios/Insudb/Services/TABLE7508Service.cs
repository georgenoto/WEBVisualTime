using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7508;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7508Service : CrudService<TABLE7508, TABLE7508Dto, CreateTABLE7508Dto, UpdateTABLE7508Dto, int>, ITABLE7508Service
{
    public TABLE7508Service(IRepository<TABLE7508> repository)
        : base(repository, TABLE7508MappingExtensions.ToDto, TABLE7508MappingExtensions.ToEntity, TABLE7508MappingExtensions.UpdateEntity) { }
}
