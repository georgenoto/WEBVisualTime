using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE221;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE221Service : CrudService<TABLE221, TABLE221Dto, CreateTABLE221Dto, UpdateTABLE221Dto, long>, ITABLE221Service
{
    public TABLE221Service(IRepository<TABLE221> repository)
        : base(repository, TABLE221MappingExtensions.ToDto, TABLE221MappingExtensions.ToEntity, TABLE221MappingExtensions.UpdateEntity) { }
}
