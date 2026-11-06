using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE88;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE88Service : CrudService<TABLE88, TABLE88Dto, CreateTABLE88Dto, UpdateTABLE88Dto, int>, ITABLE88Service
{
    public TABLE88Service(IRepository<TABLE88> repository)
        : base(repository, TABLE88MappingExtensions.ToDto, TABLE88MappingExtensions.ToEntity, TABLE88MappingExtensions.UpdateEntity) { }
}
