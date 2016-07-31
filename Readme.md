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

#### NixOs

There's a ready nix-shell environment in `default.nix`. Just invoke the
following:

```console
$ nix-shell
$ nuget restore
$ xbuild
```

[andivionian-status-classifier]: https://github.com/ForNeVeR/andivionian-status-classifier#status-umbra-
[appveyor]: https://ci.appveyor.com/project/ForNeVeR/tankdriver/branch/develop
[mono]: http://www.mono-project.com/
[monogame]: http://www.monogame.net/
[nuget]: https://www.nuget.org/
[travis]: https://travis-ci.org/ForNeVeR/TankDriver
[visual-studio]: https://www.visualstudio.com/

[appveyor-status]: https://ci.appveyor.com/api/projects/status/486qc2gl6m18pbvn/branch/develop?svg=true
[status-umbra]: https://img.shields.io/badge/status-umbra-red.svg
[travis-status]: https://travis-ci.org/ForNeVeR/TankDriver.svg?branch=master
