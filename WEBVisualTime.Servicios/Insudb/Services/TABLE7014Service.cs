using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7014;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7014Service : CrudService<TABLE7014, TABLE7014Dto, CreateTABLE7014Dto, UpdateTABLE7014Dto, long>, ITABLE7014Service
{
    public TABLE7014Service(IRepository<TABLE7014> repository)
        : base(repository, TABLE7014MappingExtensions.ToDto, TABLE7014MappingExtensions.ToEntity, TABLE7014MappingExtensions.UpdateEntity) { }
}
