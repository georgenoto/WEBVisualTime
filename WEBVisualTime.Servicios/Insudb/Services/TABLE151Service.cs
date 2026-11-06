using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE151;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE151Service : CrudService<TABLE151, TABLE151Dto, CreateTABLE151Dto, UpdateTABLE151Dto, int>, ITABLE151Service
{
    public TABLE151Service(IRepository<TABLE151> repository)
        : base(repository, TABLE151MappingExtensions.ToDto, TABLE151MappingExtensions.ToEntity, TABLE151MappingExtensions.UpdateEntity) { }
}
