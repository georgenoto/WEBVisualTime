using WEBVisualTime.Servicios.Insudb.DTOs.TARIF_COLUMN;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TARIF_COLUMNController : CatalogController<TARIF_COLUMNDto, CreateTARIF_COLUMNDto, UpdateTARIF_COLUMNDto, int>
{
    public TARIF_COLUMNController(ITARIF_COLUMNService service)
        : base(service, "TARIF_COLUMN", "NID_COLUMN", new[] { "NID_COLUMN", "STABLE", "SCOLUMN", "SNAME_COL", "NDATA_TYPE", "NSIZE", "NDECIMAL", "NUSERCODE", "DCOMPDATE", "STABLEFK" }) { }
}
