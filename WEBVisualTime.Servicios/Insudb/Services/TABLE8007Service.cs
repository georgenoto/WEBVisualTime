using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8007;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8007Service : CrudService<TABLE8007, TABLE8007Dto, CreateTABLE8007Dto, UpdateTABLE8007Dto, int>, ITABLE8007Service
{
    public TABLE8007Service(IRepository<TABLE8007> repository)
        : base(repository, TABLE8007MappingExtensions.ToDto, TABLE8007MappingExtensions.ToEntity, TABLE8007MappingExtensions.UpdateEntity) { }
}
