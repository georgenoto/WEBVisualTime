using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7038;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7038Service : CrudService<TABLE7038, TABLE7038Dto, CreateTABLE7038Dto, UpdateTABLE7038Dto, int>, ITABLE7038Service
{
    public TABLE7038Service(IRepository<TABLE7038> repository)
        : base(repository, TABLE7038MappingExtensions.ToDto, TABLE7038MappingExtensions.ToEntity, TABLE7038MappingExtensions.UpdateEntity) { }
}
