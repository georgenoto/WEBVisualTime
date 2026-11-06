using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8020;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8020Service : CrudService<TABLE8020, TABLE8020Dto, CreateTABLE8020Dto, UpdateTABLE8020Dto, long>, ITABLE8020Service
{
    public TABLE8020Service(IRepository<TABLE8020> repository)
        : base(repository, TABLE8020MappingExtensions.ToDto, TABLE8020MappingExtensions.ToEntity, TABLE8020MappingExtensions.UpdateEntity) { }
}
