using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.GROUPPARAMS;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class GROUPPARAMSService : CrudService<GROUPPARAMS, GROUPPARAMSDto, CreateGROUPPARAMSDto, UpdateGROUPPARAMSDto, int>, IGROUPPARAMSService
{
    public GROUPPARAMSService(IRepository<GROUPPARAMS> repository)
        : base(repository, GROUPPARAMSMappingExtensions.ToDto, GROUPPARAMSMappingExtensions.ToEntity, GROUPPARAMSMappingExtensions.UpdateEntity) { }
}
