using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE211;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE211Service : CrudService<TABLE211, TABLE211Dto, CreateTABLE211Dto, UpdateTABLE211Dto, int>, ITABLE211Service
{
    public TABLE211Service(IRepository<TABLE211> repository)
        : base(repository, TABLE211MappingExtensions.ToDto, TABLE211MappingExtensions.ToEntity, TABLE211MappingExtensions.UpdateEntity) { }
}
