﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FSharp.Management")>]
[<assembly: AssemblyProductAttribute("FSharp.Management")>]
[<assembly: AssemblyDescriptionAttribute("Various type providers for management of the machine.")>]
[<assembly: AssemblyVersionAttribute("0.0.7")>]
[<assembly: AssemblyFileVersionAttribute("0.0.7")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.7"
