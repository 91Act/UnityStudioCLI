# The GuideLine For Modification From UnityStudio Repo

UnityStudioCLI is a command line tool of [Perfare/UnityStudio](https://github.com/Perfare/UnityStudio). (commit 40153f6f)

This version will **NOT** convert **2dTexture** and **Shader** to original readable type.

---

Unity Studio is a tool for exploring, extracting and exporting assets from Unity games and apps. It has been tested with Unity builds from most platforms, ranging from Web, PC, Linux, MacOS to Xbox360, PS3, Android and iOS, and it is currently maintained to be compatible with Unity builds from 2.5 up to the 2017.2 version.

---

## Requirements 

Currently support macOS only.

[Mono package 5.4.1.6](https://www.mono-project.com/download/)


## Step

（1. Install mono package in http://www.mono-project.com/docs/about-mono/supported-platforms/osx/ .

（2. Download from https://github.com/Perfare/UnityStudio

```
git clone https://github.com/Perfare/UnityStudio.git
```

（3. Flat hierarchy: Move all ***.cs** and ***.dll** under `Unity Studio` into a single seperate folder <YOUR_FOLDER>.

（4. Compile command:

```
mcs -out:YOUR_EXE_NAME.exe -debug -unsafe YOUR_FOLDER/*.cs -r:System.Windows.Forms.dll -r:System.Drawing.dll -r:System.Data.dll -r:System.Web.dll -r:US/OpenTK.dll -r:System.Web.Extensions.dll -r:YOUR_FOLDER/System.Half.dll
```

If `System.Half.dll` still not found, download *.cs from https://sourceforge.net/p/csharp-half/code/HEAD/tree/ into YOUR_FOLDER and delete `-r:US/System.Half.dll` in compile command.

5. Run with mono:

```
mono --debug YOUR_EXE_NAME.exe
```

