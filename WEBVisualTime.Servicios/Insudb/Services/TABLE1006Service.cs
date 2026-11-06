using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1006;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE1006Service : CrudService<TABLE1006, TABLE1006Dto, CreateTABLE1006Dto, UpdateTABLE1006Dto, int>, ITABLE1006Service
{
    public TABLE1006Service(IRepository<TABLE1006> repository)
        : base(repository, TABLE1006MappingExtensions.ToDto, TABLE1006MappingExtensions.ToEntity, TABLE1006MappingExtensions.UpdateEntity) { }
}
