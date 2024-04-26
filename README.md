# T4 Solution Exemple

This solution contains exemples of usage of T4 (Text Template Transformation Toolkit)

## Known limitation of this setup
Visual Studio doesn't regenerate the output of the files when you build them by default. In order to force visual studio to generate this at build time, you will need to slightly tweak your build system. It exist 2 extension with this purpose [T4Executor](https://marketplace.visualstudio.com/items?itemName=TimMaes.t4executer2022) and [TransformOnbuild](https://www.nuget.org/packages/JohnVerbiest.TransformOnBuild). In addition to this extension it's possible to edit the project file for executing the template. More info on this subject can be found on [StackOverflow](https://stackoverflow.com/questions/1646580/get-visual-studio-to-run-a-t4-template-on-every-build)

## Common logic to OnetoOne and OnetoN projects

Both projects extract the data they use from an assembly named *TemplateData*. This assembly must be compiled first as the data is directly extracted from the .dll file.

## Project OnetoOne

This project illustrate the standard behavior of T4 integration in visual as defined by Microsoft.
You have one template (.tt file) that output one file (.cs).

## Project OnetoN

This project illustrate a more advanced use case where one template output multiple files.
This is not the standard Visual Studio setup and involve the use of a third party T4.FileManager (https://www.nuget.org/packages/T4.FileManager.VisualStudio).

The Template generate a few files of different types (.h, .cpp). This is not necesarilly a good practice and it would be wise to divide the logic into multiple more focused templates. The reason we decided to put everything into one template was to present how it was possible to do all those different generation with only one definition.

This project is generating files that are outputed into the folders of the C++ project *GeneratedProject.vcxproj*

## Tested Environment
This Solution was tested on Visual Studio 2022 17.9.5 with a C# and C++ environment installed. If you can't load a csproj or a vcxproj it's likely because you lack some components of visual studio which can be installed using the "Get Tools and Features" item in the Tools menu.