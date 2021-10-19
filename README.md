# Fable.PDFKit

Fable bindings and helpers for [PDFKit](https://pdfkit.org/).

## Installation

```
npm install --save pdfkit svg-to-pdfkit # or
yarn add pdfkit svg-to-pdfkit

paket add Fable.PDFKit --project [yourproject]
```

## Usage

    open System
    open Fable.Core.JsInterop
    open ServerCode.Domain
    open System.Collections.Generic
    open Fable.PDFKit

    let doc =
        createDocument {| size = "A4"; margins = {| top = 50; bottom = 50; left = 72; right = 50 |} ; bufferPages = true |}
            .fillColor("#444444")
            .fontSize(10)
            .text("Hello World!", 0, 100, {| align = "right" |})

    doc?pipe(FileSystem.createWriteStream("output/MyDocument.pdf"))

## Release process

After installing dependencies with `yarn install`, run `yarn run build publish` to publish a new package