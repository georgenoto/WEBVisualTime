using WEBVisualTime.Servicios.Insudb.DTOs.TABLE210;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE210Controller : CrudApiController<TABLE210Dto, CreateTABLE210Dto, UpdateTABLE210Dto, int>
{
    public TABLE210Controller(ITABLE210Service service) : base(service, dto => dto.NCLA_LI_TYP) { }
}
