using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9010;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9010Service : CrudService<TABLE9010, TABLE9010Dto, CreateTABLE9010Dto, UpdateTABLE9010Dto, int>, ITABLE9010Service
{
    public TABLE9010Service(IRepository<TABLE9010> repository)
        : base(repository, TABLE9010MappingExtensions.ToDto, TABLE9010MappingExtensions.ToEntity, TABLE9010MappingExtensions.UpdateEntity) { }
}
