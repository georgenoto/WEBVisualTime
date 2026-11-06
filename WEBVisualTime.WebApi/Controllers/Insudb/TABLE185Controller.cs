using WEBVisualTime.Servicios.Insudb.DTOs.TABLE185;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE185Controller : CrudApiController<TABLE185Dto, CreateTABLE185Dto, UpdateTABLE185Dto, int>
{
    public TABLE185Controller(ITABLE185Service service) : base(service, dto => dto.NFINANSTAT) { }
}
