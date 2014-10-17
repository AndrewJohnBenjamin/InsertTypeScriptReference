// Guids.cs
// MUST match guids.h
using System;

namespace TypescriptTools
{
    static class GuidList
    {
        public const string guidInsert_Typescript_ReferencePkgString = "3c4e6308-9f77-4358-89d8-73706b1544a8";
        public const string guidInsert_Typescript_ReferenceCmdSetString = "1679fa06-40ec-473c-996c-4da2ea703e4e";

        public static readonly Guid guidInsert_Typescript_ReferenceCmdSet = new Guid(guidInsert_Typescript_ReferenceCmdSetString);
    };
}