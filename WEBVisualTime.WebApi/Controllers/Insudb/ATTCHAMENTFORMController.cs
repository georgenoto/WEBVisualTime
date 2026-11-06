using WEBVisualTime.Servicios.Insudb.DTOs.ATTCHAMENTFORM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class ATTCHAMENTFORMController : CrudApiController<ATTCHAMENTFORMDto, CreateATTCHAMENTFORMDto, UpdateATTCHAMENTFORMDto, long>
{
    public ATTCHAMENTFORMController(IATTCHAMENTFORMService service) : base(service, dto => dto.NSEQUENCEATT) { }
}
