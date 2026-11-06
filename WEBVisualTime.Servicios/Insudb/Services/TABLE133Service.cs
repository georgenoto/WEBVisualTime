using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE133;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE133Service : CrudService<TABLE133, TABLE133Dto, CreateTABLE133Dto, UpdateTABLE133Dto, int>, ITABLE133Service
{
    public TABLE133Service(IRepository<TABLE133> repository)
        : base(repository, TABLE133MappingExtensions.ToDto, TABLE133MappingExtensions.ToEntity, TABLE133MappingExtensions.UpdateEntity) { }
}
