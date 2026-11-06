using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9016;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9016Service : CrudService<TABLE9016, TABLE9016Dto, CreateTABLE9016Dto, UpdateTABLE9016Dto, int>, ITABLE9016Service
{
    public TABLE9016Service(IRepository<TABLE9016> repository)
        : base(repository, TABLE9016MappingExtensions.ToDto, TABLE9016MappingExtensions.ToEntity, TABLE9016MappingExtensions.UpdateEntity) { }
}
