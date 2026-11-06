using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE297;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE297Service : CrudService<TABLE297, TABLE297Dto, CreateTABLE297Dto, UpdateTABLE297Dto, long>, ITABLE297Service
{
    public TABLE297Service(IRepository<TABLE297> repository)
        : base(repository, TABLE297MappingExtensions.ToDto, TABLE297MappingExtensions.ToEntity, TABLE297MappingExtensions.UpdateEntity) { }
}
