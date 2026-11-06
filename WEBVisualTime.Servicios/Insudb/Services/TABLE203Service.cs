using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE203;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE203Service : CrudService<TABLE203, TABLE203Dto, CreateTABLE203Dto, UpdateTABLE203Dto, int>, ITABLE203Service
{
    public TABLE203Service(IRepository<TABLE203> repository)
        : base(repository, TABLE203MappingExtensions.ToDto, TABLE203MappingExtensions.ToEntity, TABLE203MappingExtensions.UpdateEntity) { }
}
