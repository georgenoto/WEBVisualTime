using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE533;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE533Service : CrudService<TABLE533, TABLE533Dto, CreateTABLE533Dto, UpdateTABLE533Dto, int>, ITABLE533Service
{
    public TABLE533Service(IRepository<TABLE533> repository)
        : base(repository, TABLE533MappingExtensions.ToDto, TABLE533MappingExtensions.ToEntity, TABLE533MappingExtensions.UpdateEntity) { }
}
