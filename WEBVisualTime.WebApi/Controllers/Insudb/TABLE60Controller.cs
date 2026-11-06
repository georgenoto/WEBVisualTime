using WEBVisualTime.Servicios.Insudb.DTOs.TABLE60;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE60Controller : CrudApiController<TABLE60Dto, CreateTABLE60Dto, UpdateTABLE60Dto, long>
{
    public TABLE60Controller(ITABLE60Service service) : base(service, dto => dto.NPAYCONRE) { }
}
