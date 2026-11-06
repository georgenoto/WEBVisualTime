using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7031;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7031Service : CrudService<TABLE7031, TABLE7031Dto, CreateTABLE7031Dto, UpdateTABLE7031Dto, long>, ITABLE7031Service
{
    public TABLE7031Service(IRepository<TABLE7031> repository)
        : base(repository, TABLE7031MappingExtensions.ToDto, TABLE7031MappingExtensions.ToEntity, TABLE7031MappingExtensions.UpdateEntity) { }
}
