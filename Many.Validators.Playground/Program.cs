using Many.Validators;
using System.Diagnostics;


//2-way conversions between validator and their underlying types
NotNull<string> notMullStringValidator = "whatever";
string x = notMullStringValidator;

//Built-int validators 
bool NotNullParamFunction(NotNull<string> @param)
{
    Console.WriteLine("Whatever");
    return !string.IsNullOrWhiteSpace(@param);
}

try
{
    string p = null;
    var f = NotNullParamFunction(p);
    Debug.Fail("NotNullParamFunction should have thrown ArgumentNullException");
}
catch (Exception ex)
{
    Debug.Assert(ex is ArgumentNullException, "Wrong exception");
}
