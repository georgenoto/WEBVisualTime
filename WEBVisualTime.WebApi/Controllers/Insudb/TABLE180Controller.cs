using WEBVisualTime.Servicios.Insudb.DTOs.TABLE180;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE180Controller : CrudApiController<TABLE180Dto, CreateTABLE180Dto, UpdateTABLE180Dto, long>
{
    public TABLE180Controller(ITABLE180Service service) : base(service, dto => dto.NFOR_PAY) { }
}
