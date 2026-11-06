using WEBVisualTime.Servicios.Insudb.DTOs.MEDICAL_SURCHARGE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MEDICAL_SURCHARGEController : CatalogController<MEDICAL_SURCHARGEDto, CreateMEDICAL_SURCHARGEDto, UpdateMEDICAL_SURCHARGEDto, int>
{
    public MEDICAL_SURCHARGEController(IMEDICAL_SURCHARGEService service)
        : base(service, "MEDICAL_SURCHARGE", "NSURCHAR_MED", new[] { "NSURCHAR_MED", "NPERC_SURCHAR", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
