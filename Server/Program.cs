using Microsoft.AspNetCore.Builder;

namespace Server
{
	internal class Program
	{
		public static void Main( string [] args )
		{
			WebApplicationBuilder? builder = WebApplication.CreateBuilder( args );
			WebApplication? app = builder.Build( );

			app.MapGet( pattern: "/" , () => "Hello World!" );

			app.Run( );
		}
	}
}