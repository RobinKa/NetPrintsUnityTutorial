# Description
This is an example of how to use [NetPrints](https://github.com/RobinKa/NetPrints) inside Unity3D for visual programming. It replicates part of the [roll-a-ball tutorial](https://unity3d.com/learn/tutorials/projects/roll-ball-tutorial/moving-player) where we make a ball roll with user input. For further information on how the example works please visit the link. The completed project is contained in this repository.

## Note
Requires version [0.0.6](https://github.com/RobinKa/netprints/releases/tag/0.0.6) of NetPrints.

# Steps
1. Create a new NetPrints project within your unity project by clicking Project and Create New Project in the NetPrints editor. The exact path does not matter. Unity will automatically find the generated scripts. Create a plane for the floor and a sphere in Unity. Add a `Rigidbody` component to the sphere. 

![](https://raw.githubusercontent.com/RobinKa/NetPrintsUnityTutorial/master/Screenshots/NewProject.png)

2. Click assemblies in the main menu. Remove all existing items and add new Assembly references for Unity's .NET libraries (`mscorlib.dll`, `System.dll`, `System.Core.dll`) which can be found in `<UnityDirectory>/Editor/Data/Mono/lib/mono/unity/` as well as `UnityEngine.dll` in `F:/Unity/Editor/Data/Managed`. You can also add a source code reference to your C# scripts and exclude them in the NetPrints compilation process (which is the default) to refer to them in NetPrints. We have not done that here as we don't have any existing C# scripts.

![](https://raw.githubusercontent.com/RobinKa/NetPrintsUnityTutorial/master/Screenshots/Assemblies.png)

3. Unity can use either our generated .NET binary or C# source code. The source code has the advantage that we can debug our generated code. Furthermore there are some bugs in Unity with generated .NET binaries and `MonoBehaviour` inheritance. Open the settings and set the output mode to `SourceCode` which will output only the source code. Then press `New Class` which will add a new empty class to our project. You can open it by clicking on it. In the class settings it is possible to change the class name, its namespace and some other interesting properties. Set the base class to `UnityEngine.MonoBehaviour`.

![](https://raw.githubusercontent.com/RobinKa/NetPrintsUnityTutorial/master/Screenshots/MainMenu.png)

4. Add the `FixedUpdate()` and `Start()` methods. Also create the `rb` (type `UnityEngine.Rigidbody`) and `speed` (type `System.Single`, which is the same as `float`) attributes. Mark the `speed` attribute as public by clicking on the method and selecting `Public` for visibility on the right side of the editor.

![](https://raw.githubusercontent.com/RobinKa/NetPrintsUnityTutorial/master/Screenshots/MethodsAttributes.png)

5. Implement the `Start()` method. We can use any of Unity's methods as one would expect. Here we just set the `rb` attribute to the `Rigidbody` component.

![](https://raw.githubusercontent.com/RobinKa/NetPrintsUnityTutorial/master/Screenshots/MethodStart.png)

6. Implement the `FixedUpdate()` method which adds a force in the input direction to `rb`.

![](https://raw.githubusercontent.com/RobinKa/NetPrintsUnityTutorial/master/Screenshots/MethodFixedUpdate.png)

7. Press compile. This will generate the source code in the `Compiled_<ProjectName>` directory within the NetPrints project's directory. The script can now be dragged onto our sphere like any other C# script. The sphere should now move when we press WASD in play mode.

![](https://raw.githubusercontent.com/RobinKa/NetPrintsUnityTutorial/master/Screenshots/Unity.png)
