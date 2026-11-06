using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE248;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE248Service : CrudService<TABLE248, TABLE248Dto, CreateTABLE248Dto, UpdateTABLE248Dto, int>, ITABLE248Service
{
    public TABLE248Service(IRepository<TABLE248> repository)
        : base(repository, TABLE248MappingExtensions.ToDto, TABLE248MappingExtensions.ToEntity, TABLE248MappingExtensions.UpdateEntity) { }
}
