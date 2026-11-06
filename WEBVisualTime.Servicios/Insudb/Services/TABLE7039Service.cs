using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7039;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7039Service : CrudService<TABLE7039, TABLE7039Dto, CreateTABLE7039Dto, UpdateTABLE7039Dto, int>, ITABLE7039Service
{
    public TABLE7039Service(IRepository<TABLE7039> repository)
        : base(repository, TABLE7039MappingExtensions.ToDto, TABLE7039MappingExtensions.ToEntity, TABLE7039MappingExtensions.UpdateEntity) { }
}
