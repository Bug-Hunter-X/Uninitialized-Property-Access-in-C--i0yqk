# Uninitialized Property Access in C#

This repository demonstrates a potential bug in C# related to accessing properties that haven't been explicitly initialized.  Uninitialized properties in C# will have their default value (0 for integers, null for reference types, etc.). Accessing them directly may lead to unexpected behavior, especially in complex scenarios. The example shows a simple class with a property and a method that attempts to use the property before assigning a value.

## How to Reproduce

1. Clone this repository.
2. Open the `bug.cs` file.
3. Run the `MyMethod()` function.

Observe the unexpected behavior.  The code doesn't throw an exception but calculates based on the default value of the uninitialized property.

## Solution

The `bugSolution.cs` file presents a corrected version, demonstrating several methods to address this issue.

## Lessons Learned

- Always initialize properties, particularly those used in calculations, before accessing them.
- Consider adding validation to ensure that properties have appropriate values before use.
- Using constructors is a great way to initialize object properties upon object creation.