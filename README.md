# Many.Validators
A set of very-easy-to-read immutable types to add seamless validations in your projects.

I focused on:
- Less documentation, better code legibility.
- No extra line of code.
- [Extremely] easy integration.
- Minimum overhead compared to traditional copy-pasted-conditionals way or any other implementation.



👉Download releases at https://www.nuget.org/packages/Many.Validators/



# Features

### NetStandard 2.1 and NET60 specific implementations
- New Half type support for NET5 and NET6 projects.




### Built-int validators and features 

|Validator                      |Implemented|Overhead* (baseline=1)|Version
|-------------------------------|:---------:|:------------:|:--------------:
|NotNull<>                      |✅         |4.3          |1.0.0
|NotNullOrEmpty< string>        |✅         |1.4          |1.0.0
|NotNullOrEmptyArray<>           |✅         |2.0 - 2.3**         |1.1.0
|Positive<>                     |✅         |1.3 - 2.1    |1.0.0
|PositiveOrZero<>               |✅         |1.3 - 2.1    |1.0.0
|Negative<>                     |✅         |1.3 - 2.1    |1.0.0
|NegativeOrZero<>               |✅         |1.3 - 2.1    |1.0.0
|InRange                        |✅          | ❌         |2.0.0-beta1

 <sub>(*) This column shows the average overhead calculation in the validation-passes scenario that is the most expensive: we need to perform a validation and it passes. **This is a measure of the overhead cost, not the cost itself.**
<br/>The baseline corresponds to the simplest way to validate each case (copy-pasted IF conditional(s) and manual exception throwing). Data is provided from supported frameworks but in this table the value is from NET60 benchmarks.
<br/>Results for older frameworks can vary depending the framework (generally older the framework a bit worse the result) and if you force conversions or not (you can check the complete results at Many.Validators.Benchmark/Data).</sub>
 




|Feature                    |Implemented|Version
|---------------------------|:---------:|:-------:
|Validators concatenation   |❌         |?




### Two-way conversion between validator and underlying types
```
NotNull<string> notMullStringValidator = "whatever"; //Ok
string x = notMullStringValidator; //Ok

notMullStringValidator.Equals(x); //true!
```

### Seamless integration
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


### InRange validators
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
