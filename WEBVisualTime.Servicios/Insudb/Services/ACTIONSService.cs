using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.ACTIONS;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class ACTIONSService : CrudService<ACTIONS, ACTIONSDto, CreateACTIONSDto, UpdateACTIONSDto, int>, IACTIONSService
{
    public ACTIONSService(IRepository<ACTIONS> repository)
        : base(repository, ACTIONSMappingExtensions.ToDto, ACTIONSMappingExtensions.ToEntity, ACTIONSMappingExtensions.UpdateEntity) { }
}
