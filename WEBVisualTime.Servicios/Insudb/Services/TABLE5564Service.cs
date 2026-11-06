using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5564;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5564Service : CrudService<TABLE5564, TABLE5564Dto, CreateTABLE5564Dto, UpdateTABLE5564Dto, int>, ITABLE5564Service
{
    public TABLE5564Service(IRepository<TABLE5564> repository)
        : base(repository, TABLE5564MappingExtensions.ToDto, TABLE5564MappingExtensions.ToEntity, TABLE5564MappingExtensions.UpdateEntity) { }
}
