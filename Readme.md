TankDriver [![Status Umbra][status-umbra]][andivionian-status-classifier] [![Appveyor build status][appveyor-status]][appveyor] [![Travis build status][travis-status]][travis]
==========

This is a simple game written with [MonoGame][monogame].


Build
-----

### Windows

Either use [Visual Studio][visual-studio] to open and build `TankDriver.sln`
file, or invoke the following commands in developer console:

```console
> nuget restore
> msbuild
```

### Linux

You'll need [Mono][mono] and [Nuget][nuget] installed.

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

### Running Tests on NixOS 16.03

Please note that the tests cannot be run on Mono 4.0 because of
[xunit#158][xunit-158]. Unfortunately that's the case of NixOS
16.03. To use Mono 4.4 on NixOS 16.03 you can locally override the
Mono package. Just put the following code to your
`~/.nixpkgs/config.nix`:

```nix
{
  # ...
  packageOverrides = pkgs: rec {
    # ...
    mono = pkgs.stdenv.lib.overrideDerivation pkgs.mono (oldAttr: rec {
      version = "4.4.1.0";
      name = "mono-${version}";
      src = pkgs.fetchurl {
        url = "http://download.mono-project.com/sources/mono/${name}.tar.bz2";
        sha256 = "0jibyvyv2jy8dq5ij0j00iq3v74r0y90dcjc3dkspcfbnn37cphn";
      };
    });
    # ...
  };
  # ...
}
```

and you current user will use Mono 4.4. Please notice that it will
make NixOS compile Mono 4.4 from scratch which may take some
considerable amount of time. Around 20 minutes or so.

[andivionian-status-classifier]: https://github.com/ForNeVeR/andivionian-status-classifier#status-umbra-
[appveyor]: https://ci.appveyor.com/project/ForNeVeR/tankdriver/branch/develop
[mono]: http://www.mono-project.com/
[monogame]: http://www.monogame.net/
[nuget]: https://www.nuget.org/
[travis]: https://travis-ci.org/ForNeVeR/TankDriver
[visual-studio]: https://www.visualstudio.com/
[xunit]: https://xunit.github.io/
[xunit-158]: https://github.com/xunit/xunit/issues/158

[appveyor-status]: https://ci.appveyor.com/api/projects/status/486qc2gl6m18pbvn/branch/develop?svg=true
[status-umbra]: https://img.shields.io/badge/status-umbra-red.svg
[travis-status]: https://travis-ci.org/ForNeVeR/TankDriver.svg?branch=develop
