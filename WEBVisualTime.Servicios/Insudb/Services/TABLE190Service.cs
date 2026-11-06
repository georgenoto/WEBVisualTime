using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE190;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE190Service : CrudService<TABLE190, TABLE190Dto, CreateTABLE190Dto, UpdateTABLE190Dto, int>, ITABLE190Service
{
    public TABLE190Service(IRepository<TABLE190> repository)
        : base(repository, TABLE190MappingExtensions.ToDto, TABLE190MappingExtensions.ToEntity, TABLE190MappingExtensions.UpdateEntity) { }
}
