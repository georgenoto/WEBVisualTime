using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5622;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5622Service : CrudService<TABLE5622, TABLE5622Dto, CreateTABLE5622Dto, UpdateTABLE5622Dto, int>, ITABLE5622Service
{
    public TABLE5622Service(IRepository<TABLE5622> repository)
        : base(repository, TABLE5622MappingExtensions.ToDto, TABLE5622MappingExtensions.ToEntity, TABLE5622MappingExtensions.UpdateEntity) { }
}
