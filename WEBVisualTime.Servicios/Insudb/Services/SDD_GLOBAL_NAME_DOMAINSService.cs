using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_GLOBAL_NAME_DOMAINS;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class SDD_GLOBAL_NAME_DOMAINSService : CrudService<SDD_GLOBAL_NAME_DOMAINS, SDD_GLOBAL_NAME_DOMAINSDto, CreateSDD_GLOBAL_NAME_DOMAINSDto, UpdateSDD_GLOBAL_NAME_DOMAINSDto, int>, ISDD_GLOBAL_NAME_DOMAINSService
{
    public SDD_GLOBAL_NAME_DOMAINSService(IRepository<SDD_GLOBAL_NAME_DOMAINS> repository)
        : base(repository, SDD_GLOBAL_NAME_DOMAINSMappingExtensions.ToDto, SDD_GLOBAL_NAME_DOMAINSMappingExtensions.ToEntity, SDD_GLOBAL_NAME_DOMAINSMappingExtensions.UpdateEntity) { }
}
