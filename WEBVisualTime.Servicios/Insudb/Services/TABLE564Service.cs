using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE564;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE564Service : CrudService<TABLE564, TABLE564Dto, CreateTABLE564Dto, UpdateTABLE564Dto, int>, ITABLE564Service
{
    public TABLE564Service(IRepository<TABLE564> repository)
        : base(repository, TABLE564MappingExtensions.ToDto, TABLE564MappingExtensions.ToEntity, TABLE564MappingExtensions.UpdateEntity) { }
}
