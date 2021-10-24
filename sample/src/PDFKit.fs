module PDFKit

open Fable.Core.JsInterop

type PageRange = {
    start : int
    count : int
}

type IPDFDocument =
    abstract ``end`` : unit -> unit
    abstract stroke : unit -> IPDFDocument
    abstract font : string -> IPDFDocument
    abstract strokeColor : string -> IPDFDocument
    abstract fillColor : string -> IPDFDocument
    abstract fontSize : int -> IPDFDocument
    abstract lineWidth : int -> IPDFDocument
    abstract widthOfString : string -> int
    abstract moveTo : int * int -> IPDFDocument
    abstract moveDown : unit -> IPDFDocument
    abstract lineTo : int * int -> IPDFDocument
    abstract text : string * int * int -> IPDFDocument
    abstract text : string * int * int * obj -> IPDFDocument
    abstract image : obj * int * int -> IPDFDocument
    abstract image : obj * int * int * obj -> IPDFDocument
    abstract addSVG : obj * int * int -> IPDFDocument
    abstract addSVG : obj * int * int * obj -> IPDFDocument
    abstract addPage : unit -> IPDFDocument
    abstract switchToPage : int -> unit
    abstract bufferedPageRange : unit -> PageRange

let createDocument(settings:obj) : IPDFDocument = importMember "../pdfkitHelper.js"
