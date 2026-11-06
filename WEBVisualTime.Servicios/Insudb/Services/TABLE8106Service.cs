using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8106;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8106Service : CrudService<TABLE8106, TABLE8106Dto, CreateTABLE8106Dto, UpdateTABLE8106Dto, long>, ITABLE8106Service
{
    public TABLE8106Service(IRepository<TABLE8106> repository)
        : base(repository, TABLE8106MappingExtensions.ToDto, TABLE8106MappingExtensions.ToEntity, TABLE8106MappingExtensions.UpdateEntity) { }
}
