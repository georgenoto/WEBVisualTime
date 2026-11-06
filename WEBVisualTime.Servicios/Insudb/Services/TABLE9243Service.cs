using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9243;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9243Service : CrudService<TABLE9243, TABLE9243Dto, CreateTABLE9243Dto, UpdateTABLE9243Dto, int>, ITABLE9243Service
{
    public TABLE9243Service(IRepository<TABLE9243> repository)
        : base(repository, TABLE9243MappingExtensions.ToDto, TABLE9243MappingExtensions.ToEntity, TABLE9243MappingExtensions.UpdateEntity) { }
}
