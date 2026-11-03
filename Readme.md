## ProjectRails

ProjectRails is a 3D cab based train simulator. It is a detached fork (not a GitHub fork) of
[OpenBVE](https://openbve-project.net), built on top of the
[adfriz/OpenBVE](https://github.com/adfriz/OpenBVE) fork, which in turn is based on
[leezer3/OpenBVE](https://github.com/leezer3/OpenBVE).

This repository contains the source code for ProjectRails.

Supported route formats:
* Native CSV / RW.
* BVE5 TXT format.
* Mechanik DAT format.

Supported train formats:
* BVE2 / BVE4, with native OpenBVE extensions.
* Microsoft Train Simulator (MSTS) - Partial support, work in progress.

ProjectRails is built in OpenGL, using the OpenTK framework for windowing.

### Fixed Errata

These are described fully [here](https://github.com/leezer3/OpenBVE/wiki/Errata).

### Nightly Builds

Automatically generated daily builds of the upstream project are available [here](http://vps.bvecornwall.co.uk/OpenBVE/Builds/).

### Developer Documentation

Documentation for development of add-ons (update version of docs originally written by _michelle_) can be found [here](https://openbve-project.net/documentation_hugo/en/).

### Packages

ProjectRails supports the installation of 'package files' , which are intended as a replacement for the now defunct managed content. These are described fully [here](http://openbve-project.net/packages/).

### How to build

This build has been tested to compile correctly using Visual Studio 2017 onwards and MonoDevelop. These are described fully [here](Building.md).

### Contributing

Please see the [Contributors File](Contributing.md) for a list of contributors, and basic
guidelines for contributing to the development of ProjectRails.

### Upstream and syncing

Changes and bug fixes from the parent project can be pulled in at any time:

```
git fetch upstream
git merge upstream/master
```

The `upstream` remote points at `adfriz/OpenBVE` (fetch only) and `origin` points at
this repository, so `git push` always goes to ProjectRails and never to the parent project.

### Attribution

ProjectRails is a fork and the overwhelming majority of this codebase is the work of the
OpenBVE project and its contributors.

* **OpenBVE** - originally founded by _Michelle_, maintained over the last 10+ years by
  _leezer3_ and many contributors.
  Project website: https://openbve-project.net
  Source code: https://github.com/leezer3/OpenBVE
* **[adfriz/OpenBVE](https://github.com/adfriz/OpenBVE)** - the fork this project is
  directly based on.

Please keep these credits intact when redistributing ProjectRails or builds of it.

### Links

**Upstream project website**:

https://openbve-project.net

Upstream source code on GitHub: https://github.com/leezer3/OpenBVE

**Discussion Boards**:

- [BVE Worldwide](http://bveworldwide.forumotion.com)

**Official Project Forum:**

http://bveworldwide.forumotion.com/f14-the-sim-in-time-general-discussion

### License

The original founder of this project, Michelle intended for this program to be placed in the public domain. 
In practice over the last 10+ years I've been maintaining this, we've found that whilst public domain was a noble idea, having no recognised licence and attempting to disclaim copyright tends to produce many of it's own challenges.

As a result, all new code is licenced under BSD-2 or a similar permissive licence (as appropriate)- Please see the source headers.

It is our belief that BSD-2 on **new** code keeps most of original philosophical aims intact, whilst at the same time giving the benfits of a recognised licence.
At some point, the project will probably have to re-licence entirely, but that is somewhere in the future.

In practical terms, what this means is that you can make any modifications to the source like and share your modifications with others.
Please also see the following issue for further discussion on the topic: https://github.com/leezer3/OpenBVE/issues/305

**Third-Party Libraries**

- ProjectRails uses [**CoreFX**](https://github.com/dotnet/corefx). This is licensed under the _MIT License_, which may be found in [here](licenses/CoreFX.txt).
- ProjectRails uses [**CS Script**](https://github.com/oleg-shilo/cs-script) for animation scripting. This is licensed under the _MIT License_, which may be found in [here](licenses/CS-Script.txt).
- ProjectRails uses [**DotNetZip**](https://github.com/haf/DotNetZip.Semverd) for loading compressed DirectX file. This is licensed under the *Microsoft Public License*, which may be found in [here](licenses/DotNetZip.txt).
- ProjectRails uses [**NAudio**](https://github.com/naudio/NAudio) for decoding sound file. This is licensed under the *Microsoft Public License*, which may be found in [here](licenses/NAudio.txt).
- ProjectRails uses [**NAudio.Vorbis**](https://github.com/naudio/Vorbis) for decoding Vorbis file. This is licensed under the *Microsoft Public License*, which may be found in [here](licenses/NAudio.Vorbis.txt).
- ProjectRails uses [**NLayer**](https://github.com/naudio/NLayer) for decoding MP3 file. This is licensed under the *MIT License*, which may be found in [here](licenses/NLayer.txt).
- ProjectRails uses [**NVorbis**](https://github.com/NVorbis/NVorbis) for decoding Vorbis file. This is licensed under the *Microsoft Public License*, which may be found in [here](licenses/NVorbis.txt).
- ProjectRails uses [**OpenTK**](https://github.com/opentk/opentk) library for windowing and input handling. This is licensed under the _Open Toolkit Library License_, which may be found in [here](licenses/OpenTK.txt).
- ProjectRails uses [**ReactiveProperty**](https://github.com/runceel/ReactiveProperty) This is licensed under the *MIT License*, which may be found in [here](licenses/ReactiveProperty.txt).
- ProjectRails uses [**SharpCompress**](https://github.com/adamhathcock/sharpcompress) for archive handling. This is licensed under the _MIT License_, which may be found in [here](licenses/SharpCompress.txt).
- ProjectRails uses [**Reactive Extensions**](https://github.com/dotnet/reactive) This is licensed under the *Apache License, Version 2.0*, which may be found in [here](licenses/ReactiveExtensions.txt).
- ProjectRails uses [**Ude**](https://github.com/yinyue200/ude) for character set detection. This is tri-licensed under the _Mozilla Public License v1.1_, _GPL 2.0_ and _LGPL 2.0_, which may be found in [here](licenses/Ude.txt).
- ProjectRails uses [**XamlBehaviors for WPF**](https://github.com/microsoft/XamlBehaviorsWpf) This is licensed under the *MIT License*, which may be found in [here](licenses/XamlBehaviorsForWPF.txt).
- ProjectRails uses [**TOLK**](https://github.com/dkager/tolk) for screen reader API access. This is licenced under the *LGPL V3* which may be found in [here](licences/TOLK.txt)
- ProjectRails uses [**BVE_Parsing**](https://github.com/leezer3/bve5_parsing) for parsing BVE5 map grammar. This is licenced under the *MIT Licence* which may be found in [here](licences/BVE5.txt)
