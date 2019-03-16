# Description
This is an example of how to use [NetPrints](https://github.com/RobinKa/NetPrints) inside Unity3D for visual programming. It replicates part of the [roll-a-ball tutorial](https://unity3d.com/learn/tutorials/projects/roll-ball-tutorial/moving-player) where we make a ball roll with user input. For further information on how the example works please visit the link. The completed project is contained in this repository.

# Steps
1. Create a new project within your unity project. Create a plane for the floor and a sphere. Add a `Rigidbody` to the sphere. The exact path does not matter. Unity will automatically find the generated scripts.
![](https://raw.githubusercontent.com/RobinKa/NetPrintsUnityTutorial/master/Screenshots/NewProject.png)

2. Click assemblies in the main menu. Remove all existing items and add Unity's .NET libraries (`mscorlib.dll`, `System.dll`, `System.Core.dll`) which can be found in `<UnityDirectory>/Editor/Data/Mono/lib/mono/unity/` as well as `UnityEngine.dll` in `F:/Unity/Editor/Data/Managed`.
![](https://raw.githubusercontent.com/RobinKa/NetPrintsUnityTutorial/master/Screenshots/Assemblies.png)

3. Unity can use either our generated .NET binary or C# source code. The source code has the advantage that we can debug our generated code. Furthermore there are some bugs in Unity with generated .NET binaries and MonoBehaviour inheritance. Set the output mode to `SourceCode` which will output only the source code. Then press `New Class` which will add a new empty class to our project. You can open it by clicking on it. In the class settings it is possible to change the class name, its namespace and some other interesting properties. Set the base class to `UnityEngine.MonoBehaviour`.
![](https://raw.githubusercontent.com/RobinKa/NetPrintsUnityTutorial/master/Screenshots/MainMenu.png)

4. Add the `Update()` and `Start()` methods. Also create the `rb` (type `UnityEngine.Rigidbody`) and `speed` (type `System.Single`, which is the same as `float`). Mark the `speed` attribute as public by clicking on it and checking the `Public` checkbox on the right side of the editor.
![](https://raw.githubusercontent.com/RobinKa/NetPrintsUnityTutorial/master/Screenshots/MethodsAttributes.png)

5. Implement the `Start()` method.
![](https://raw.githubusercontent.com/RobinKa/NetPrintsUnityTutorial/master/Screenshots/MethodStart.png)

6. Implement the `FixedUpdate()` method.
![](https://raw.githubusercontent.com/RobinKa/NetPrintsUnityTutorial/master/Screenshots/MethodUpdate.png)

7. Press compile. This will generate a source code file with the name  `<Namespace.Class>.cs`. Since Unity only recognizes classes with the same name as its filename, the generated file will need to have the namespace part removed. The script can now be dragged onto our sphere like any other C# script. The sphere should now move when we press WASD.
![](https://raw.githubusercontent.com/RobinKa/NetPrintsUnityTutorial/master/Screenshots/Unity.png)