using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5601;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5601Controller : CrudApiController<TABLE5601Dto, CreateTABLE5601Dto, UpdateTABLE5601Dto, int>
{
    public TABLE5601Controller(ITABLE5601Service service) : base(service, dto => dto.NCODMODPAY) { }
}
