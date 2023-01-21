[![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/hughesjs/OrbitalMechanics/dotnet-ci.yml?label=BUILD%20CI&style=for-the-badge&branch=master)](https://github.com/hughesjs/OrbitalMechanics/actions)
[![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/hughesjs/OrbitalMechanics/dotnet-cd.yml?label=BUILD%20CD&style=for-the-badge&branch=master)](https://github.com/hughesjs/OrbitalMechanics/actions)
![GitHub top language](https://img.shields.io/github/languages/top/hughesjs/OrbitalMechanics?style=for-the-badge)
[![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/Astrodynamics?style=for-the-badge)](https://nuget.org/packages/Astrodynamics)
[![GitHub](https://img.shields.io/github/license/hughesjs/OrbitalMechanics?style=for-the-badge)](LICENSE)
![FTB](https://raw.githubusercontent.com/hughesjs/custom-badges/master/made-in/made-in-scotland.svg)

⚠ Please note, this library is still in very active development, features may be added and removed, although I will try and keep on top of using proper semantic versioning. ⚠

# Astrodynamics

## Introduction

This is C# library to make life just a little bit easier when working with objects in orbit.

The initial release aims to support

- Keplerian orbits
- Modified Keplerian orbits
- Two-line element sets
- Units of measurement
- Multiple reference frames
- Common calculations

This has been created to support an academic paper I'm writing. So initially, only those features that I need will be supported. However, I'm hoping that this will be fleshed out further over time.

## Installation

You can either use your IDE's package manager, or the Nuget CLI.

```bash
dotnet add package Astrodynamics
```