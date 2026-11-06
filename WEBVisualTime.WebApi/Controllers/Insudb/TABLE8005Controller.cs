using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8005;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8005Controller : CrudApiController<TABLE8005Dto, CreateTABLE8005Dto, UpdateTABLE8005Dto, int>
{
    public TABLE8005Controller(ITABLE8005Service service) : base(service, dto => dto.NTYPETABLE) { }
}
