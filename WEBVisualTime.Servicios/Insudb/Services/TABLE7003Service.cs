using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7003;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7003Service : CrudService<TABLE7003, TABLE7003Dto, CreateTABLE7003Dto, UpdateTABLE7003Dto, int>, ITABLE7003Service
{
    public TABLE7003Service(IRepository<TABLE7003> repository)
        : base(repository, TABLE7003MappingExtensions.ToDto, TABLE7003MappingExtensions.ToEntity, TABLE7003MappingExtensions.UpdateEntity) { }
}
