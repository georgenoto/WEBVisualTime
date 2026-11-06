using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE294;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE294Service : CrudService<TABLE294, TABLE294Dto, CreateTABLE294Dto, UpdateTABLE294Dto, int>, ITABLE294Service
{
    public TABLE294Service(IRepository<TABLE294> repository)
        : base(repository, TABLE294MappingExtensions.ToDto, TABLE294MappingExtensions.ToEntity, TABLE294MappingExtensions.UpdateEntity) { }
}
