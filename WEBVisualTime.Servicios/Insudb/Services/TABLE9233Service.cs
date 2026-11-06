using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9233;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9233Service : CrudService<TABLE9233, TABLE9233Dto, CreateTABLE9233Dto, UpdateTABLE9233Dto, string>, ITABLE9233Service
{
    public TABLE9233Service(IRepository<TABLE9233> repository)
        : base(repository, TABLE9233MappingExtensions.ToDto, TABLE9233MappingExtensions.ToEntity, TABLE9233MappingExtensions.UpdateEntity) { }
}
