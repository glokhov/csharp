namespace FDocument

open System.Xml.Linq
open FInvoke.Result

module private Option =
    let inline some (value: 'T) : 'T option =
        match value with
        | null -> None
        | v -> Some v

module XNode =
    let inline nextNode (node: XNode) : XNode option = node.NextNode |> Option.some

    let inline previousNode (node: XNode) : XNode option = node.PreviousNode |> Option.some

    let inline toString (node: XNode) : string = node.ToString()

    let inline toString2 (options: SaveOptions) (node: XNode) : string = node.ToString(options)

module XContainer =
    let inline nextNode (container: XContainer) : XNode option = XNode.nextNode container

    let inline previousNode (container: XContainer) : XNode option = XNode.previousNode container

    let inline toString (container: XContainer) : string = XNode.toString container

    let inline toString2 (options: SaveOptions) (container: XContainer) : string = XNode.toString2 options container

    let inline firstNode (container: XContainer) : XNode option = container.FirstNode |> Option.some

    let inline lastNode (container: XContainer) : XNode option = container.LastNode |> Option.some

    let inline nodes (container: XContainer) : XNode seq = container.Nodes()

    let inline element (name: XName) (container: XContainer) : XElement option = container.Element(name) |> Option.some

    let inline elements (container: XContainer) : XElement seq = container.Elements()

    let inline elements2 (name: XName) (container: XContainer) : XElement seq = container.Elements(name)

module XElement =
    let inline nextNode (element: XElement) : XNode option = XNode.nextNode element

    let inline previousNode (element: XElement) : XNode option = XNode.previousNode element

    let inline toString (element: XElement) : string = XNode.toString element

    let inline toString2 (options: SaveOptions) (element: XElement) : string = XNode.toString2 options element

    let inline firstNode (element: XElement) : XNode option = XContainer.firstNode element

    let inline lastNode (element: XElement) : XNode option = XContainer.lastNode element

    let inline nodes (element: XElement) : XNode seq = XContainer.nodes element

    let inline element (name: XName) (element: XElement) : XElement option = XContainer.element name element

    let inline elements (element: XElement) : XElement seq = XContainer.elements element

    let inline elements2 (name: XName) (element: XElement) : XElement seq = XContainer.elements2 name element

    let inline firstAttribute (element: XElement) : XAttribute option = element.FirstAttribute |> Option.some

    let inline lastAttribute (element: XElement) : XAttribute option = element.LastAttribute |> Option.some

    let inline attribute (name: XName) (element: XElement) : XAttribute option = element.Attribute(name) |> Option.some

    let inline attributes (element: XElement) : XAttribute seq = element.Attributes()

    let inline attributes2 (name: XName) (element: XElement) : XAttribute seq = element.Attributes(name)

    let inline parse (text: string) : Result<XElement, exn> = invoke XElement.Parse text

    let inline parse2 (text: string) (options: LoadOptions) : Result<XElement, exn> = invoke2 XElement.Parse text options

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
    let inline toString (document: XDocument) : string = XNode.toString document

    let inline toString2 (options: SaveOptions) (document: XDocument) : string = XNode.toString2 options document

    let inline firstNode (document: XDocument) : XNode option = XContainer.firstNode document

    let inline lastNode (document: XDocument) : XNode option = XContainer.lastNode document

    let inline nodes (document: XDocument) : XNode seq = XContainer.nodes document

    let inline element (name: XName) (document: XDocument) : XElement option = XContainer.element name document

    let inline elements (document: XDocument) : XElement seq = XContainer.elements document

    let inline elements2 (name: XName) (document: XDocument) : XElement seq = XContainer.elements2 name document

    let inline root (document: XDocument) : XElement option = document.Root |> Option.some

    let inline declaration (document: XDocument) : XDeclaration option = document.Declaration |> Option.some

    let inline documentType (document: XDocument) : XDocumentType option = document.DocumentType |> Option.some

    let inline parse (text: string) : Result<XDocument, exn> = invoke XDocument.Parse text

    let inline parse2 (text: string) (options: LoadOptions) : Result<XDocument, exn> = invoke2 XDocument.Parse text options

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
