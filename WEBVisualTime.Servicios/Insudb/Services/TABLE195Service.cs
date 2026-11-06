using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE195;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE195Service : CrudService<TABLE195, TABLE195Dto, CreateTABLE195Dto, UpdateTABLE195Dto, long>, ITABLE195Service
{
    public TABLE195Service(IRepository<TABLE195> repository)
        : base(repository, TABLE195MappingExtensions.ToDto, TABLE195MappingExtensions.ToEntity, TABLE195MappingExtensions.UpdateEntity) { }
}
