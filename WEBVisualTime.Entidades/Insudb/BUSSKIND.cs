#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class BUSSKIND
{
    public string SCOMPLCOD { get; set; }
    public string SDESCRIPT { get; set; }
    public string SSHORT_DES { get; set; }
    public string SSTATREGT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int NBUSINESSTY { get; set; }

    [ForeignKey("NBUSINESSTY")]
    public Insudb.TYPEPERGROUP? TYPEPERGROUPNBUSINESSTY { get; set; }
    public int NCOMMERGRP { get; set; }

    [ForeignKey("NCOMMERGRP")]
    public Insudb.TYPEPERGROUP? TYPEPERGROUPNCOMMERGRP { get; set; }
    public int NCODKIND { get; set; }
}
