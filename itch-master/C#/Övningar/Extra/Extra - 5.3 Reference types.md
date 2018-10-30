# 5.3 Reference types


Create a class **Point** with the properties X and Y.

Create a method that changes the value X and Y values of a Point:

	void ChangePoint(Point point)

Create a method that adds a message to a StringBuilder:

 	void ChangeStringBuilder(StringBuilder sb)

Create a point with X=3 and Y=4. Call ChangePoint.
Create a stringbuilder with a text. Call ChangeStringBuilder.

Display the result. It should look like this:

![15](Images/15.png)


## Extra

1. Create one more class (e.g Animal). Create one method that changes an instance of your class (similair as above)

2. Create a method like this 

        private static void ChangeStringBuilderReplace(StringBuilder sb)
        {
            sb = new StringBuilder("Hoooooooo!");
        }

    Use the method. What happens?

## Hint 1

Create the Point class like this:

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

Use the class like this:

    Point point = new Point();
    point.X = 3;
    point.Y = 4;

## Hint 2

Add a constructor:

    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }

Use the class like this:

    Point point = new Point(3, 4);
