using Spectre.Console;

WriteLine("Hello, World!");
SectionTitle("Handling cross-platform environments and filesystems");

Table table = new();
table.AddColumn("[blue]MEMBER[/]");
table.AddColumn("[blue]Value[/]");

table.AddRow("Path.PathSeparator", PathSeparator.ToString());
table.AddRow("Path.DirectorySeparatorChar", Path.DirectorySeparatorChar.ToString());
table.AddRow("Directory.GetCurrentDirectory", Directory.GetCurrentDirectory());
table.AddRow("Environment.CurrentDirectory", Environment.CurrentDirectory);
table.AddRow("Environment.SystemDirectory", Environment.SystemDirectory);
table.AddRow("Path.GetTempPath", Path.GetTempPath());
table.AddRow("");
table.AddRow("GetFolderPath(SpecialFolder", "");
table.AddRow("    .System", Environment.GetFolderPath(Environment.SpecialFolder.System));
table.AddRow(
    "   .Applications",
    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
);
table.AddRow("   MyDocuments", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
table.AddRow("   Personal", Environment.GetFolderPath(Environment.SpecialFolder.Personal));

AnsiConsole.Write(table);
