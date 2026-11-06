using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.PROVISION_TYPE;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class PROVISION_TYPEService : CrudService<PROVISION_TYPE, PROVISION_TYPEDto, CreatePROVISION_TYPEDto, UpdatePROVISION_TYPEDto, int>, IPROVISION_TYPEService
{
    public PROVISION_TYPEService(IRepository<PROVISION_TYPE> repository)
        : base(repository, PROVISION_TYPEMappingExtensions.ToDto, PROVISION_TYPEMappingExtensions.ToEntity, PROVISION_TYPEMappingExtensions.UpdateEntity) { }
}
