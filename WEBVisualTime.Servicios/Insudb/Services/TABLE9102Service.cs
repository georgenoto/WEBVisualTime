using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9102;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9102Service : CrudService<TABLE9102, TABLE9102Dto, CreateTABLE9102Dto, UpdateTABLE9102Dto, int>, ITABLE9102Service
{
    public TABLE9102Service(IRepository<TABLE9102> repository)
        : base(repository, TABLE9102MappingExtensions.ToDto, TABLE9102MappingExtensions.ToEntity, TABLE9102MappingExtensions.UpdateEntity) { }
}
