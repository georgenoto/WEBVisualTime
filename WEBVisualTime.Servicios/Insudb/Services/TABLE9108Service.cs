using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9108;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9108Service : CrudService<TABLE9108, TABLE9108Dto, CreateTABLE9108Dto, UpdateTABLE9108Dto, int>, ITABLE9108Service
{
    public TABLE9108Service(IRepository<TABLE9108> repository)
        : base(repository, TABLE9108MappingExtensions.ToDto, TABLE9108MappingExtensions.ToEntity, TABLE9108MappingExtensions.UpdateEntity) { }
}
