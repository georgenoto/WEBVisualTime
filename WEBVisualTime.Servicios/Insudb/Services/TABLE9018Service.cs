using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9018;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9018Service : CrudService<TABLE9018, TABLE9018Dto, CreateTABLE9018Dto, UpdateTABLE9018Dto, int>, ITABLE9018Service
{
    public TABLE9018Service(IRepository<TABLE9018> repository)
        : base(repository, TABLE9018MappingExtensions.ToDto, TABLE9018MappingExtensions.ToEntity, TABLE9018MappingExtensions.UpdateEntity) { }
}
