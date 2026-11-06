using WEBVisualTime.Servicios.Insudb.DTOs.TABLE99;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE99Controller : CrudApiController<TABLE99Dto, CreateTABLE99Dto, UpdateTABLE99Dto, int>
{
    public TABLE99Controller(ITABLE99Service service) : base(service, dto => dto.NTYPE_LETTER) { }
}
