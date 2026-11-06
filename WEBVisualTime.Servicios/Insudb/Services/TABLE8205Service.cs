using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8205;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8205Service : CrudService<TABLE8205, TABLE8205Dto, CreateTABLE8205Dto, UpdateTABLE8205Dto, int>, ITABLE8205Service
{
    public TABLE8205Service(IRepository<TABLE8205> repository)
        : base(repository, TABLE8205MappingExtensions.ToDto, TABLE8205MappingExtensions.ToEntity, TABLE8205MappingExtensions.UpdateEntity) { }
}
