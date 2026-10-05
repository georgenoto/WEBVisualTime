namespace WEBVisualTime.Servicios.Insudb.DTOs.USERS;

public class UpdateUSERSDto
{
    public int NUSERCODE { get; set; }
    public string? SACCESSWO { get; set; }
    public int NOFFICE { get; set; }
    public string SCLIENT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SINITIALS { get; set; }
    public string SSCHE_CODE { get; set; }
    public string SSTATREGT { get; set; }
    public string? STYPE { get; set; }
    public int NDEPARTME { get; set; }
    public string? SMENU { get; set; }
    public string? SCHNEXTLOGON { get; set; }
    public string? SNEVERCHANGE { get; set; }
    public string? SNEVEREXPIRES { get; set; }
    public string? SLOCKEDOUT { get; set; }
    public DateTime? DFROMDATE { get; set; }
    public int NOFFICEAGEN { get; set; }
    public int NAGENCY { get; set; }
    public int? NFAILED_LOGON_ATTEMPTS { get; set; }
    public DateTime? DPASSWORD_EXPIRES { get; set; }
}
