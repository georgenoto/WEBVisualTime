using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE47;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE47Service : CrudService<TABLE47, TABLE47Dto, CreateTABLE47Dto, UpdateTABLE47Dto, string>, ITABLE47Service
{
    public TABLE47Service(IRepository<TABLE47> repository)
        : base(repository, TABLE47MappingExtensions.ToDto, TABLE47MappingExtensions.ToEntity, TABLE47MappingExtensions.UpdateEntity) { }
}
