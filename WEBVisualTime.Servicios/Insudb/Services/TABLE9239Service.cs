using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9239;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9239Service : CrudService<TABLE9239, TABLE9239Dto, CreateTABLE9239Dto, UpdateTABLE9239Dto, int>, ITABLE9239Service
{
    public TABLE9239Service(IRepository<TABLE9239> repository)
        : base(repository, TABLE9239MappingExtensions.ToDto, TABLE9239MappingExtensions.ToEntity, TABLE9239MappingExtensions.UpdateEntity) { }
}
