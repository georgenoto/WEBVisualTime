using WEBVisualTime.Servicios.Insudb.DTOs.SECUR_SCHE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class SECUR_SCHEController : CrudApiController<SECUR_SCHEDto, CreateSECUR_SCHEDto, UpdateSECUR_SCHEDto, string>
{
    public SECUR_SCHEController(ISECUR_SCHEService service) : base(service, dto => dto.SSCHE_CODE) { }
}
