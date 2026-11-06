using WEBVisualTime.Servicios.Insudb.DTOs.TABLE215;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE215Controller : CrudApiController<TABLE215Dto, CreateTABLE215Dto, UpdateTABLE215Dto, int>
{
    public TABLE215Controller(ITABLE215Service service) : base(service, dto => dto.NSTATUS_ORD) { }
}
