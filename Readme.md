TankDriver [![Status Umbra][status-umbra]][andivionian-status-classifier] [![Appveyor build status][appveyor-status]][appveyor] [![Travis build status][travis-status]][travis]
==========

This is a simple game written with [MonoGame][monogame].


Build
-----

To prepare some image resources, you'lln need [ImageMagick][imagemagick]
installed and its' executable files available in `PATH` environment variable.

### Windows

Either use [Visual Studio][visual-studio] to open and build `TankDriver.sln`
file, or invoke the following commands in developer console:

```console
> nuget restore
> msbuild
```

### Linux

You'll need [Mono][mono] and [NuGet][nuget] installed.

```console
$ nuget restore
$ xbuild
```

#### NixOS

There's a ready nix-shell environment in `default.nix`. Just invoke the
following:

```console
$ nix-shell
$ nuget restore
$ xbuild
```

Requires NixOS 16.09+

Run
---

To run the game on Windows, execute the following commands:

```console
> cd TankDriver.App\bin\Debug
> .\TankDriver.App.exe
```

On Linux:

```console
$ cd TankDriver.App/bin/Debug
$ mono ./TankDriver.App.exe
```

### Program arguments

Use the `--console` flag if you don't want the game to hide the console window
after start (Windows-specific).

Test
----

This project uses [xUnit.net][xunit] test library. This library provides
multiple runners and adapters for various IDE; you're recommended to use
whatever fits you better.

The default cross-platform option is to use `xunit.runner.console` NuGet package
to execute tests from `TankDriver.Tests` assembly. It can be done with the
following commands on Windows:

```console
> .\packages\xunit.runner.console.2.1.0\tools\xunit.console.exe .\TankDriver.Tests\bin\Debug\TankDriver.Tests.dll
```

Or the following commands on Linux:

```console
$ mono ./packages/xunit.runner.console.2.1.0/tools/xunit.console.exe ./TankDriver.Tests/bin/Debug/TankDriver.Tests.dll
```

License
-------

All the source code of this project is distributed under the MIT license. Check
[License.md][license] for more information.

All the accompanying image files are licensed under a [Creative Commons
Attribution 4.0 International License][cc-by-license].

[license]: License.md

[andivionian-status-classifier]: https://github.com/ForNeVeR/andivionian-status-classifier#status-umbra-
[appveyor]: https://ci.appveyor.com/project/ForNeVeR/tankdriver/branch/develop
[cc-by-license]: https://creativecommons.org/licenses/by/4.0/
[mono]: http://www.mono-project.com/
[monogame]: http://www.monogame.net/
[nuget]: https://www.nuget.org/
[travis]: https://travis-ci.org/ForNeVeR/TankDriver
[visual-studio]: https://www.visualstudio.com/
[xunit]: https://xunit.github.io/

[appveyor-status]: https://ci.appveyor.com/api/projects/status/486qc2gl6m18pbvn/branch/develop?svg=true
[status-umbra]: https://img.shields.io/badge/status-umbra-red.svg
[travis-status]: https://travis-ci.org/ForNeVeR/TankDriver.svg?branch=develop
