using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9255;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9255Controller : CrudApiController<TABLE9255Dto, CreateTABLE9255Dto, UpdateTABLE9255Dto, int>
{
    public TABLE9255Controller(ITABLE9255Service service) : base(service, dto => dto.NCOD_INSTEDUC) { }
}
