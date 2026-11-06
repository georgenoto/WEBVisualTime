using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8215;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8215Service : CrudService<TABLE8215, TABLE8215Dto, CreateTABLE8215Dto, UpdateTABLE8215Dto, int>, ITABLE8215Service
{
    public TABLE8215Service(IRepository<TABLE8215> repository)
        : base(repository, TABLE8215MappingExtensions.ToDto, TABLE8215MappingExtensions.ToEntity, TABLE8215MappingExtensions.UpdateEntity) { }
}
