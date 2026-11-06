using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8Service : CrudService<TABLE8, TABLE8Dto, CreateTABLE8Dto, UpdateTABLE8Dto, string>, ITABLE8Service
{
    public TABLE8Service(IRepository<TABLE8> repository)
        : base(repository, TABLE8MappingExtensions.ToDto, TABLE8MappingExtensions.ToEntity, TABLE8MappingExtensions.UpdateEntity) { }
}
