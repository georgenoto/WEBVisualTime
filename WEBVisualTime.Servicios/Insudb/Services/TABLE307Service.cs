using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE307;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE307Service : CrudService<TABLE307, TABLE307Dto, CreateTABLE307Dto, UpdateTABLE307Dto, long>, ITABLE307Service
{
    public TABLE307Service(IRepository<TABLE307> repository)
        : base(repository, TABLE307MappingExtensions.ToDto, TABLE307MappingExtensions.ToEntity, TABLE307MappingExtensions.UpdateEntity) { }
}
