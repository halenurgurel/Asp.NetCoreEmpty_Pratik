var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //MVC Servislerini ekledim.

var app = builder.Build();

app.UseStaticFiles(); //Statik dosyalar�n�n kullan�m�n�n Belirtilmesi. Ama�: wwwroot klas�r�ndeki css, js, resim gibi dosyalar�n eri�ilebilir olmas�n� sa�lamak.

app.UseRouting(); //Gelen isteklerin (URL'lerin) do�ru Controller ve Action'a y�nlendirilmesini sa�lamak

//Kullan�c� taray�c�da herhangi bir adres yazd���nda, isteklerin HomeController i�indeki Index action�na gitmesini sa�lamak
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"

    );

app.Run();

// -------------------------- Kavram A��klamalar� --------------------------

// Controller: Web uygulamas�nda gelen istekleri kar��layan, i� mant���n� y�neten s�n�ft�r. Genellikle Action metotlar�n� i�erir.
// Action: Controller i�indeki, taray�c�dan gelen belirli bir iste�i (�rn: /Home/Index) kar��layan metottur.
// Model: Uygulamada i�lenen/veritaban�ndan gelen veriyi ve veri kurallar�n� temsil eden s�n�ft�r. View'a veri ta��mada kullan�l�r.
// View: Kullan�c�ya g�sterilecek HTML sayfas�n� tan�mlar. Genellikle .cshtml uzant�l� dosyalard�r

