using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9275;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9275Service : CrudService<TABLE9275, TABLE9275Dto, CreateTABLE9275Dto, UpdateTABLE9275Dto, int>, ITABLE9275Service
{
    public TABLE9275Service(IRepository<TABLE9275> repository)
        : base(repository, TABLE9275MappingExtensions.ToDto, TABLE9275MappingExtensions.ToEntity, TABLE9275MappingExtensions.UpdateEntity) { }
}
