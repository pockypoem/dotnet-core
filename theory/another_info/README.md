# Is Blazor better than React?

> 🥫 sauce: [Gavin Lon](https://youtu.be/FbBdJc5cFP4?si=b9YvbCp-UaLHEg6D)

Blazor State Management:
* [Fluxor](https://github.com/mrpmorris/Fluxor)
* [Blazor State](https://timewarpengineering.github.io/blazor-state/)


## The differences between Blazor and React
* React is javascript based, Blazor is C# and .NET based
* React uses JSX, Blazor uses Razor Components
* React leverages Virtual DOM
* React Apps download smaller bundle sizes so faster load times than Blazor WebAssembly Apps
    * Blazor Server has much faster load times than Blazor WebAssembly but higher latency with Signal-R connection
* React has broader browser compatibility than Blazor WebAssembly
* Blazor WebAssembly -> fast processing of computationally intensive tasks
* React has vast community support but Blazor community is steadily growing
* Blazor has support and heavy investments from Microsoft

## When to use Blazor?
* Already have C# and .NET skills
* Your app involves executing computationally intensive tasks
* Your app requires a lot of real-time updates
* Your app requires a full-stack solution

## When to use React?
* Large scale front-end applications
* For faster initial load times
* Already have Javascript and React skills
* For broader browser support


------
# Should I Focus on Blazor or ASP.NET Core?

Quick Answer: learn ASP.NET Core first, because it's the foundation on which all these others web frameworks.

> 🥫 sauce: [Tim Corey](https://youtu.be/YbH2n4FZAP4?si=ZpPr9K5RdcgBdqXO)

Which one's the right one to go deeper in first when i'm learning these web technologies?

it's kinda like this: should i learn to drive a car first or learn to drive a toyota corolla first?
If you learn to drive a toyota corolla, you're learning to drive a car and if you learn to drive a car then you pretty much know how to drive a toyota corolla.

ASP.NET Core is the underlying power for all web frameworks in .NET. So, when we're looking at Blazor, it runs off ASP.NET Core. If we're looking at MVC, it runs off ASP.NET Core. If we're looking at Razor pages or API, they run off of ASP.NET Core. That's kind of the underlying framework for all web frameworks

It make sense to learn ASP.NET Core first because that's the underlying power for all the different web project types.

**How to learn ASP.NET Core:**
1. Understand how dependency injection works
2. Knowing how logging works in all web frameworks 
3. Knowing how to use `Appsettings.json` (there are 5 different places we can put our project settings)
and when you deploy it, you have even more locations
4. Understand how routing works
5. Authorization and Authentication
    * authentication just knowing who you say you are (like username and password)
    * authorization to make sure what access do you have?
6. Deployment
    * how you take an ASP.NET Core application and deploy it 

After learning ASP.NET Core, which one should i learn depth first? well, it depends on your circumstances.
* If you're in environemnt where you have to build MVC apps, then MVC is the right next choice

But, in general:
1. Learn API 
2. Blazor Server
    * because it's a pretty powerful tool that sits both in the server side and client side
    * this is a easiest way to build powerful applications on the web that are both secure and protected on the server side while still giving that single page application that nice interaction on the client side that people come to expect from web applications
3. Blazor WebAssembly
4. Razor Pages
5. MVC 
    * because it was the only real efficient one
    * that was actually web standard and followed best practices