using WEBVisualTime.Servicios.Insudb.DTOs.TABLE3022;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE3022Controller : CatalogController<TABLE3022Dto, CreateTABLE3022Dto, UpdateTABLE3022Dto, int>
{
    public TABLE3022Controller(ITABLE3022Service service)
        : base(service, "TABLE3022", "NENDORSEOWN", new[] { "NENDORSEOWN", "SDESCRIPT", "SSHORT_DES", "DCOMPDATE", "NUSERCODE", "SSTATREGT" }) { }
}
