using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9023;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9023Service : CrudService<TABLE9023, TABLE9023Dto, CreateTABLE9023Dto, UpdateTABLE9023Dto, int>, ITABLE9023Service
{
    public TABLE9023Service(IRepository<TABLE9023> repository)
        : base(repository, TABLE9023MappingExtensions.ToDto, TABLE9023MappingExtensions.ToEntity, TABLE9023MappingExtensions.UpdateEntity) { }
}
