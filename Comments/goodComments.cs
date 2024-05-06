//Copyright (C) 2024. NameSomeCompany
//All rights reserved


double getAreaOfTriangleWithSides(double a, double b, double c)
{
    double s = getPerimeter(a, b, c) / 2;
    return sqrt(s * (s - a) * (s - b) * (s - c));
}
double getPerimeter(double a, double b, double c)
{
    return (a + b + c);
}


//TODO: We need to develop a function that casts the type to double and uses a dot for that

