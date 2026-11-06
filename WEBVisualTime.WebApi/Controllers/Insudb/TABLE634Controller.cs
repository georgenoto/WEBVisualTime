using WEBVisualTime.Servicios.Insudb.DTOs.TABLE634;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE634Controller : CrudApiController<TABLE634Dto, CreateTABLE634Dto, UpdateTABLE634Dto, int>
{
    public TABLE634Controller(ITABLE634Service service) : base(service, dto => dto.NBRANCH_GEN) { }
}
