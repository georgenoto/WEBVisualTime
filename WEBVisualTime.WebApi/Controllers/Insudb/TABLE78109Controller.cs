using WEBVisualTime.Servicios.Insudb.DTOs.TABLE78109;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE78109Controller : CrudApiController<TABLE78109Dto, CreateTABLE78109Dto, UpdateTABLE78109Dto, int>
{
    public TABLE78109Controller(ITABLE78109Service service) : base(service, dto => dto.NSOAP_VEHTYPE) { }
}
