using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8006;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8006Controller : CrudApiController<TABLE8006Dto, CreateTABLE8006Dto, UpdateTABLE8006Dto, int>
{
    public TABLE8006Controller(ITABLE8006Service service) : base(service, dto => dto.NTYPEAFEC) { }
}
