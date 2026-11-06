using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9271;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9271Service : CrudService<TABLE9271, TABLE9271Dto, CreateTABLE9271Dto, UpdateTABLE9271Dto, int>, ITABLE9271Service
{
    public TABLE9271Service(IRepository<TABLE9271> repository)
        : base(repository, TABLE9271MappingExtensions.ToDto, TABLE9271MappingExtensions.ToEntity, TABLE9271MappingExtensions.UpdateEntity) { }
}
