using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5005;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5005Controller : CrudApiController<TABLE5005Dto, CreateTABLE5005Dto, UpdateTABLE5005Dto, int>
{
    public TABLE5005Controller(ITABLE5005Service service) : base(service, dto => dto.NCANCEL_COD) { }
}
