using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE187;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE187Service : CrudService<TABLE187, TABLE187Dto, CreateTABLE187Dto, UpdateTABLE187Dto, int>, ITABLE187Service
{
    public TABLE187Service(IRepository<TABLE187> repository)
        : base(repository, TABLE187MappingExtensions.ToDto, TABLE187MappingExtensions.ToEntity, TABLE187MappingExtensions.UpdateEntity) { }
}
