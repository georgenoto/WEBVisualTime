using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5551;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5551Service : CrudService<TABLE5551, TABLE5551Dto, CreateTABLE5551Dto, UpdateTABLE5551Dto, int>, ITABLE5551Service
{
    public TABLE5551Service(IRepository<TABLE5551> repository)
        : base(repository, TABLE5551MappingExtensions.ToDto, TABLE5551MappingExtensions.ToEntity, TABLE5551MappingExtensions.UpdateEntity) { }
}
