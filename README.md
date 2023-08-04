# BookCompiler
Compile Ebook from specified novel website, 
for website protected with cloudflare the app work in semi-auto mode, requiring confirmation if webpage correctly loaded

## Include
- Webview for loading content
- Profile Manager for extraction profile
- Compile novel in epub format
- Cover generator in another linked application(because multiple webview in one app is a big problem)

## Next Developments
- Alternative extraction mode for website fragmenting chapters list and loaded by REST API
- Alternative mode with user giving list of links as chapters list
- Load cover image via an url and not extraction data from IMG DOM object
- Recuperation of the Author(s) / Manual Input Author(s)

## Libs
- net7.0-windows
- Microsoft.Web.WebView2
- Newtonsoft.Json
- SharpCompress