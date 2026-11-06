using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9235;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9235Controller : CrudApiController<TABLE9235Dto, CreateTABLE9235Dto, UpdateTABLE9235Dto, string>
{
    public TABLE9235Controller(ITABLE9235Service service) : base(service, dto => dto.STYPDIS_PAYPERCEN) { }
}
