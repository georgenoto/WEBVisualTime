using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5746;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5746Controller : CrudApiController<TABLE5746Dto, CreateTABLE5746Dto, UpdateTABLE5746Dto, int>
{
    public TABLE5746Controller(ITABLE5746Service service) : base(service, dto => dto.NTYPEMOVRH) { }
}
