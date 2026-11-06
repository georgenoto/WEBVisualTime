using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5621;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5621Service : CrudService<TABLE5621, TABLE5621Dto, CreateTABLE5621Dto, UpdateTABLE5621Dto, int>, ITABLE5621Service
{
    public TABLE5621Service(IRepository<TABLE5621> repository)
        : base(repository, TABLE5621MappingExtensions.ToDto, TABLE5621MappingExtensions.ToEntity, TABLE5621MappingExtensions.UpdateEntity) { }
}
