[![Build Status TravisCI](https://travis-ci.org/DerAtrox/Arma3LauncherLib.svg?branch=master)](https://travis-ci.org/DerAtrox/Arma3LauncherLib)
[![Build status AppVeyor](https://ci.appveyor.com/api/projects/status/qaayarfd7urse6ds?svg=true)](https://ci.appveyor.com/project/DerAtrox/arma3launcherlib)
[![NuGet](https://img.shields.io/nuget/v/Arma3LauncherLib.svg)](https://www.nuget.org/packages/Beer.NET)

Arma 3 Launcher Library
=======================

Simple .NET library which makes creating your custom Arma 3 launcher easier.

This project is currently work in progress. Feel free to watch, star or contribute this project!

## Prerequisites ##
- .NET Framework 4.5 or higher

## Installation ##
The simplest way to install Arma3LauncherLib is to use our [NuGet package](https://www.nuget.org/packages/Arma3LauncherLib). Just open the context menu for your project with Visual Studio and click the option "*Manage NuGet Packages...*".

```
PM> Install-Package Arma3LauncherLib -Pre
```

You can also build Arma3LauncherLib yourself and add it as an reference to your project.

## Features ##
- [x] Server status (+ player list) using [SSQLib](https://github.com/leewalkergm/ssqlib/)
- [x] Start game and connect to server
- [x] Missionfile management
- [ ] Mod management (coming soon)


## Basic usage ##
Some simple examples in C#. A full documention of this library is work in progress.
```
using DerAtrox.Arma3LauncherLib.Model;
using DerAtrox.Arma3LauncherLib.Utilities;

// Start game with default start parameters.
public void RunArma() {
	string armaPath = Path.Combine(ArmaUtils.GetArma3Path(), "arma3battleeye.exe");

    new ArmaLauncher().Connect(armaPath);
}

// Start game using profile "Günther".
public void RunArmaProfile() {
	string armaPath = Path.Combine(ArmaUtils.GetArma3Path(), "arma3battleeye.exe");

    var armaSettings = new ArmaStartSettings() { Profile = "Günther" };

    new ArmaLauncher().Connect(armaPath, armaSettings);
}

// Want to connect to a server?
public void JoinServer() {
    string armaPath = Path.Combine(ArmaUtils.GetArma3Path(), "arma3battleeye.exe");

    var armaServer = new ArmaServer("some-hostname.tld", 2302, 2303);

    new ArmaLauncher().Connect(armaPath, armaServer);
}
```
