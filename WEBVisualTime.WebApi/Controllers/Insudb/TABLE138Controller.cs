using WEBVisualTime.Servicios.Insudb.DTOs.TABLE138;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE138Controller : CrudApiController<TABLE138Dto, CreateTABLE138Dto, UpdateTABLE138Dto, int>
{
    public TABLE138Controller(ITABLE138Service service) : base(service, dto => dto.NPAY_FORM) { }
}
