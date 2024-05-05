# Setup of the TodoApp
1. Add Data Source to appsettings.json, change Initial Catalog name if needed
2. Open TodoApp solution in Visual Studio 2022
3. Inside package manager console run:</br>
Add-Migration initial</br>
Update-Database
4. Run app

# Desciption
This Todo List was created with the MVC project template in Visual Studio 2022. Additionally installed EntityFrameworkCore, EntityFrameworkCore.SQLServer, EntityFrameworkCore.Tools using NuGet package manager. Vue.js was added from a CDN via a script tag inside the _Layout view file for the whole project and used in views following the official VueJS quick start guide.

# Resources
ASP.NET Core 6.0 Code first approach using Entity Framework: https://youtu.be/C58cvqHjYVY?si=FaAaAHPzklitTxYX </br>
VueJS quick start guide: https://vuejs.org/guide/quick-start </br>
Why to pick VueJS for ASP.NET Core: https://www.giftoasis.com/blog/asp-net-core/vue/why-i-picked-vuejs-for-aspnet-core-web-development </br>
https://www.giftoasis.com/blog/asp-net-core/vue/using-vue-with-asp-net-razor-can-be-great </br>
ASP.NET Core with VueJS: https://www.genesisrrios.com/en/blog/using-asp-net-core-with-vue-js/ </br>
