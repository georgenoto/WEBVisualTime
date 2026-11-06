using WEBVisualTime.Servicios.Insudb.DTOs.TABLE3022;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE3022Controller : CrudApiController<TABLE3022Dto, CreateTABLE3022Dto, UpdateTABLE3022Dto, int>
{
    public TABLE3022Controller(ITABLE3022Service service) : base(service, dto => dto.NENDORSEOWN) { }
}
