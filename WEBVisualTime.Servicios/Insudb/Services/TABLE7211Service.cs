using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7211;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7211Service : CrudService<TABLE7211, TABLE7211Dto, CreateTABLE7211Dto, UpdateTABLE7211Dto, int>, ITABLE7211Service
{
    public TABLE7211Service(IRepository<TABLE7211> repository)
        : base(repository, TABLE7211MappingExtensions.ToDto, TABLE7211MappingExtensions.ToEntity, TABLE7211MappingExtensions.UpdateEntity) { }
}
