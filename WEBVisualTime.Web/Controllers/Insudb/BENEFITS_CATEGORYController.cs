using WEBVisualTime.Servicios.Insudb.DTOs.BENEFITS_CATEGORY;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BENEFITS_CATEGORYController : CatalogController<BENEFITS_CATEGORYDto, CreateBENEFITS_CATEGORYDto, UpdateBENEFITS_CATEGORYDto, int>
{
    public BENEFITS_CATEGORYController(IBENEFITS_CATEGORYService service)
        : base(service, "BENEFITS_CATEGORY", "NBENEFCATEG", new[] { "NBENEFCATEG", "SDESCRIPT", "SSHORT_DES", "STABLEASOC", "SSTATREGT", "NUSERCODE", "DCOMPDATE" }) { }
}
