module FileSystem

open Fable.Core
open Fable.Core.JsInterop

[<ImportDefault("fs")>]
let fs: obj = jsNative

let readSVG(fileName:string) : obj =
    fs?readFileSync(fileName, "utf-8")

let readCSV(fileName:string) : string =
    fs?readFileSync(fileName)

let readImage(fileName:string) : obj =
    fs?readFileSync(fileName)

let getFiles(folderName:string) : string [] =
    fs?readdirSync(folderName)

let createWriteStream(fileName:string) : obj =
    fs?createWriteStream(fileName)