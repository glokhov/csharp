namespace FDocument

open System.Xml.Linq
open FInvoke.Result

module private Option =
    let inline some (value: 'T) : 'T option =
        match value with
        | null -> None
        | v -> Some v

module XContainer =
    let inline element (name: XName) (container: XContainer) : XElement option =
        container.Element(name) |> Option.some

    let inline elements (container: XContainer) : XElement seq =
        container.Elements()

    let inline elements2 (name: XName) (container: XContainer) : XElement seq =
        container.Elements(name)

module XElement =
    let inline element (name: XName) (element: XElement) : XElement option =
        XContainer.element name element

    let inline elements (element: XElement) : XElement seq =
        XContainer.elements element

    let inline elements2 (name: XName) (element: XElement) : XElement seq =
        XContainer.elements2 name element

    let inline firstAttribute (element: XElement) : XAttribute option =
        element.FirstAttribute |> Option.some

    let inline lastAttribute (element: XElement) : XAttribute option =
        element.LastAttribute |> Option.some

    let inline attribute (name: XName) (element: XElement) : XAttribute option =
        element.Attribute(name) |> Option.some

    let inline attributes (element: XElement) : XAttribute seq =
        element.Attributes()

    let inline attributes2 (name: XName) (element: XElement) : XAttribute seq =
        element.Attributes(name)

    let inline parse (text: string) : Result<XElement, exn> = invoke XElement.Parse text

    let inline parse2 (text: string) (options: LoadOptions) : Result<XElement, exn> =
        invoke2 XElement.Parse text options

    let inline load (uri: string) : Result<XElement, exn> =
        let load: string -> Result<XElement, exn> = invoke XElement.Load
        load uri

    let inline load2 (uri: string) (options: LoadOptions) : Result<XElement, exn> =
        let load: string -> LoadOptions -> Result<XElement, exn> = invoke2 XElement.Load
        load uri options

    let inline save (filename: string) (element: XElement) : Result<unit, exn> =
        let save: string -> Result<unit, exn> = invoke element.Save
        save filename

    let inline save2 (filename: string) (options: SaveOptions) (element: XElement) : Result<unit, exn> =
        let save: string -> SaveOptions -> Result<unit, exn> = invoke2 element.Save
        save filename options

module XDocument =
    let inline element (name: XName) (document: XDocument) : XElement option =
        XContainer.element name document

    let inline elements (document: XDocument) : XElement seq =
        XContainer.elements document

    let inline elements2 (name: XName) (document: XDocument) : XElement seq =
        XContainer.elements2 name document

    let inline root (document: XDocument) : XElement option =
        document.Root |> Option.some

    let inline declaration (document: XDocument) : XDeclaration option =
        document.Declaration |> Option.some

    let inline documentType (document: XDocument) : XDocumentType option =
        document.DocumentType |> Option.some

    let inline parse (text: string) : Result<XDocument, exn> =
        invoke XDocument.Parse text

    let inline parse2 (text: string) (options: LoadOptions) : Result<XDocument, exn> =
        invoke2 XDocument.Parse text options

    let inline load (uri: string) : Result<XDocument, exn> =
        let load: string -> Result<XDocument, exn> = invoke XDocument.Load
        load uri

    let inline load2 (uri: string) (options: LoadOptions) : Result<XDocument, exn> =
        let load: string -> LoadOptions -> Result<XDocument, exn> = invoke2 XDocument.Load
        load uri options

    let inline save (filename: string) (document: XDocument) : Result<unit, exn> =
        let save: string -> Result<unit, exn> = invoke document.Save
        save filename

    let inline save2 (filename: string) (options: SaveOptions) (document: XDocument) : Result<unit, exn> =
        let save: string -> SaveOptions -> Result<unit, exn> = invoke2 document.Save
        save filename options
