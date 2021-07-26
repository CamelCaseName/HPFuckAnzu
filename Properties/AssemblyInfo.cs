using MelonLoader;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AnzuRemover")]
[assembly: AssemblyDescription("removes the ads")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("AnzuRemover")]
[assembly: AssemblyCopyright("CamelCaseName ©  2021")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("221bc4ca-1e6f-4724-b05a-2cf3fccf78ab")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

//MelonLoader relies on assembly info to get your mod description. We will have to setup them up.
//To do that, go to the Properties directory, and add these three lines to AssemblyInfo.cs
[assembly: MelonInfo(typeof(Project.HPFuckAnzu), "HPFuckAnzu", "1.0.0", "CamelCaseName")]
[assembly: MelonGame("Eek", "House Party")]
[assembly: VerifyLoaderVersion(0, 4, 0, true)]