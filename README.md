# Many.Validators
A set of very-easy-to-read immutable types to add seamless validations in your projects.

Focused on:
- Less documentation, better code legibility.
- No extra line of code, just change type by validators and that's all.
- Minimum overhead compared to traditional copy-pasted-conditionals way or any other implementation.



👉Download releases at https://www.nuget.org/packages/Many.Validators/



# Features


### Built-int validators and features 

|Validator                      |Implemented|Version
|-------------------------------|:---------:|:--------------:
|NotNull<>                      |✅         |1.0.0
|NotNullOrEmpty< string>        |✅         |1.0.0
|NotNullOrEmptyArray<>          |✅         |1.1.0
|Positive<>                     |✅         |1.0.0
|PositiveOrZero<>               |✅         |1.0.0
|Negative<>                     |✅         |1.0.0
|NegativeOrZero<>               |✅         |1.0.0
|InRange                        |✅         |2.0.0




|Feature                         |Implemented|Version
|--------------------------------|:---------:|:-------:
|Multiple explicit validation    |✅         |3.0.0
|Validators concatenation        |❌         |?




### ✅Two-way conversion between validator and underlying types
```
NotNull<string> notMullStringValidator = "whatever"; //Ok
string x = notMullStringValidator; //Ok

notMullStringValidator.Equals(x); //true!
```

### ✅ Seamless integration
Use validators in your methods referring your underlying type:
```
bool WhateverMethod(NotNull<string> @param)
{
    //@param is observed and validated when is instantiated. 
    //If validation fails no line of code will be run in this method

    Console.WriteLine("Whatever");
    
    //Gets @param value with no conversion
    return !string.IsNullOrWhiteSpace(@param); 
}
```

And call your methods as usual with no additional conversions:

```
string p;

<Code where you can assign a value to p or not...>

var result = WhateverMethod(p);

<Continues if no exception was raised...>
```

### ✅ InRange validators
InRange validators need a range 😅. To get that you only need to create your custom range class (inherit from abstract RangeBase class) and implement the abstract properties. Finally be sure to name your class with a self-descritive name. 

Example:
```
namespace YourProject.Validators.Ranges.Int64
{
    internal class Neg100_1 : Range<Int64>
    {
        public override long Max => 1;

        public override long Min => -100;
    }
}
```

Then only use it:
```
public void DoSometing(InRange<Neg100_1, Int64> param1) 
{
    ...
}
```

Tip: Also you can follow a self-descriptive namespace naming strategy in order to get clearer shorter range names.


### ✅ Multiple explicit validations
Also you can validate in a explicit way. If you have a class like this:
```
class YourObject
{
    public string Id {get;set;}
    public string Data {get;set;}
}
```

You can use it in your code to validate it content in serveral ways:
```
public void DoSomething(NotNull<YourObject> param) //This line checks if param itself is not null
{
    var otherParamsToCheck = new string[]{param.Id, param.Data};

    //You can validate params and get an exception if any fails validation or...
    NotNull<string>.Validate(otherParamsToCheck);

    //...you can validate params and get the result with no exceptions

    //Get all errors
    var result = NotNull<string>.IsValid(otherParamsToCheck, out string[] errors);

    //Get and stop after first error
    result = NotNull<string>.IsValid(otherParamsToCheck, out string error);    
}
```

### ✅ NetStandard 2.1 and NET60 specific implementations
- New Half type support for NET5 and NET6 projects.

