using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9251;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9251Service : CrudService<TABLE9251, TABLE9251Dto, CreateTABLE9251Dto, UpdateTABLE9251Dto, int>, ITABLE9251Service
{
    public TABLE9251Service(IRepository<TABLE9251> repository)
        : base(repository, TABLE9251MappingExtensions.ToDto, TABLE9251MappingExtensions.ToEntity, TABLE9251MappingExtensions.UpdateEntity) { }
}
