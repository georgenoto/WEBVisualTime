using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8016;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8016Controller : CrudApiController<TABLE8016Dto, CreateTABLE8016Dto, UpdateTABLE8016Dto, int>
{
    public TABLE8016Controller(ITABLE8016Service service) : base(service, dto => dto.NTYPMOV_GUAR) { }
}
