using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9254;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9254Service : CrudService<TABLE9254, TABLE9254Dto, CreateTABLE9254Dto, UpdateTABLE9254Dto, int>, ITABLE9254Service
{
    public TABLE9254Service(IRepository<TABLE9254> repository)
        : base(repository, TABLE9254MappingExtensions.ToDto, TABLE9254MappingExtensions.ToEntity, TABLE9254MappingExtensions.UpdateEntity) { }
}
