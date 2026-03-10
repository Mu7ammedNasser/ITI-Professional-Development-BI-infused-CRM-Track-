namespace MVC_Day07_lab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Add services to the container. IOC Container
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            #endregion


            var app = builder.Build();

            #region pipe lines

            app.Use(async (HttpContext, next) =>
            {
                // do something before the next middleware

                await HttpContext.Response.WriteAsync("1) Hello from the middleware number 1 \n");

                await next.Invoke(); // call the next middleware
                // do something after the next middleware
                await HttpContext.Response.WriteAsync("3) Hello from the middleware number 1 \n");
            });

            app.Use(async (HttpContext, next) =>
            {
                // do something before the next middleware

                await HttpContext.Response.WriteAsync("2) Hello from the middleware number 1 \n");

                await next.Invoke(); // call the next middleware
                // do something after the next middleware
                await HttpContext.Response.WriteAsync("4) Hello from the middleware number 1 \n");
            });

            app.Run(async (HttpContext) =>
            {
                // this is the last middleware in the pipeline even if we add more middlewares after this one it will not be executed because this middleware is using Run method which means that it will not call the next middleware in the pipeline
                await HttpContext.Response.WriteAsync("5) Hello from the middleware number 1 \n");
            });

            app.Use(async (HttpContext, next) =>
            {
                // do something before the next middleware

                await HttpContext.Response.WriteAsync("6) Hello from the middleware number 1 \n");

                await next.Invoke(); // call the next middleware
                // do something after the next middleware
                await HttpContext.Response.WriteAsync("7) Hello from the middleware number 1 \n");
            });

            //// Configure the HTTP request pipeline.
            //if (!app.Environment.IsDevelopment())
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //}

            //app.UseHttpsRedirection();
            //app.UseRouting();

            //app.UseAuthorization();

            //app.MapStaticAssets();
            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}")
            //    .WithStaticAssets();
            #endregion


            // this will start the application
            app.Run();
        }
    }
}
