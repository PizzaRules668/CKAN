﻿using System.Reflection;

[assembly: AssemblyProduct("CKAN")]
[assembly: AssemblyCompany("CKAN Contributors")]
[assembly: AssemblyCopyright("Copyright © 2014–2022")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
