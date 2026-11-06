using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8003;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8003Service : CrudService<TABLE8003, TABLE8003Dto, CreateTABLE8003Dto, UpdateTABLE8003Dto, int>, ITABLE8003Service
{
    public TABLE8003Service(IRepository<TABLE8003> repository)
        : base(repository, TABLE8003MappingExtensions.ToDto, TABLE8003MappingExtensions.ToEntity, TABLE8003MappingExtensions.UpdateEntity) { }
}
