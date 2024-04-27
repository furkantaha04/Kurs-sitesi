using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace KursSitesi.Models 
{
 public class CandiDate
 {
  [Required(ErrorMessage ="E-Mail kismini doldurunuz.")] 

   public string? Eamil {get; set;}  = string.Empty;  //string? = null deger ataması yapar bir şey yazmazssan içi bos kalır.
   [Required(ErrorMessage ="İsim  kismini doldurunuz.")] 
    public string? Adi {get; set;}  = string.Empty;    //ToUpper = buyutmeye yarar.
    [Required(ErrorMessage ="Soy-Adi kismini doldurunuz.")] 
     public string? SoyAdi {get; set;}  = string.Empty;  
       
     public string? TamAdSoyAd => $"{Adi} {SoyAdi?.ToUpper()}";
     public int? Yasi {get; set;} 
     public string? SectigiKurs {get; set;} = string.Empty;
      public DateTime BasvuruTarihi {get; set;}
    public CandiDate()
   {
    BasvuruTarihi = DateTime.Now;    //Başvurduğu şimdiki tarihini veir.
    }
}
}