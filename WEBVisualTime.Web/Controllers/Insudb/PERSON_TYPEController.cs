using WEBVisualTime.Servicios.Insudb.DTOs.PERSON_TYPE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PERSON_TYPEController : CatalogController<PERSON_TYPEDto, CreatePERSON_TYPEDto, UpdatePERSON_TYPEDto, long>
{
    public PERSON_TYPEController(IPERSON_TYPEService service)
        : base(service, "PERSON_TYPE", "NIDPERSONTYPE", new[] { "NIDPERSONTYPE", "SNAME", "SENABLE" }) { }
}
