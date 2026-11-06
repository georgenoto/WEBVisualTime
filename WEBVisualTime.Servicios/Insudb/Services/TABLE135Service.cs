using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE135;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE135Service : CrudService<TABLE135, TABLE135Dto, CreateTABLE135Dto, UpdateTABLE135Dto, string>, ITABLE135Service
{
    public TABLE135Service(IRepository<TABLE135> repository)
        : base(repository, TABLE135MappingExtensions.ToDto, TABLE135MappingExtensions.ToEntity, TABLE135MappingExtensions.UpdateEntity) { }
}
