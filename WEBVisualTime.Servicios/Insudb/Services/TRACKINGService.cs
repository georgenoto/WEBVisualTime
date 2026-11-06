using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TRACKING;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TRACKINGService : CrudService<TRACKING, TRACKINGDto, CreateTRACKINGDto, UpdateTRACKINGDto, int>, ITRACKINGService
{
    public TRACKINGService(IRepository<TRACKING> repository)
        : base(repository, TRACKINGMappingExtensions.ToDto, TRACKINGMappingExtensions.ToEntity, TRACKINGMappingExtensions.UpdateEntity) { }
}
