using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.SECUR_SCHE;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class SECUR_SCHEService : CrudService<SECUR_SCHE, SECUR_SCHEDto, CreateSECUR_SCHEDto, UpdateSECUR_SCHEDto, string>, ISECUR_SCHEService
{
    public SECUR_SCHEService(IRepository<SECUR_SCHE> repository)
        : base(repository, SECUR_SCHEMappingExtensions.ToDto, SECUR_SCHEMappingExtensions.ToEntity, SECUR_SCHEMappingExtensions.UpdateEntity) { }
}
