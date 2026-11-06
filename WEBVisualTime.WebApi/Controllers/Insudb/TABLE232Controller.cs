using WEBVisualTime.Servicios.Insudb.DTOs.TABLE232;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE232Controller : CrudApiController<TABLE232Dto, CreateTABLE232Dto, UpdateTABLE232Dto, int>
{
    public TABLE232Controller(ITABLE232Service service) : base(service, dto => dto.NCLASSMERCH) { }
}
