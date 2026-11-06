using WEBVisualTime.Servicios.Insudb.DTOs.TABLE191;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE191Controller : CrudApiController<TABLE191Dto, CreateTABLE191Dto, UpdateTABLE191Dto, string>
{
    public TABLE191Controller(ITABLE191Service service) : base(service, dto => dto.SSTATLOAN) { }
}
