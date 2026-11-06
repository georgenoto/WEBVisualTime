using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7006;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7006Service : CrudService<TABLE7006, TABLE7006Dto, CreateTABLE7006Dto, UpdateTABLE7006Dto, long>, ITABLE7006Service
{
    public TABLE7006Service(IRepository<TABLE7006> repository)
        : base(repository, TABLE7006MappingExtensions.ToDto, TABLE7006MappingExtensions.ToEntity, TABLE7006MappingExtensions.UpdateEntity) { }
}
