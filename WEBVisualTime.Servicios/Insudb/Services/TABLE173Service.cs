using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE173;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE173Service : CrudService<TABLE173, TABLE173Dto, CreateTABLE173Dto, UpdateTABLE173Dto, int>, ITABLE173Service
{
    public TABLE173Service(IRepository<TABLE173> repository)
        : base(repository, TABLE173MappingExtensions.ToDto, TABLE173MappingExtensions.ToEntity, TABLE173MappingExtensions.UpdateEntity) { }
}
