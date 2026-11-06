using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE275;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE275Service : CrudService<TABLE275, TABLE275Dto, CreateTABLE275Dto, UpdateTABLE275Dto, int>, ITABLE275Service
{
    public TABLE275Service(IRepository<TABLE275> repository)
        : base(repository, TABLE275MappingExtensions.ToDto, TABLE275MappingExtensions.ToEntity, TABLE275MappingExtensions.UpdateEntity) { }
}
