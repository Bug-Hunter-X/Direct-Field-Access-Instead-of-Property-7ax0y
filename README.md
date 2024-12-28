# Direct Field Access Instead of Property in C#

This repository demonstrates a common coding error in C# where a class field is accessed directly instead of using its associated property.  Direct field access can bypass any validation or logic contained within the property's setter, leading to unexpected behavior or bugs.

The `bug.cs` file showcases the incorrect approach, while `bugSolution.cs` provides the corrected implementation.

## Problem
Directly modifying class fields circumvents any potential validation, data transformation, or other actions defined in the property's setter.