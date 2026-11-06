using WEBVisualTime.Servicios.Insudb.DTOs.TARIF_COLUMN;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TARIF_COLUMNController : CrudApiController<TARIF_COLUMNDto, CreateTARIF_COLUMNDto, UpdateTARIF_COLUMNDto, int>
{
    public TARIF_COLUMNController(ITARIF_COLUMNService service) : base(service, dto => dto.NID_COLUMN) { }
}
