using WEBVisualTime.Servicios.Insudb.DTOs.MEDICAL_SURCHARGE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class MEDICAL_SURCHARGEController : CrudApiController<MEDICAL_SURCHARGEDto, CreateMEDICAL_SURCHARGEDto, UpdateMEDICAL_SURCHARGEDto, int>
{
    public MEDICAL_SURCHARGEController(IMEDICAL_SURCHARGEService service) : base(service, dto => dto.NSURCHAR_MED) { }
}
