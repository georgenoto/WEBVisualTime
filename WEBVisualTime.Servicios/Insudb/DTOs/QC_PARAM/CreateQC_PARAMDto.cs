namespace WEBVisualTime.Servicios.Insudb.DTOs.QC_PARAM;

public class CreateQC_PARAMDto
{
    public string? SINDQCOBL { get; set; }
    public int NROUTY_QC { get; set; }
    public string? SROUT_QC { get; set; }
    public int NROUTY_QCCAP { get; set; }
    public string? SROUT_QCCAP { get; set; }
    public int? NMINAGEQC { get; set; }
    public decimal? NCAPMINCC { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SSTATREG { get; set; }
    public int NUSERCODE { get; set; }
}
