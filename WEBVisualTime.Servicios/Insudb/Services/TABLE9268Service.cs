using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9268;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9268Service : CrudService<TABLE9268, TABLE9268Dto, CreateTABLE9268Dto, UpdateTABLE9268Dto, int>, ITABLE9268Service
{
    public TABLE9268Service(IRepository<TABLE9268> repository)
        : base(repository, TABLE9268MappingExtensions.ToDto, TABLE9268MappingExtensions.ToEntity, TABLE9268MappingExtensions.UpdateEntity) { }
}
