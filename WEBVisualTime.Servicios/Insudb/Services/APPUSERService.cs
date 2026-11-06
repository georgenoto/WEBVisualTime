using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.APPUSER;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class APPUSERService : CrudService<APPUSER, APPUSERDto, CreateAPPUSERDto, UpdateAPPUSERDto, long>, IAPPUSERService
{
    public APPUSERService(IRepository<APPUSER> repository)
        : base(repository, APPUSERMappingExtensions.ToDto, APPUSERMappingExtensions.ToEntity, APPUSERMappingExtensions.UpdateEntity) { }
}
