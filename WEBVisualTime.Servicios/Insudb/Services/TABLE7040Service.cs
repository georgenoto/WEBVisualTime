using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7040;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7040Service : CrudService<TABLE7040, TABLE7040Dto, CreateTABLE7040Dto, UpdateTABLE7040Dto, int>, ITABLE7040Service
{
    public TABLE7040Service(IRepository<TABLE7040> repository)
        : base(repository, TABLE7040MappingExtensions.ToDto, TABLE7040MappingExtensions.ToEntity, TABLE7040MappingExtensions.UpdateEntity) { }
}
