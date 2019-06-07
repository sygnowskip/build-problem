# build-problem
Show the build problem between VS 2019 / VS 2017 / Rider / .NET CLI

Build status:
* VS 2019 - Success
* VS 2017 - Fail
* Rider 2019.x - Fail
* .NET CLI - Fail

Why?! :)

ERROR:

Build FAILED.

Validation.cs(21,18): error CS0121: The call is ambiguous between the following methods or properties: 'AsyncResultExtensionsRightOperand.Ensure(Result, Func<Task<bool>>, string)' and 'ResultExtensions.Ensure(Result, Func<bool>, string)' [.\build-problem\Test.csproj]
    0 Warning(s)
    1 Error(s)

Time Elapsed 00:00:00.91