using System.Runtime.InteropServices;
using NUnit.Framework;

// In SDK-style projects such as this one, several assembly attributes that were historically
// defined in this file are now automatically added during build and populated with
// values defined in project properties. For details of which attributes are included
// and how to customise this process see: https://aka.ms/assembly-info-properties


// Setting ComVisible to false makes the types in this assembly not visible to COM
// components.  If you need to access a type in this assembly from COM, set the ComVisible
// attribute to true on that type.

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM.

[assembly: Guid("f8e1a94f-96e8-4feb-8e28-288a91486107")]

[assembly: Parallelizable(ParallelScope.Fixtures)]                             //will run fixtures
[assembly:LevelOfParallelism(4)]                                               //4 files at a time