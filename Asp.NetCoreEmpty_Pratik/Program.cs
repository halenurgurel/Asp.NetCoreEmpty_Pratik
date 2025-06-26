var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //MVC Servislerini ekledim.

var app = builder.Build();

app.UseStaticFiles(); //Statik dosyalarýnýn kullanýmýnýn Belirtilmesi. Amaç: wwwroot klasöründeki css, js, resim gibi dosyalarýn eriþilebilir olmasýný saðlamak.

app.UseRouting(); //Gelen isteklerin (URL'lerin) doðru Controller ve Action'a yönlendirilmesini saðlamak

//Kullanýcý tarayýcýda herhangi bir adres yazdýðýnda, isteklerin HomeController içindeki Index actionýna gitmesini saðlamak
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"

    );

app.Run();

// -------------------------- Kavram Açýklamalarý --------------------------

// Controller: Web uygulamasýnda gelen istekleri karþýlayan, iþ mantýðýný yöneten sýnýftýr. Genellikle Action metotlarýný içerir.
// Action: Controller içindeki, tarayýcýdan gelen belirli bir isteði (örn: /Home/Index) karþýlayan metottur.
// Model: Uygulamada iþlenen/veritabanýndan gelen veriyi ve veri kurallarýný temsil eden sýnýftýr. View'a veri taþýmada kullanýlýr.
// View: Kullanýcýya gösterilecek HTML sayfasýný tanýmlar. Genellikle .cshtml uzantýlý dosyalardýr

