using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE74;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE74Service : CrudService<TABLE74, TABLE74Dto, CreateTABLE74Dto, UpdateTABLE74Dto, long>, ITABLE74Service
{
    public TABLE74Service(IRepository<TABLE74> repository)
        : base(repository, TABLE74MappingExtensions.ToDto, TABLE74MappingExtensions.ToEntity, TABLE74MappingExtensions.UpdateEntity) { }
}
