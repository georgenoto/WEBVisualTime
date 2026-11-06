using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9247;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9247Controller : CrudApiController<TABLE9247Dto, CreateTABLE9247Dto, UpdateTABLE9247Dto, int>
{
    public TABLE9247Controller(ITABLE9247Service service) : base(service, dto => dto.NFOREIGNDOCTYPE) { }
}
