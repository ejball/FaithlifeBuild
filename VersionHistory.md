# Version History

## Pending

Describe changes here when they're committed to the `master` branch. Move them to **Released** when the project version number is updated in preparation for publishing an updated NuGet package.

Prefix the description of the change with `[major]`, `[minor]`, or `[patch]` in accordance with [Semantic Versioning](https://semver.org/).

## Released

### 2.2.0

* [minor] Add `DotNetBuildProperties.ExtraProperties`.
* [patch] Delete package if it already exists.

### 2.1.4

* [patch] Delete files before running `dotnet clean`.

### 2.1.3

* [patch] Don't use the "pager" for help.

### 2.1.2

* [patch] `dotnet push` doesn't support `-maxcpucount`.

### 2.1.1

* [patch] `dotnet restore` needs platform to work correctly.

### 2.1.0

* [minor] Support `DotNetBuildSettings.MaxCpuCount`.
* [patch] Run `dotnet clean` or equivalent when cleaning solution.

### 2.0.3

* [patch] Upgrade `sourcelink`.

### 2.0.2

* [patch] Don't fail build if packagediff crashes.

### 2.0.1

* [patch] Don't fail build on bad package version until publishing.

### 2.0.0

* [minor] Support setting the automated build number.
* [major] Return exit code from app runners.
* [patch] Use [`packagediff`](https://www.nuget.org/packages/Faithlife.PackageDiffTool.Tool) to check semantic versioning.

### 1.3.0

* [minor] Support setting the working directory when running apps.
* [patch] Run `dotnet vstest` from the output directory (for Mac).

### 1.2.0

* [minor] Support finding test assemblies explicitly.
* [minor] Support cloning the settings.
* [patch] Restore packages using the correct configuration and platform when using MSBuild.

### 1.1.0

* [minor] Support specifying solution platform (via setting and/or command-line option).

### 1.0.2

* [patch] MSBuild is not a .NET Framework app.

### 1.0.1

* [patch] Try to find MSBuild on macOS and Linux.

### 1.0.0

* [major] Wrap MSBuildVersion and MSBuildPlatform into MSBuildSettings.

### 0.10.0

* [patch] Support `XmlDocTarget` for documentation generation.
* [minor] Support building with MSBuild.

### 0.9.0

* [minor] Support additional publish triggers for .NET builds.
* [minor] Support `--no-color` option.

### 0.8.0

* [minor] Support custom sources for `DotNetTools`.

### 0.7.1

* [patch] Restore doesn't support configuration.

### 0.7.0

* [minor] Update XmlDocMarkdown.
* [minor] Add restore target to DotNetBuild.

### 0.6.0

* [minor] Add `FindFilesFrom` and `FindDirectoriesFrom` to `BuildUtility`.
* [minor] Globs should use case-insensitive matching.
* [patch] Don't return the same found file/directory twice.
* [minor] `BuildUtility.CopyFiles` uses globs to copy files.
* [minor] Run MSBuild via `MSBuildRunner`.
* [minor] Support running tools from NuGet packages via `PackagedTools`.
* [minor] Support `IEnumerable<string> args`.
* [patch] Handle `InvalidUsageException`.

### 0.5.0

* [minor] Don't document default target unless it has a description.
* [minor] Add `DotNetBuildSettings.ProjectUsesSourceLink`.
* [minor] Update XmlDocMarkdown.

### 0.4.1

* [patch] Make private method public.

### 0.4.0

* [minor] Use `DotNetBuildOptions` to access and/or override build options.
* [minor] Automatically run any target named `default`.
* [minor] Return existing target; allow multiple actions per target.
* [minor] Don't crash if a packaged project doesn't output a DLL.
* [minor] Support `update-docs` publish trigger for .NET builds.
* [minor] Add `BuildEnvironment` and .NET Framework app support.

### 0.3.1

* Support publishing multiple NuGet packages.
* Catch exceptions from Bullseye.

### 0.3.0

* Support `--nuget-output` with .NET builds.
* Use the `xmldocmd` .NET Core Global Tool to generate documentation.
* Use fixed but customizable versions of .NET Core Global Tools for stable builds.

### 0.2.0

* Use `DotNetTools` to run .NET Core tools.
* Change settings for documentation generation.
* Generate documentation in `docs` folder instead of `gh_pages` branch.

### 0.1.1

* Upgrade dependencies (especially Glob, which now targets `netstandard2.0`).

### 0.1.0

* Initial release.
