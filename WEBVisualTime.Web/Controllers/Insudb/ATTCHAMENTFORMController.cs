using WEBVisualTime.Servicios.Insudb.DTOs.ATTCHAMENTFORM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class ATTCHAMENTFORMController : CatalogController<ATTCHAMENTFORMDto, CreateATTCHAMENTFORMDto, UpdateATTCHAMENTFORMDto, long>
{
    public ATTCHAMENTFORMController(IATTCHAMENTFORMService service)
        : base(service, "ATTCHAMENTFORM", "NSEQUENCEATT", new[] { "NSEQUENCEATT", "SFORMID", "DCOMPDATE", "NUSERCODE" }) { }
}
