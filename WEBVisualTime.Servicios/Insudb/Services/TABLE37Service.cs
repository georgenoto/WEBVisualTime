using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE37;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE37Service : CrudService<TABLE37, TABLE37Dto, CreateTABLE37Dto, UpdateTABLE37Dto, string>, ITABLE37Service
{
    public TABLE37Service(IRepository<TABLE37> repository)
        : base(repository, TABLE37MappingExtensions.ToDto, TABLE37MappingExtensions.ToEntity, TABLE37MappingExtensions.UpdateEntity) { }
}
