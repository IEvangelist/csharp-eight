@snap[north span-100]
<h2>Exploring @color[magenta](C# 8)</h2>
<h1>The Deep Dive</h1>
@size[5em](🤓)
@snapend

@snap[south-west]
[@color[#0084b4](@fa[twitter] @davidpine7)](https://twitter.com/davidpine7)
@snapend

@snap[south-east]
[@color[red](davidpine.net @fa[globe])](http://davidpine.net/)
@snapend

+++

# Notes from @color[#008AD7](Microsoft)

> Most features are implemented entirely in the @color[white](C# Compiler).

+++

# Notes from @color[#008AD7](Microsoft)

> A few features require @color[white](__.NET Standard 2.1__) or @color[white](__.NET Core 3.0__)

+++

# Sorry... 😢

> The "Default Interface Implementations" feature relies on a new runtime. The new CLR will be part of @color[white](__.NET Core 3.0__).
>
> It will __not__ be delivered with @color[white](__.NET Framework 4.8__).

+++


# Async Streams

> Types added to @color[white](__netstandard2.1__) and @color[white](__netcoreapp3.0__)

@ul[no-bullets span-70]

 - @color[white](System.)@color[cyan](`IAsyncDisposable`)
 - @color[white](System.)@color[cyan](`IAsyncEnumerable<T>`)
 - @color[white](System.)@color[cyan](`IAsyncEnumerator<T>`)

@ulend

+++

# Ranges

> Types added to @color[white](__netstandard2.1__) and @color[white](__netcoreapp3.0__)

@ul[no-bullets span-70]

 - @color[white](System.)@color[#e7ce59](`Range`) 
 - @color[white](System.)@color[#e7ce59](`Index`)

@ulend

+++

## Default Interface Methods

@code[csharp code-reveal-fast zoom-14](/default-interface-methods.txt)

@snap[south span-100]
@[10-12](We start with an @color[cyan](`IRepository`) interface.)
@[20-27](We need to add to the API.)
@[40-50](We can then provide a @color[grey](default) impl.)
@snapend

+++

## Target Type New Expressions

@code[csharp code-reveal-fast zoom-12](/IEvangelist.CSharp.Eight/PatternMatching.cs)

@snap[south span-100]
@[173-184](A simple @color[cyan](`Point`) class.)
@snapend

+++

## Target Type New Expressions

@code[csharp code-reveal-fast zoom-12](/target-type-new-expressions.txt)

@snap[south span-100]
@[7-16](Today, what it looks like...)
@[26-35](Types are declared, so they're known.)
@snapend

+++

# @color[magenta](C# 8)
# Live @color[red](@fa[code]) Demo

[Code : http://bit.ly/2V3fdla @color[grey](@fa[link])](http://bit.ly/2V3fdla)

+++

# Resources

 - [What's new in @color[magenta](C# 8) : http://bit.ly/2CVVPjh @color[grey](@fa[link])](http://bit.ly/2CVVPjh)
 - [Building @color[magenta](C# 8) : http://bit.ly/2CKn1kB @color[grey](@fa[link])](http://bit.ly/2CKn1kB)

+++

# Thank you

@snap[south-west]
[@color[#0084b4](@fa[twitter] @davidpine7)](https://twitter.com/davidpine7)
@snapend

@snap[south-east]
[@color[red](davidpine.net @fa[globe])](http://davidpine.net/)
@snapend
