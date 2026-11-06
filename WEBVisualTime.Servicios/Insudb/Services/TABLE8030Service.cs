using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8030;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8030Service : CrudService<TABLE8030, TABLE8030Dto, CreateTABLE8030Dto, UpdateTABLE8030Dto, int>, ITABLE8030Service
{
    public TABLE8030Service(IRepository<TABLE8030> repository)
        : base(repository, TABLE8030MappingExtensions.ToDto, TABLE8030MappingExtensions.ToEntity, TABLE8030MappingExtensions.UpdateEntity) { }
}
