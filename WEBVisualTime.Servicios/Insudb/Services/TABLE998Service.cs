using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE998;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE998Service : CrudService<TABLE998, TABLE998Dto, CreateTABLE998Dto, UpdateTABLE998Dto, int>, ITABLE998Service
{
    public TABLE998Service(IRepository<TABLE998> repository)
        : base(repository, TABLE998MappingExtensions.ToDto, TABLE998MappingExtensions.ToEntity, TABLE998MappingExtensions.UpdateEntity) { }
}
