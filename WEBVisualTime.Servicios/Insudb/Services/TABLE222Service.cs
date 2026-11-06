using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE222;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE222Service : CrudService<TABLE222, TABLE222Dto, CreateTABLE222Dto, UpdateTABLE222Dto, int>, ITABLE222Service
{
    public TABLE222Service(IRepository<TABLE222> repository)
        : base(repository, TABLE222MappingExtensions.ToDto, TABLE222MappingExtensions.ToEntity, TABLE222MappingExtensions.UpdateEntity) { }
}
