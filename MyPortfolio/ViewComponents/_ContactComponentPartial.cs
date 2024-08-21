using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    // ViewComponent sınıfını kalıtan bir ViewComponent sınıfı oluşturuyoruz.
    // Bu, ContactComponentPartial adında bir View bileşeni.
    public class _ContactComponentPartial : ViewComponent
    {
        // Invoke metodu, bu View bileşeninin çalıştırılması durumunda çağrılır.
        // IViewComponentResult türünde bir sonuç döndürüyoruz.
        public IViewComponentResult Invoke()
        {
            // View metodu, belirli bir görünümün sonucunu döndürür.
            // Bu durumda, hiçbir parametre almadan çağrılan View metodu, 
            // ContactComponentPartial adındaki görünümü döndürüyor.
            return View();
        }
    }
}
