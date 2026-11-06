using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_COLLECTCOMM;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TAB_COLLECTCOMMService : CrudService<TAB_COLLECTCOMM, TAB_COLLECTCOMMDto, CreateTAB_COLLECTCOMMDto, UpdateTAB_COLLECTCOMMDto, int>, ITAB_COLLECTCOMMService
{
    public TAB_COLLECTCOMMService(IRepository<TAB_COLLECTCOMM> repository)
        : base(repository, TAB_COLLECTCOMMMappingExtensions.ToDto, TAB_COLLECTCOMMMappingExtensions.ToEntity, TAB_COLLECTCOMMMappingExtensions.UpdateEntity) { }
}
