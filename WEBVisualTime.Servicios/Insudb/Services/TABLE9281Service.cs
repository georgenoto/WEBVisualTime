using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9281;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9281Service : CrudService<TABLE9281, TABLE9281Dto, CreateTABLE9281Dto, UpdateTABLE9281Dto, int>, ITABLE9281Service
{
    public TABLE9281Service(IRepository<TABLE9281> repository)
        : base(repository, TABLE9281MappingExtensions.ToDto, TABLE9281MappingExtensions.ToEntity, TABLE9281MappingExtensions.UpdateEntity) { }
}
