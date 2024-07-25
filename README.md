# WEBPtoJPG

Simple window utility to convert WEBP files to JPEG, uses google's dwebp.exe console app from libwebp package.

## Build

Use Visual Studio 2022 to build project

## Run

Download libwebp (https://developers.google.com/speed/webp/docs/precompiled) and extract dwebp.exe (webp decoder) to same folder with the utility before start WEBPtoJPG.exe.

## Use

![01](https://github.com/user-attachments/assets/cb408908-d621-491a-92d4-0755986e7f4e)

Add files manually to convert or press "Add WCM" button to add windows context menu options for files with .webp extension.
Add WCM writes to registry, so may be need to run utility with admin privileges.

![02](https://github.com/user-attachments/assets/28ea3d9d-5ddd-4f8d-ba95-f73d02c05496)

Convert auto - converts selected file with last used options<br>
Convert auto all in folder - converts selected file and all other webp files in folder with last used options<br>
Convert... - opens utility windows and adds file to list
