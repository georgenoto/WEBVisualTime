using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE308;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE308Service : CrudService<TABLE308, TABLE308Dto, CreateTABLE308Dto, UpdateTABLE308Dto, long>, ITABLE308Service
{
    public TABLE308Service(IRepository<TABLE308> repository)
        : base(repository, TABLE308MappingExtensions.ToDto, TABLE308MappingExtensions.ToEntity, TABLE308MappingExtensions.UpdateEntity) { }
}
