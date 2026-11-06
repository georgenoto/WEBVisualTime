using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5516;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5516Controller : CrudApiController<TABLE5516Dto, CreateTABLE5516Dto, UpdateTABLE5516Dto, int>
{
    public TABLE5516Controller(ITABLE5516Service service) : base(service, dto => dto.NMOTIVE_ITIN) { }
}
