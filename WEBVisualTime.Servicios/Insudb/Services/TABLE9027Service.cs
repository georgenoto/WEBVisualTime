using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9027;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9027Service : CrudService<TABLE9027, TABLE9027Dto, CreateTABLE9027Dto, UpdateTABLE9027Dto, int>, ITABLE9027Service
{
    public TABLE9027Service(IRepository<TABLE9027> repository)
        : base(repository, TABLE9027MappingExtensions.ToDto, TABLE9027MappingExtensions.ToEntity, TABLE9027MappingExtensions.UpdateEntity) { }
}
