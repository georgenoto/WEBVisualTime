using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9276;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9276Service : CrudService<TABLE9276, TABLE9276Dto, CreateTABLE9276Dto, UpdateTABLE9276Dto, int>, ITABLE9276Service
{
    public TABLE9276Service(IRepository<TABLE9276> repository)
        : base(repository, TABLE9276MappingExtensions.ToDto, TABLE9276MappingExtensions.ToEntity, TABLE9276MappingExtensions.UpdateEntity) { }
}
