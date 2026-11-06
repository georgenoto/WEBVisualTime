using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9260;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9260Service : CrudService<TABLE9260, TABLE9260Dto, CreateTABLE9260Dto, UpdateTABLE9260Dto, int>, ITABLE9260Service
{
    public TABLE9260Service(IRepository<TABLE9260> repository)
        : base(repository, TABLE9260MappingExtensions.ToDto, TABLE9260MappingExtensions.ToEntity, TABLE9260MappingExtensions.UpdateEntity) { }
}
