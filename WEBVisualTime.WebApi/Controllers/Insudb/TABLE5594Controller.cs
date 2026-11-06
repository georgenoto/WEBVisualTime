using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5594;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5594Controller : CrudApiController<TABLE5594Dto, CreateTABLE5594Dto, UpdateTABLE5594Dto, int>
{
    public TABLE5594Controller(ITABLE5594Service service) : base(service, dto => dto.NLIC_SPECIAL) { }
}
