using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Server
{
	internal class Program
	{
		public static void Main()
		{

			WebApplicationOptions? webApplicationOptions =
				new Microsoft.AspNetCore.Builder.WebApplicationOptions
				{
					EnvironmentName =
					Microsoft.Extensions.Hosting.Environments.Development ,
				};

			WebApplicationBuilder? builder =
				WebApplication.CreateBuilder( options: webApplicationOptions );


			builder.Services.AddRazorPages( );

			WebApplication? app = builder.Build( );

			if ( app.Environment.IsDevelopment( ) )
			{
				app.UseDeveloperExceptionPage( );
			}
			else
			{
				app.UseExceptionHandler( errorHandlingPath: "/Errors/Error" );
				app.UseHsts( );
			}
			app.UseHttpsRedirection( );

			app.UseStaticFiles( );

			app.UseRouting( );

			app.MapRazorPages( );

			app.Run( );
		}
	}
}