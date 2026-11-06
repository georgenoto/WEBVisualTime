using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9207;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9207Controller : CrudApiController<TABLE9207Dto, CreateTABLE9207Dto, UpdateTABLE9207Dto, int>
{
    public TABLE9207Controller(ITABLE9207Service service) : base(service, dto => dto.NDISSUR_TYPE) { }
}
