using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9001;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9001Service : CrudService<TABLE9001, TABLE9001Dto, CreateTABLE9001Dto, UpdateTABLE9001Dto, int>, ITABLE9001Service
{
    public TABLE9001Service(IRepository<TABLE9001> repository)
        : base(repository, TABLE9001MappingExtensions.ToDto, TABLE9001MappingExtensions.ToEntity, TABLE9001MappingExtensions.UpdateEntity) { }
}
