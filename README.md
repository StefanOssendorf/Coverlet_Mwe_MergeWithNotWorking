# Coverlet_Mwe_MergeWithNotWorking
Minimum working example of MergeWith-Config not working.
The configuration setting "MergeWith" of `coverletArgs.runsettings` file is not used.


Use `dotnet test --collect:"XPlat Code Coverage" --settings coverletArgs.runsettings` or `dotnet test --settings coverletArgs.runsettings` from solution folder to run this example.