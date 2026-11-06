using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE165;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE165Service : CrudService<TABLE165, TABLE165Dto, CreateTABLE165Dto, UpdateTABLE165Dto, int>, ITABLE165Service
{
    public TABLE165Service(IRepository<TABLE165> repository)
        : base(repository, TABLE165MappingExtensions.ToDto, TABLE165MappingExtensions.ToEntity, TABLE165MappingExtensions.UpdateEntity) { }
}
