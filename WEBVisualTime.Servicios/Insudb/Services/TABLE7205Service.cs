using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7205;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7205Service : CrudService<TABLE7205, TABLE7205Dto, CreateTABLE7205Dto, UpdateTABLE7205Dto, int>, ITABLE7205Service
{
    public TABLE7205Service(IRepository<TABLE7205> repository)
        : base(repository, TABLE7205MappingExtensions.ToDto, TABLE7205MappingExtensions.ToEntity, TABLE7205MappingExtensions.UpdateEntity) { }
}
