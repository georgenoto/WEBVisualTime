using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5562;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5562Controller : CrudApiController<TABLE5562Dto, CreateTABLE5562Dto, UpdateTABLE5562Dto, int>
{
    public TABLE5562Controller(ITABLE5562Service service) : base(service, dto => dto.NCASH_OPERTYP) { }
}
