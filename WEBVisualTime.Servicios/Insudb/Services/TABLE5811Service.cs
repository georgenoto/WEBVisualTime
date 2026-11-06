using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5811;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5811Service : CrudService<TABLE5811, TABLE5811Dto, CreateTABLE5811Dto, UpdateTABLE5811Dto, int>, ITABLE5811Service
{
    public TABLE5811Service(IRepository<TABLE5811> repository)
        : base(repository, TABLE5811MappingExtensions.ToDto, TABLE5811MappingExtensions.ToEntity, TABLE5811MappingExtensions.UpdateEntity) { }
}
