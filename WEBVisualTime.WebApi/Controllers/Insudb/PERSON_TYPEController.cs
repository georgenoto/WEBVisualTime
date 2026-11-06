using WEBVisualTime.Servicios.Insudb.DTOs.PERSON_TYPE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class PERSON_TYPEController : CrudApiController<PERSON_TYPEDto, CreatePERSON_TYPEDto, UpdatePERSON_TYPEDto, long>
{
    public PERSON_TYPEController(IPERSON_TYPEService service) : base(service, dto => dto.NIDPERSONTYPE) { }
}
