using WEBVisualTime.Servicios.Insudb.DTOs.TAB_DENTITION;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_DENTITIONController : CatalogController<TAB_DENTITIONDto, CreateTAB_DENTITIONDto, UpdateTAB_DENTITIONDto, int>
{
    public TAB_DENTITIONController(ITAB_DENTITIONService service)
        : base(service, "TAB_DENTITION", "NIDDENTITION", new[] { "NIDDENTITION", "SADA", "SFDI", "NTHETH", "NQUADRANT", "NARCADE", "STOOTHNAM", "SPALATINE", "SLINGUAL", "SVESTIBULAR", "SMESIAL", "SDISTAL", "SINCISAL", "SOCLUSAL", "SLABIAL", "DCOMPDATE", "NUSERCODE" }) { }
}
