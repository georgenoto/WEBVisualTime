using WEBVisualTime.Servicios.Insudb.DTOs.PROVISION_TYPE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class PROVISION_TYPEController : CrudApiController<PROVISION_TYPEDto, CreatePROVISION_TYPEDto, UpdatePROVISION_TYPEDto, int>
{
    public PROVISION_TYPEController(IPROVISION_TYPEService service) : base(service, dto => dto.NIDPROVISIONTYPE) { }
}
