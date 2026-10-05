#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLIENT_EVALRISK
{
    public string SCLIENT { get; set; }
    public DateTime? DEFFECDATE { get; set; }
    public DateTime? DOTHERDATE { get; set; }
    public int NSINCEYEAR { get; set; }

    [ForeignKey("NSINCEYEAR")]
    public Insudb.TABLE9010? TABLE9010 { get; set; }
    public int? NNUMEMPLOYERS { get; set; }
    public int NCNTRYRISK { get; set; }

    [ForeignKey("NCNTRYRISK")]
    public Insudb.TABLE9011? TABLE9011 { get; set; }
    public int NTYPECIA { get; set; }

    [ForeignKey("NTYPECIA")]
    public Insudb.TABLE9012? TABLE9012 { get; set; }
    public int NTYPEPRODUCT { get; set; }

    [ForeignKey("NTYPEPRODUCT")]
    public Insudb.TABLE9013? TABLE9013 { get; set; }
    public int NRISK { get; set; }

    [ForeignKey("NRISK")]
    public Insudb.TABLE9014? TABLE9014 { get; set; }
    public int NACTBUS { get; set; }

    [ForeignKey("NACTBUS")]
    public Insudb.TABLE9015? TABLE9015 { get; set; }
    public int NREFBANK { get; set; }

    [ForeignKey("NREFBANK")]
    public Insudb.TABLE9016? TABLE9016 { get; set; }
    public int NREFBUS { get; set; }

    [ForeignKey("NREFBUS")]
    public Insudb.TABLE9017? TABLE9017 { get; set; }
    public int NREFLAW { get; set; }

    [ForeignKey("NREFLAW")]
    public Insudb.TABLE9018? TABLE9018 { get; set; }
    public int NNUMPAYS { get; set; }

    [ForeignKey("NNUMPAYS")]
    public Insudb.TABLE9019? TABLE9019 { get; set; }
    public int NOLDINSURANCE { get; set; }

    [ForeignKey("NOLDINSURANCE")]
    public Insudb.TABLE9020? TABLE9020 { get; set; }
    public int NPROPAY { get; set; }

    [ForeignKey("NPROPAY")]
    public Insudb.TABLE9021? TABLE9021 { get; set; }
    public int? NCODDICOM { get; set; }
    public string? SDESDICOM { get; set; }
    public int NCREDITREASON { get; set; }

    [ForeignKey("NCREDITREASON")]
    public Insudb.TABLE9022? TABLE9022 { get; set; }
    public int NLIQCURRENT { get; set; }

    [ForeignKey("NLIQCURRENT")]
    public Insudb.TABLE9023? TABLE9023 { get; set; }
    public int NLIQACD { get; set; }

    [ForeignKey("NLIQACD")]
    public Insudb.TABLE9024? TABLE9024 { get; set; }
    public int NRENTABILITY { get; set; }

    [ForeignKey("NRENTABILITY")]
    public Insudb.TABLE9025? TABLE9025 { get; set; }
    public int NGROWSALES { get; set; }

    [ForeignKey("NGROWSALES")]
    public Insudb.TABLE9026? TABLE9026 { get; set; }
    public int NECONOMIC { get; set; }

    [ForeignKey("NECONOMIC")]
    public Insudb.TABLE9027? TABLE9027 { get; set; }
    public int NFINANCIAL { get; set; }

    [ForeignKey("NFINANCIAL")]
    public Insudb.TABLE9028? TABLE9028 { get; set; }
    public int NCODRATING { get; set; }

    [ForeignKey("NCODRATING")]
    public Insudb.TABLE9029? TABLE9029 { get; set; }
    public int NDESRATING { get; set; }

    [ForeignKey("NDESRATING")]
    public Insudb.TABLE9030? TABLE9030 { get; set; }
    public int NCOUNTRY { get; set; }

    [ForeignKey("NCOUNTRY")]
    public Insudb.TABLE66? TABLE66 { get; set; }
    public string? SNOTE1 { get; set; }
    public string? SNOTE2 { get; set; }
    public string? SNOTE3 { get; set; }
    public string? SNOTE4 { get; set; }
    public int NBRANCHCIA { get; set; }

    [ForeignKey("NBRANCHCIA")]
    public Insudb.TABLE9031? TABLE9031 { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public decimal? NLIMITCREDIT { get; set; }
    public int? NCURRENCY { get; set; }
}
