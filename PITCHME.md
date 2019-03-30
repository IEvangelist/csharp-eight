@snap[north span-100]
<h2>Exploring C# 8</h2>
<h1>A Deep Dive for 🤓</h1>
@snapend

@snap[south-west]
[@color[#0084b4](@fa[twitter] @davidpine7)](https://twitter.com/davidpine7)
@snapend

@snap[south-east]
[@color[red](davidpine.net @fa[globe])](http://davidpine.net/)
@snapend

+++

# Notes

> A few feature require __.NET Standard 2.1__ or __.NET Core 3.0__

+++

# Async Streams

> Newly added types `netstandard2.1` and `netcoreapp3.0`

 @ul[no-bullets]

 - `IAsyncDisposable`
 - `IAsyncEnumerable<T>`
 - `IAsyncEnumerator<T>`

@ulend

+++

# Ranges

> Newly added types `netstandard2.1` and `netcoreapp3.0`

 @ul[no-bullets]

 - `Range` 
 - `Index`

@ulend

+++

## Target Type New Expressions

@code[csharp code-reveal-fast zoom-12](/IEvangelist.CSharp.Eight/PatternMatching.cs)

@snap[south span-100]
@[173-184](A simple `Point` class.)
@snapend

+++

## Target Type New Expressions

@code[csharp code-reveal-fast zoom-12](/target-type-new-expressions.txt)

@snap[south span-100]
@[7-16](Today, what it looks like...)
@[26-35](Types are declared, so they're known.)
@snapend

+++

# C# 8 Demo ⌨

+++

# Thank you

@snap[south-west]
[@color[#0084b4](@fa[twitter] @davidpine7)](https://twitter.com/davidpine7)
@snapend

@snap[south-east]
[@color[red](davidpine.net @fa[globe])](http://davidpine.net/)
@snapend
