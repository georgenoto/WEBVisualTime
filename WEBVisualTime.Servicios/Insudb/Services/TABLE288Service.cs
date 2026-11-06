using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE288;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE288Service : CrudService<TABLE288, TABLE288Dto, CreateTABLE288Dto, UpdateTABLE288Dto, int>, ITABLE288Service
{
    public TABLE288Service(IRepository<TABLE288> repository)
        : base(repository, TABLE288MappingExtensions.ToDto, TABLE288MappingExtensions.ToEntity, TABLE288MappingExtensions.UpdateEntity) { }
}
