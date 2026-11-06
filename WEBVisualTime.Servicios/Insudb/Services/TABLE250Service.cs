using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE250;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE250Service : CrudService<TABLE250, TABLE250Dto, CreateTABLE250Dto, UpdateTABLE250Dto, int>, ITABLE250Service
{
    public TABLE250Service(IRepository<TABLE250> repository)
        : base(repository, TABLE250MappingExtensions.ToDto, TABLE250MappingExtensions.ToEntity, TABLE250MappingExtensions.UpdateEntity) { }
}
