# Heron's Formula

This program will take two triangles and calculate the largest area between them, however, without using classes.

Heron of Alexandria was a great mathematician who derived the formula for the calculation of the area of a triangle using the length of all three sides. He also extended this idea to find the area of quadrilateral and also higher-order polygons. This formula has its huge applications in trigonometry such as proving the law of cosines or the law of cotangents, etc.

![image](https://github.com/Ice-CreamAT/Heron-s-Formula/assets/73790661/6511f17e-79e9-4446-adec-6bbf1491650c)

According to Heron, we can find the area of any given triangle, whether it is a scalene, isosceles or equilateral, by using the formula, provided the sides of the triangle.

# Proof of Heron’s Formula

There are two methods by which we can derive Heron’s formula:

First, by using trigonometric identities and cosine rule.

Secondly, solving algebraic expressions using the Pythagoras theorem.
Let us see one by one both the proofs or derivation.

## Building

```PS
git clone --recursive https://github.com/dnSpyEx/dnSpy.git
cd dnSpy
# or dotnet build
./build.ps1 -NoMsbuild
```

To debug Unity games, you need this repo too: https://github.com/dnSpyEx/dnSpy-Unity-mono (or get the binaries from https://github.com/dnSpyEx/dnSpy/releases/unity)

# Debugger

- Debug .NET Framework, .NET and Unity game assemblies, no source code required
- Set breakpoints and step into any assembly
- Locals, watch, autos windows
- Variables windows support saving variables (eg. decrypted byte arrays) to disk or view them in the hex editor (memory window)
- Object IDs
- Multiple processes can be debugged at the same time
- Break on module load
- Tracepoints and conditional breakpoints
- Export/import breakpoints and tracepoints
- Call stack, threads, modules, processes windows
- Break on thrown exceptions (1st chance)
- Variables windows support evaluating C# / Visual Basic expressions
- Dynamic modules can be debugged (but not dynamic methods due to CLR limitations)
- Output window logs various debugging events, and it shows timestamps by default :)
- Assemblies that decrypt themselves at runtime can be debugged, dnSpy will use the in-memory image. You can also force dnSpy to always use in-memory images instead of disk files.
- Public API, you can write an extension or use the C# Interactive window to control the debugger

# Assembly Editor

- All metadata can be edited
- Edit methods and classes in C# or Visual Basic with IntelliSense, no source code required
- Add new methods, classes or members in C# or Visual Basic
- IL editor for low-level IL method body editing
- Low-level metadata tables can be edited. This uses the hex editor internally.
