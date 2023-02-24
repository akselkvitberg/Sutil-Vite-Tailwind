# Simple SAFE stack web app using Sutil, Vite and Tailwind

A Safe-style template using
- Fable
- Sutil
- Fable.Remoting
- Saturn
- Fake
- Vite
- Tailwind
- PostCSS

This is a small Fable app project so you can easily get started and add your own code progressively. For more comprehensive templates [check this page](https://fable.io/docs/2-steps/your-first-fable-project.html).

## Requirements

* [dotnet SDK](https://www.microsoft.com/net/download/core) 5.0 or higher
* [node.js](https://nodejs.org)
* An F# editor like Visual Studio, Visual Studio Code with [Ionide](http://ionide.io/) or [JetBrains Rider](https://www.jetbrains.com/rider/)

## Building and running the app

* Run `dotnet tool restore`
* Run `dotnet run`

* After the first compilation is finished, in your browser open: http://localhost:8080/

Any modification you do to the F# code will be reflected in the web page after saving.

## Bundling for release

Run `dotnet run Pack`

## Project structure

### Client


### Server


### Shared


[//]: # (### npm)

[//]: # ()
[//]: # (JS dependencies are declared in `package.json`, while `package-lock.json` is a lock file automatically generated.)

[//]: # ()
[//]: # (### Webpack)

[//]: # ()
[//]: # ([Webpack]&#40;https://webpack.js.org&#41; is a JS bundler with extensions, like a static dev server that enables hot reloading on code changes. Configuration for Webpack is defined in the `webpack.config.js` file. Note this sample only includes basic Webpack configuration for development mode, if you want to see a more comprehensive configuration check the [Fable webpack-config-template]&#40;https://github.com/fable-compiler/webpack-config-template/blob/master/webpack.config.js&#41;.)

[//]: # ()
[//]: # (### F#)

[//]: # ()
[//]: # (The sample only contains two F# files: the project &#40;.fsproj&#41; and a source file &#40;.fs&#41; in the `src` folder.)

[//]: # ()
[//]: # (### Web assets)

[//]: # ()
[//]: # (The `index.html` file and other assets like an icon can be found in the `public` folder.)
