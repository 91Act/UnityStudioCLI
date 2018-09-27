# UnityStudio CLI

UnityStudioCLI is a command line tool of [Perfare/UnityStudio](https://github.com/Perfare/UnityStudio). (commit 40153f6f)

This version will **NOT** convert **2dTexture** and **Shader** to original readable type.

---

Unity Studio is a tool for exploring, extracting and exporting assets from Unity games and apps. It has been tested with Unity builds from most platforms, ranging from Web, PC, Linux, MacOS to Xbox360, PS3, Android and iOS, and it is currently maintained to be compatible with Unity builds from 2.5 up to the 2017.2 version.

---

## Requirements 

Currently tested in macOS only (10.12.6, 10.13.6) .

Install [Mono package 5.4.1.6](https://www.mono-project.com/download/) first.


## Usage

If there is not an `abexport`, run `./build.sh` to build a new one with current code. And you can use `debug.sh` to generate a debug version for `test.py`.

Basic usage: `./run.sh <--dump|--list> <ab_file_path>` to extract or list an assetbundle file.

### Dump

Extract files from explicit ab file.

Use command `./run.sh --dump <ab_file_path> [output_path]` to extract `<ab_file>` to `[output_path]`.(optional: The extract files will be in `ab_file_path` by default).

NOTICE that  `ab_file_path` and `output_path` should be **abstract complete path**.

### List

Use `./run.sh --list <ab_file_path>` to list the explicit assetbundle included files.

## Debug

Use `./debug.sh` to build and start a debug program, which contains function symbols, exception lines, etc.


