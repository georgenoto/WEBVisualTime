using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE205;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE205Service : CrudService<TABLE205, TABLE205Dto, CreateTABLE205Dto, UpdateTABLE205Dto, int>, ITABLE205Service
{
    public TABLE205Service(IRepository<TABLE205> repository)
        : base(repository, TABLE205MappingExtensions.ToDto, TABLE205MappingExtensions.ToEntity, TABLE205MappingExtensions.UpdateEntity) { }
}
