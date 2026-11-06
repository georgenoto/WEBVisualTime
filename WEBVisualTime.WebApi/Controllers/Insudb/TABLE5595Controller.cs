using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5595;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5595Controller : CrudApiController<TABLE5595Dto, CreateTABLE5595Dto, UpdateTABLE5595Dto, int>
{
    public TABLE5595Controller(ITABLE5595Service service) : base(service, dto => dto.NELECPROT) { }
}
