using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE277;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE277Service : CrudService<TABLE277, TABLE277Dto, CreateTABLE277Dto, UpdateTABLE277Dto, int>, ITABLE277Service
{
    public TABLE277Service(IRepository<TABLE277> repository)
        : base(repository, TABLE277MappingExtensions.ToDto, TABLE277MappingExtensions.ToEntity, TABLE277MappingExtensions.UpdateEntity) { }
}
