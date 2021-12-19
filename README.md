# Many.Validators
A set of very-easy-to-read immutable types to add seamless validations in your projects. Of course you can also create your own custom validators.

I focused on:
- Less documentation, better code legibility.
- No extra line of code.
- [Extremely] easy integration.
- Minimum overhead compared to traditional copy-pasted-conditionals way or any other implementation.

<br/>

👉Download releases at https://www.nuget.org/packages/Many.Validators/

<br/>

# Features

### NetStandard 2.1 and NET60 specific implementations
- New Half type support for NET5 and NET6 projects.

<br/>

### Built-int validators and features roadmap 

|Validator                    |Implemented|Benchmarked|Version
|-----------------------------|:---------:|:---------:|:-------:
|NotNull<>                    |✅         |✅        |WIP
|NotNullOrEmpty< string>      |✅         |✅        |WIP
|Positive<>                   |✅         |❌        |WIP
|PositiveOrZero<>             |✅         |❌        |WIP
|Negative<>                   |✅         |❌        |WIP
|NegativeOrZero<>             |✅         |❌        |WIP

<br/>

|Feature                    |Implemented|Version
|---------------------------|:---------:|:-------:
|Validators concatenation   |❌         |?

<br/>

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
<br/>
And call your methods as usual with no additional conversions:

```
string p;

<Code where you can assign a value to p or not...>

var result = WhateverMethod(p);

<Continues if no exception was raised...>

```

<br/>

### How to create your own validators
