using WEBVisualTime.Servicios.Insudb.DTOs.TABLE108;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE108Controller : CrudApiController<TABLE108Dto, CreateTABLE108Dto, UpdateTABLE108Dto, string>
{
    public TABLE108Controller(ITABLE108Service service) : base(service, dto => dto.SPERIODTYP) { }
}
