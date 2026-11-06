using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE154;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE154Service : CrudService<TABLE154, TABLE154Dto, CreateTABLE154Dto, UpdateTABLE154Dto, string>, ITABLE154Service
{
    public TABLE154Service(IRepository<TABLE154> repository)
        : base(repository, TABLE154MappingExtensions.ToDto, TABLE154MappingExtensions.ToEntity, TABLE154MappingExtensions.UpdateEntity) { }
}
