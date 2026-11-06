using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8017;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8017Service : CrudService<TABLE8017, TABLE8017Dto, CreateTABLE8017Dto, UpdateTABLE8017Dto, int>, ITABLE8017Service
{
    public TABLE8017Service(IRepository<TABLE8017> repository)
        : base(repository, TABLE8017MappingExtensions.ToDto, TABLE8017MappingExtensions.ToEntity, TABLE8017MappingExtensions.UpdateEntity) { }
}
