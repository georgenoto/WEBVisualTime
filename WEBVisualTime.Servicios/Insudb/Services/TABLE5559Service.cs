using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5559;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5559Service : CrudService<TABLE5559, TABLE5559Dto, CreateTABLE5559Dto, UpdateTABLE5559Dto, int>, ITABLE5559Service
{
    public TABLE5559Service(IRepository<TABLE5559> repository)
        : base(repository, TABLE5559MappingExtensions.ToDto, TABLE5559MappingExtensions.ToEntity, TABLE5559MappingExtensions.UpdateEntity) { }
}
