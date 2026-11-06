using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7100;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7100Service : CrudService<TABLE7100, TABLE7100Dto, CreateTABLE7100Dto, UpdateTABLE7100Dto, int>, ITABLE7100Service
{
    public TABLE7100Service(IRepository<TABLE7100> repository)
        : base(repository, TABLE7100MappingExtensions.ToDto, TABLE7100MappingExtensions.ToEntity, TABLE7100MappingExtensions.UpdateEntity) { }
}
