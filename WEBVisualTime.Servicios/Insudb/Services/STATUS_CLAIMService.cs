using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.STATUS_CLAIM;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class STATUS_CLAIMService : CrudService<STATUS_CLAIM, STATUS_CLAIMDto, CreateSTATUS_CLAIMDto, UpdateSTATUS_CLAIMDto, int>, ISTATUS_CLAIMService
{
    public STATUS_CLAIMService(IRepository<STATUS_CLAIM> repository)
        : base(repository, STATUS_CLAIMMappingExtensions.ToDto, STATUS_CLAIMMappingExtensions.ToEntity, STATUS_CLAIMMappingExtensions.UpdateEntity) { }
}
