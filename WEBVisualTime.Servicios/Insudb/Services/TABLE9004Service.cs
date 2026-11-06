using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9004;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9004Service : CrudService<TABLE9004, TABLE9004Dto, CreateTABLE9004Dto, UpdateTABLE9004Dto, int>, ITABLE9004Service
{
    public TABLE9004Service(IRepository<TABLE9004> repository)
        : base(repository, TABLE9004MappingExtensions.ToDto, TABLE9004MappingExtensions.ToEntity, TABLE9004MappingExtensions.UpdateEntity) { }
}
