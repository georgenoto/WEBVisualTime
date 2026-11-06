using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE696;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE696Service : CrudService<TABLE696, TABLE696Dto, CreateTABLE696Dto, UpdateTABLE696Dto, int>, ITABLE696Service
{
    public TABLE696Service(IRepository<TABLE696> repository)
        : base(repository, TABLE696MappingExtensions.ToDto, TABLE696MappingExtensions.ToEntity, TABLE696MappingExtensions.UpdateEntity) { }
}
