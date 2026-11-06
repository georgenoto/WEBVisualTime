using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9203;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9203Service : CrudService<TABLE9203, TABLE9203Dto, CreateTABLE9203Dto, UpdateTABLE9203Dto, int>, ITABLE9203Service
{
    public TABLE9203Service(IRepository<TABLE9203> repository)
        : base(repository, TABLE9203MappingExtensions.ToDto, TABLE9203MappingExtensions.ToEntity, TABLE9203MappingExtensions.UpdateEntity) { }
}
