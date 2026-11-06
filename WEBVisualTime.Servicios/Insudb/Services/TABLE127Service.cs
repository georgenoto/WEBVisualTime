using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE127;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE127Service : CrudService<TABLE127, TABLE127Dto, CreateTABLE127Dto, UpdateTABLE127Dto, int>, ITABLE127Service
{
    public TABLE127Service(IRepository<TABLE127> repository)
        : base(repository, TABLE127MappingExtensions.ToDto, TABLE127MappingExtensions.ToEntity, TABLE127MappingExtensions.UpdateEntity) { }
}
