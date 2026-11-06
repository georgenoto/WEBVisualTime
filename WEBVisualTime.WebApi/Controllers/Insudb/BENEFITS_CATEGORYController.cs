using WEBVisualTime.Servicios.Insudb.DTOs.BENEFITS_CATEGORY;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class BENEFITS_CATEGORYController : CrudApiController<BENEFITS_CATEGORYDto, CreateBENEFITS_CATEGORYDto, UpdateBENEFITS_CATEGORYDto, int>
{
    public BENEFITS_CATEGORYController(IBENEFITS_CATEGORYService service) : base(service, dto => dto.NBENEFCATEG) { }
}
