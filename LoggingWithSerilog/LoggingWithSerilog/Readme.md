docker run -d --restart unless-stopped --name seq -e ACCEPT_EULA=Y -v E:\Logs:/data -p 8081:80 datalust/seq:latest
#  <ItemGroup>
    <PackageReference Include="Microsoft.Extensions.Logging.Configuration" Version="7.0.0" />
    <PackageReference Include="Serilog" Version="2.12.0" />
    <PackageReference Include="Serilog.AspNetCore" Version="6.1.0" />
    <PackageReference Include="Serilog.Enrichers.Environment" Version="2.2.0" />
    <PackageReference Include="Serilog.Enrichers.Process" Version="2.0.2" />
    <PackageReference Include="Serilog.Enrichers.Thread" Version="3.1.0" />
    <PackageReference Include="Serilog.Settings.Configuration" Version="3.4.0" />
    <PackageReference Include="Serilog.Sinks.Seq" Version="5.2.2" />
  </ItemGroup>