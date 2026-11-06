using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9265;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9265Service : CrudService<TABLE9265, TABLE9265Dto, CreateTABLE9265Dto, UpdateTABLE9265Dto, int>, ITABLE9265Service
{
    public TABLE9265Service(IRepository<TABLE9265> repository)
        : base(repository, TABLE9265MappingExtensions.ToDto, TABLE9265MappingExtensions.ToEntity, TABLE9265MappingExtensions.UpdateEntity) { }
}
