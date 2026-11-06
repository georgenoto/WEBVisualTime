using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9022;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9022Service : CrudService<TABLE9022, TABLE9022Dto, CreateTABLE9022Dto, UpdateTABLE9022Dto, int>, ITABLE9022Service
{
    public TABLE9022Service(IRepository<TABLE9022> repository)
        : base(repository, TABLE9022MappingExtensions.ToDto, TABLE9022MappingExtensions.ToEntity, TABLE9022MappingExtensions.UpdateEntity) { }
}
