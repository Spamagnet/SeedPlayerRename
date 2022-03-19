# SeedPlayerRename

Utility to rename audio files for use in the SeedPlayer. 

Notes

 - It will only do a single language set at a time.
 - It will not overwrite files in the target directory.

## How to use

Download the currenr `SPRenamer.exe` utility.

1. `SPRenamer.exe`
	- With no parameters - it will prompt for source and target directories
1. `SPRenamer.exe help`
	- Will display some usage info
1. `SPRenamer.exe version`
	- Will display the version of the utility
1. `SPRenamer.exe SOURCEDIR TARGETDIR`
	- Will copy/transform the contents of the `SOURCEDIR` into the `TARGETDIR`

## Overview

Given source and target folders. If not present, create individual book folders with strict `001` to `999` book prefixes in the target folder. Copy all the source files into their respective book folders, renaming with strict `001` to `999` chapter prefixes.

So, in Somali, the mapping would be:

```
Matthew 1: Source/B01___01_Matthew_____SOMTVIN2DA.mp3 >> Target/001_Matthew/001_Matthew_____SOMTVIN2DA.mp3
Luke 18:   Source/B03___18_Luke________SOMTVIN2DA.mp3 >> Target/003_Luke/018_Luke________SOMTVIN2DA.mp3
```

or, in Oromo:

```
2 Cor 13: Source/B08___13_2CorinthiansGAZBSEN2DA.mp3 >> Target/008_2Corinthians/013_2CorinthiansGAZBSEN2DA.mp3
Rev 18:   Source/B27___18_Revelation__GAZBSEN2DA.mp3 >> Target/027_Revelation/018_Revelation__GAZBSEN2DA.mp3
```

