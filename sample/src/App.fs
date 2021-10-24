module App

open Fable.Core.JsInterop
open PDFKit

let renderDocument text =
    let doc =
        createDocument {| size = "A4"; margins = {| top = 50; bottom = 50; left = 72; right = 50 |}; bufferPages = true |}
    doc
        .text(text, 100, 100, {| align = "left" |})

let fileName = "out/Sample.pdf"
printfn $"Rendering {fileName}"
let doc = renderDocument "Hello World"
doc?pipe(FileSystem.createWriteStream fileName)
doc.``end``()



printfn "Done."
 