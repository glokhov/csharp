namespace FDocument

open System.Xml.Linq
open FInvoke.Result

module XObject =
    let inline document (obj: XObject) : XDocument option = obj.Document |> Option.ofObj

    let inline parent (obj: XObject) : XElement option = obj.Parent |> Option.ofObj

module XAttribute =
    let inline nextAttribute (attribute: XAttribute) : XAttribute option = attribute.NextAttribute |> Option.ofObj

    let inline previousAttribute (attribute: XAttribute) : XAttribute option = attribute.PreviousAttribute |> Option.ofObj

    let inline toString (attribute: XAttribute) : string = attribute.ToString()

    // XObject

    let inline document (attribute: XAttribute) : XDocument option = XObject.document attribute

    let inline parent (attribute: XAttribute) : XElement option = XObject.parent attribute

module XNode =
    let inline nextNode (node: XNode) : XNode option = node.NextNode |> Option.ofObj

    let inline previousNode (node: XNode) : XNode option = node.PreviousNode |> Option.ofObj

    let inline toString (node: XNode) : string = node.ToString()

    let inline toStringWithOptions (options: SaveOptions) (node: XNode) : string = node.ToString(options)

    // XObject

    let inline document (node: XNode) : XDocument option = XObject.document node

    let inline parent (node: XNode) : XElement option = XObject.parent node

module XContainer =
    let inline firstNode (container: XContainer) : XNode option = container.FirstNode |> Option.ofObj

    let inline lastNode (container: XContainer) : XNode option = container.LastNode |> Option.ofObj

    let inline nodes (container: XContainer) : XNode seq = container.Nodes()

    let inline element (name: XName) (container: XContainer) : XElement option = container.Element(name) |> Option.ofObj

    let inline elements (container: XContainer) : XElement seq = container.Elements()

    let inline elementsByName (name: XName) (container: XContainer) : XElement seq = container.Elements(name)

module XElement =
    let inline firstAttribute (element: XElement) : XAttribute option = element.FirstAttribute |> Option.ofObj

    let inline lastAttribute (element: XElement) : XAttribute option = element.LastAttribute |> Option.ofObj

    let inline attribute (name: XName) (element: XElement) : XAttribute option = element.Attribute(name) |> Option.ofObj

    let inline attributes (element: XElement) : XAttribute seq = element.Attributes()

    let inline attributesByName (name: XName) (element: XElement) : XAttribute seq = element.Attributes(name)

    let inline parse (text: string) : Result<XElement, exn> = invoke XElement.Parse text

    let inline parseWithOptions (options: LoadOptions) (text: string) : Result<XElement, exn> = invoke2 XElement.Parse text options

    let inline load (uri: string) : Result<XElement, exn> =
        let load: string -> Result<XElement, exn> = invoke XElement.Load
        load uri

    let inline loadWithOptions (options: LoadOptions) (uri: string) : Result<XElement, exn> =
        let load: string -> LoadOptions -> Result<XElement, exn> = invoke2 XElement.Load
        load uri options

    let inline save (filename: string) (element: XElement) : Result<unit, exn> =
        let save: string -> Result<unit, exn> = invoke element.Save
        save filename

    let inline saveWithOptions (options: SaveOptions) (filename: string) (element: XElement) : Result<unit, exn> =
        let save: string -> SaveOptions -> Result<unit, exn> = invoke2 element.Save
        save filename options

    // XContainer

    let inline firstNode (element: XElement) : XNode option = XContainer.firstNode element

    let inline lastNode (element: XElement) : XNode option = XContainer.lastNode element

    let inline nodes (element: XElement) : XNode seq = XContainer.nodes element

    let inline element (name: XName) (element: XElement) : XElement option = XContainer.element name element

    let inline elements (element: XElement) : XElement seq = XContainer.elements element

    let inline elementsByName (name: XName) (element: XElement) : XElement seq = XContainer.elementsByName name element

    // XNode

    let inline nextNode (element: XElement) : XNode option = XNode.nextNode element

    let inline previousNode (element: XElement) : XNode option = XNode.previousNode element

    let inline toString (element: XElement) : string = XNode.toString element

    let inline toStringWithOptions (options: SaveOptions) (element: XElement) : string = XNode.toStringWithOptions options element

    // XObject

    let inline document (element: XElement) : XDocument option = XObject.document element

    let inline parent (element: XElement) : XElement option = XObject.parent element

module XDocument =
    let inline root (document: XDocument) : XElement option = document.Root |> Option.ofObj

    let inline declaration (document: XDocument) : XDeclaration option = document.Declaration |> Option.ofObj

    let inline documentType (document: XDocument) : XDocumentType option = document.DocumentType |> Option.ofObj

    let inline parse (text: string) : Result<XDocument, exn> = invoke XDocument.Parse text

    let inline parseWithOptions (options: LoadOptions) (text: string) : Result<XDocument, exn> = invoke2 XDocument.Parse text options

    let inline load (uri: string) : Result<XDocument, exn> =
        let load: string -> Result<XDocument, exn> = invoke XDocument.Load
        load uri

    let inline loadWithOptions (options: LoadOptions) (uri: string) : Result<XDocument, exn> =
        let load: string -> LoadOptions -> Result<XDocument, exn> = invoke2 XDocument.Load
        load uri options

    let inline save (filename: string) (document: XDocument) : Result<unit, exn> =
        let save: string -> Result<unit, exn> = invoke document.Save
        save filename

    let inline saveWithOptions (options: SaveOptions) (filename: string) (document: XDocument) : Result<unit, exn> =
        let save: string -> SaveOptions -> Result<unit, exn> = invoke2 document.Save
        save filename options

    // XContainer

    let inline firstNode (document: XDocument) : XNode option = XContainer.firstNode document

    let inline lastNode (document: XDocument) : XNode option = XContainer.lastNode document

    let inline nodes (document: XDocument) : XNode seq = XContainer.nodes document

    let inline element (name: XName) (document: XDocument) : XElement option = XContainer.element name document

    let inline elements (document: XDocument) : XElement seq = XContainer.elements document

    let inline elementsByName (name: XName) (document: XDocument) : XElement seq = XContainer.elementsByName name document

    // XNode

    let inline toString (document: XDocument) : string = XNode.toString document

    let inline toStringWithOptions (options: SaveOptions) (document: XDocument) : string = XNode.toStringWithOptions options document
