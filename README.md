# Many.Validators
A set of performance-focused extensible immutable types to add seamless validations in your projects. Also you can create your own custom validators.

👉Lastest release at https://www.nuget.org/packages/Many.Validators/

# **Key features**

## NetStandard 2.1 and NET60 specific implementations
- New Half type support


## 2-way conversion between validator and underlying types
```
NotNull<string> notMullStringValidator = "whatever"; //Ok
string x = notMullStringValidator; //Ok

notMullStringValidator.Equals(x); //true!
```

## Seamless integration. Not a single line of code needed
Use validators in your methods like any other type:
```
bool NotNullParamFunction(NotNull<string> @param)
{
    //@param is observed and validated when is instantiated. 
    //No line of code will be run in this method if validation does not pass

    Console.WriteLine("Whatever");
    return !string.IsNullOrWhiteSpace(@param); 
}
```
<br/>
And call your methods as usual with no additional conversions:

```
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
```



## A complete set of Built-int validators 
xxxx

## How to create your own validators