//Install Serilog.AspNetCore package
builder.Host.UseSerilog((context, configuration) =>
	configuration.ReadFrom.Configuration(context.Configuration)
);

app.UseSerilogRequestLogging();
