using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE179;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE179Service : CrudService<TABLE179, TABLE179Dto, CreateTABLE179Dto, UpdateTABLE179Dto, int>, ITABLE179Service
{
    public TABLE179Service(IRepository<TABLE179> repository)
        : base(repository, TABLE179MappingExtensions.ToDto, TABLE179MappingExtensions.ToEntity, TABLE179MappingExtensions.UpdateEntity) { }
}
