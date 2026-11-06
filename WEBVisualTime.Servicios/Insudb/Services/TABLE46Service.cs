using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE46;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE46Service : CrudService<TABLE46, TABLE46Dto, CreateTABLE46Dto, UpdateTABLE46Dto, string>, ITABLE46Service
{
    public TABLE46Service(IRepository<TABLE46> repository)
        : base(repository, TABLE46MappingExtensions.ToDto, TABLE46MappingExtensions.ToEntity, TABLE46MappingExtensions.UpdateEntity) { }
}
