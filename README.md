# Geometry
Shape area calculator with some features ('rectangularity' check for triangles, shape validation). 

## Table of contents
* [About](#about)
* [Basic usage](#basic-usage)
* [Add a new shape](#add-a-new-shape)

## About
This project was made as a pet project based on a task which I have seen on the internet and found interesting:
> Write a C# library for external clients which can calculate the area of a circle from the diameter and the area of a triangle from its sides. The following will be evaluated in addition to the efficiency of the code:
> * Unit-tests
> * Ease of adding new shapes
> * Area calculation without knowing exact type of a shape during compile-time
> * Check if triangle is rectangular

## Basic usage
To use this app you need to reference ```Geometry.Domain``` in your project. Then you can create shapes and calculate their areas. There are only two figures (triangle and circle) available by default but you can always add new ones.
### Example
```csharp
var c = new Circle(5);
var t = new Triangle(3, 5, 4);
var circleArea = c.Area; // 78.539816...
var triangleArea = t.Area; // 6
var isRectangular = t.IsRectangular; // true
```

If you recieve your figure from an external source you can use it like that:

```csharp
void MyMethod(Shape s)
{
    var validationResult = ShapeValidator.ValidateShape(s);
    if (validationResult.IsValid)
        // logic if shape is valid
    else
        // logic if shape is invalid
}
```
**Note: it is always a good idea to validate things which you get from an external sources.**
## Add a new shape
To add a new shape you should perform the following steps:
* Create a shape class in the ```Geometry.Domain.Shapes``` and inherit from ```Shape```charp class.
* Implement shape logic: create a constructor, implement getter for ```Area``` property, implement additional properties if needed.
* (Optional) Add validation logic to ```ShapeValidator``` class.
* (Optional) Add unit tests to shape validation logic and shape properties.
