using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5004;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5004Service : CrudService<TABLE5004, TABLE5004Dto, CreateTABLE5004Dto, UpdateTABLE5004Dto, int>, ITABLE5004Service
{
    public TABLE5004Service(IRepository<TABLE5004> repository)
        : base(repository, TABLE5004MappingExtensions.ToDto, TABLE5004MappingExtensions.ToEntity, TABLE5004MappingExtensions.UpdateEntity) { }
}
