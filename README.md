# Dotnet 7 Template with CI/CD

[![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/hughesjs/OrbitalMechanics/dotnet-ci.yml?label=BUILD%20CI&style=for-the-badge&branch=master)](https://github.com/hughesjs/OrbitalMechanics/actions)
[![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/hughesjs/OrbitalMechanics/dotnet-cd.yml?label=BUILD%20CD&style=for-the-badge&branch=master)](https://github.com/hughesjs/OrbitalMechanics/actions)
![GitHub top language](https://img.shields.io/github/languages/top/hughesjs/OrbitalMechanics?style=for-the-badge)
[![GitHub](https://img.shields.io/github/license/hughesjs/OrbitalMechanics?style=for-the-badge)](LICENSE)
![FTB](https://raw.githubusercontent.com/hughesjs/custom-badges/master/made-in/made-in-scotland.svg)

This template repository contains:

- A .NET 7 Solution
  - OrbitalMechanics Class Library
  - OrbitalMechanics Unit Test Project (XUnit)
  
- Various Workflows
  - CodeQL
  - Dependabot
  - CI Pipeline
  - CD Pipeline (to Nuget and Github Package Repo)
    - Uses Conventional Commits to Semver Package
    
- Standard Documents
  - Readme
  - Code of Conduct (Lunduke)
  - Issue Templates
  - Contributing

Run `./runme.sh` after cloning to rename directories, project files and root namespace to your desired project name.
