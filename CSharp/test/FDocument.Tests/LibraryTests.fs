namespace FDocument.Tests

open System.IO
open System.Xml.Linq
open Xunit

module XNode =
    open FDocument.XNode

    let xFirst: XNode = XElement("first")
    let xSecond: XNode = XElement("second")
    let xThird: XNode = XElement("third")
    let cNodes: obj array = [| xFirst; xSecond; xThird |]
    let xNodes: XElement = XElement("nodes", cNodes)

    [<Fact>]
    let ``if previous node exists previousNode returns the node`` () =
        let node = xNodes.Element("second")
        match previousNode node with
        | Some n -> Assert.Equal("first", (n :?> XElement).Name.LocalName)
        | None -> Assert.Fail()

    [<Fact>]
    let ``if no previous node exists previousNode returns none`` () =
        let node = xNodes.Element("first")
        match previousNode node with
        | Some _ -> Assert.Fail()
        | None -> ()

    [<Fact>]
    let ``if next node exists nextNode returns the node`` () =
        let node = xNodes.Element("second")
        match nextNode node with
        | Some n -> Assert.Equal("third", (n :?> XElement).Name.LocalName)
        | None -> Assert.Fail()

    [<Fact>]
    let ``if no next node exists nextNode returns none`` () =
        let node = xNodes.Element("third")
        match nextNode node with
        | Some _ -> Assert.Fail()
        | None -> ()

    let formatted = "<nodes>\n  <first />\n  <second />\n  <third />\n</nodes>"
    let unformatted = "<nodes><first /><second /><third /></nodes>"

    [<Fact>]
    let ``toString test`` () =
        Assert.Equal(formatted, (toString xNodes).Replace("\r\n", "\n"))

    [<Fact>]
    let ``toString2 test`` () =
        Assert.Equal(unformatted, toString2 SaveOptions.DisableFormatting xNodes)

module XContainer =
    open FDocument.XContainer

    let xRoot: XContainer = XElement("root")
    let xElement: XContainer = XElement("root", XElement("first"), XElement("second"))

    [<Fact>]
    let ``if multiple nodes firstNode returns first node`` () =
        match firstNode xElement with
        | Some a -> Assert.Equal("first", (a :?> XElement).Name.LocalName)
        | None -> Assert.Fail()

    [<Fact>]
    let ``if no nodes firstNode returns none`` () =
        match firstNode xRoot with
        | Some _ -> Assert.Fail()
        | None -> ()

    [<Fact>]
    let ``if multiple nodes lastNode returns last node`` () =
        match lastNode xElement with
        | Some a -> Assert.Equal("second", (a :?> XElement).Name.LocalName)
        | None -> Assert.Fail()

    [<Fact>]
    let ``if no nodes lastNode returns none`` () =
        match lastNode xRoot with
        | Some _ -> Assert.Fail()
        | None -> ()

    [<Fact>]
    let ``if nodes exist nodes returns nodes`` () =
        match nodes xElement |> Seq.toList with
        | a :: _ -> Assert.Equal("first", (a :?> XElement).Name.LocalName)
        | [] -> Assert.Fail()

    [<Fact>]
    let ``if no nodes exist nodes returns empty`` () =
        match nodes xRoot |> Seq.toList with
        | _ :: _ -> Assert.Fail()
        | [] -> ()

    [<Fact>]
    let ``if an element exists element returns the element (first)`` () =
        match element (XName.Get("first")) xElement with
        | Some e -> Assert.Equal("first", e.Name.LocalName)
        | None -> Assert.Fail()

    [<Fact>]
    let ``if an element exists element returns the element (second)`` () =
        match element (XName.Get("second")) xElement with
        | Some e -> Assert.Equal("second", e.Name.LocalName)
        | None -> Assert.Fail()

    [<Fact>]
    let ``if no element exists element returns none`` () =
        match element (XName.Get("foo")) xElement with
        | Some _ -> Assert.Fail()
        | None -> ()

    [<Fact>]
    let ``if no elements exist element returns none`` () =
        match element (XName.Get("foo")) xRoot with
        | Some _ -> Assert.Fail()
        | None -> ()

    [<Fact>]
    let ``if elements exist elements returns elements`` () =
        match elements xElement |> Seq.toList with
        | a :: _ -> Assert.Equal("first", a.Name.LocalName)
        | [] -> Assert.Fail()

    [<Fact>]
    let ``if no elements exist elements returns empty`` () =
        match elements xRoot |> Seq.toList with
        | _ :: _ -> Assert.Fail()
        | [] -> ()

    [<Fact>]
    let ``if an element exists elements2 returns the element`` () =
        match elements2 (XName.Get("first")) xElement |> Seq.toList with
        | a :: _ -> Assert.Equal("first", a.Name.LocalName)
        | [] -> Assert.Fail()

    [<Fact>]
    let ``if no element exists elements2 returns empty`` () =
        match elements2 (XName.Get("foo")) xElement |> Seq.toList with
        | _ :: _ -> Assert.Fail()
        | [] -> ()

    [<Fact>]
    let ``if no elements exist elements2 returns empty`` () =
        match elements2 (XName.Get("foo")) xRoot |> Seq.toList with
        | _ :: _ -> Assert.Fail()
        | [] -> ()

    let unformatted = "<root><first /><second /></root>"
    let formatted = "<root>\n  <first />\n  <second />\n</root>"

    [<Fact>]
    let ``nextNode test`` () =
        match nextNode (xElement.FirstNode :?> XElement) with
        | Some a -> Assert.Equal("second", (a :?> XElement).Name.LocalName)
        | None -> Assert.Fail()

    [<Fact>]
    let ``previousNode test`` () =
        match previousNode (xElement.LastNode :?> XElement)  with
        | Some a -> Assert.Equal("first", (a :?> XElement).Name.LocalName)
        | None -> Assert.Fail()

    [<Fact>]
    let ``toString test`` () =
        Assert.Equal(formatted, (toString xElement).Replace("\r\n", "\n"))

    [<Fact>]
    let ``toString2 test`` () =
        Assert.Equal(unformatted, toString2 SaveOptions.DisableFormatting xElement)

module XElement =
    open FDocument.XElement

    let xRoot: XElement = XElement("root", XElement("element"))
    let xFstAttr: XAttribute = XAttribute("first", "First")
    let xSndAttr: XAttribute = XAttribute("second", "Second")
    let xFstElem: XElement = XElement("first")
    let xSndElem: XElement = XElement("second")
    let xObjects: obj array = [| xFstAttr; xSndAttr; xFstElem; xSndElem |]
    let xElement: XElement = XElement("root", xObjects)

    [<Fact>]
    let ``if multiple attributes firstAttribute returns first attribute`` () =
        match firstAttribute xElement with
        | Some a -> Assert.Equal("first", a.Name.LocalName)
        | None -> Assert.Fail()

    [<Fact>]
    let ``if no attributes firstAttribute returns none`` () =
        match firstAttribute xRoot with
        | Some _ -> Assert.Fail()
        | None -> ()

    [<Fact>]
    let ``if multiple attributes lastAttribute returns last attribute`` () =
        match lastAttribute xElement with
        | Some a -> Assert.Equal("second", a.Name.LocalName)
        | None -> Assert.Fail()

    [<Fact>]
    let ``if no attributes lastAttribute returns none`` () =
        match lastAttribute xRoot with
        | Some _ -> Assert.Fail()
        | None -> ()

    [<Fact>]
    let ``if an attribute exists attribute returns the attribute (first)`` () =
        match attribute (XName.Get("first")) xElement with
        | Some a -> Assert.Equal("first", a.Name.LocalName)
        | None -> Assert.Fail()

    [<Fact>]
    let ``if an attribute exists attribute returns the attribute (second)`` () =
        match attribute (XName.Get("second")) xElement with
        | Some a -> Assert.Equal("second", a.Name.LocalName)
        | None -> Assert.Fail()

    [<Fact>]
    let ``if no attribute exists attribute returns none`` () =
        match attribute (XName.Get("foo")) xElement with
        | Some _ -> Assert.Fail()
        | None -> ()

    [<Fact>]
    let ``if no attributes exist attribute returns none`` () =
        match attribute (XName.Get("foo")) xRoot with
        | Some _ -> Assert.Fail()
        | None -> ()

    [<Fact>]
    let ``if attributes exist attributes returns attributes`` () =
        match attributes xElement |> Seq.toList with
        | a :: _ -> Assert.Equal("first", a.Name.LocalName)
        | [] -> Assert.Fail()

    [<Fact>]
    let ``if no attributes exist attributes returns empty`` () =
        match attributes xRoot |> Seq.toList with
        | _ :: _ -> Assert.Fail()
        | [] -> ()

    [<Fact>]
    let ``if an attribute exists attributes2 returns the attribute`` () =
        match attributes2 (XName.Get("first")) xElement |> Seq.toList with
        | a :: _ -> Assert.Equal("first", a.Name.LocalName)
        | [] -> Assert.Fail()

    [<Fact>]
    let ``if no attribute exists attributes2 returns empty`` () =
        match attributes2 (XName.Get("foo")) xElement |> Seq.toList with
        | _ :: _ -> Assert.Fail()
        | [] -> ()

    [<Fact>]
    let ``if no attributes exist attributes2 returns empty`` () =
        match attributes2 (XName.Get("foo")) xRoot |> Seq.toList with
        | _ :: _ -> Assert.Fail()
        | [] -> ()

    [<Fact>]
    let ``if element valid parse returns ok`` () =
        match parse "<root />" with
        | Ok e -> Assert.Equal("root", e.Name.LocalName)
        | Error e -> Assert.Fail(e.Message)

    [<Fact>]
    let ``if element invalid parse returns error`` () =
        match parse "" with
        | Ok _ -> Assert.Fail()
        | Error e -> Assert.Equal("Root element is missing.", e.Message)

    [<Fact>]
    let ``if load options none parse2 returns ok`` () =
        match parse2 "<root> </root>" LoadOptions.None with
        | Ok e -> Assert.Equal("", e.Value)
        | Error e -> Assert.Fail(e.Message)

    [<Fact>]
    let ``if load options whitespaces parse2 returns ok`` () =
        match parse2 "<root> </root>" LoadOptions.PreserveWhitespace with
        | Ok e -> Assert.Equal(" ", e.Value)
        | Error e -> Assert.Fail(e.Message)

    [<Fact>]
    let ``if element invalid parse2 returns error`` () =
        match parse2 "" LoadOptions.None with
        | Ok _ -> Assert.Fail()
        | Error e -> Assert.Equal("Root element is missing.", e.Message)

    [<Fact>]
    let ``if element valid load returns ok`` () =
        let temp = Path.GetTempFileName()
        File.WriteAllText(temp, "<root />")

        match load temp with
        | Ok e -> Assert.Equal("root", e.Name.LocalName)
        | Error e -> Assert.Fail(e.Message)

        File.Delete(temp)

    [<Fact>]
    let ``if element invalid load returns error`` () =
        let temp = Path.GetTempFileName()
        File.WriteAllText(temp, "")

        match load temp with
        | Ok _ -> Assert.Fail()
        | Error e -> Assert.Equal("Root element is missing.", e.Message)

        File.Delete(temp)

    [<Fact>]
    let ``if load options none load2 returns ok`` () =
        let temp = Path.GetTempFileName()
        File.WriteAllText(temp, "<root> </root>")

        match load2 temp LoadOptions.None with
        | Ok e -> Assert.Equal("", e.Value)
        | Error e -> Assert.Fail(e.Message)

        File.Delete(temp)

    [<Fact>]
    let ``if load options whitespaces load2 returns ok`` () =
        let temp = Path.GetTempFileName()
        File.WriteAllText(temp, "<root> </root>")

        match load2 temp LoadOptions.PreserveWhitespace with
        | Ok e -> Assert.Equal(" ", e.Value)
        | Error e -> Assert.Fail(e.Message)

        File.Delete(temp)

    [<Fact>]
    let ``if element invalid load2 returns error`` () =
        let temp = Path.GetTempFileName()
        File.WriteAllText(temp, "")

        match load2 temp LoadOptions.None with
        | Ok _ -> Assert.Fail()
        | Error e -> Assert.Equal("Root element is missing.", e.Message)

        File.Delete(temp)

    let formatted = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n<root>\n  <element />\n</root>"
    let unformatted = "<?xml version=\"1.0\" encoding=\"utf-8\"?><root><element /></root>"

    [<Fact>]
    let ``save successful`` () =
        let temp = Path.GetTempFileName()

        match xRoot |> save temp with
        | Ok _ -> Assert.Equal(formatted, File.ReadAllText(temp).Replace("\r\n", "\n"))
        | Error e -> Assert.Fail(e.Message)

        File.Delete(temp)

    [<Fact>]
    let ``save options none save2`` () =
        let temp = Path.GetTempFileName()

        match xRoot |> save2 temp SaveOptions.None with
        | Ok _ -> Assert.Equal(formatted, File.ReadAllText(temp).Replace("\r\n", "\n"))
        | Error e -> Assert.Fail(e.Message)

        File.Delete(temp)

    [<Fact>]
    let ``save options formating save2`` () =
        let temp = Path.GetTempFileName()

        match xRoot |> save2 temp SaveOptions.DisableFormatting with
        | Ok _ -> Assert.Equal(unformatted, File.ReadAllText(temp))
        | Error e -> Assert.Fail(e.Message)

        File.Delete(temp)

    [<Fact>]
    let ``element test`` () =
        match element (XName.Get("element")) xRoot with
        | Some e -> Assert.Equal("element", e.Name.LocalName)
        | None -> Assert.Fail()

    [<Fact>]
    let ``elements test`` () =
        match elements xRoot |> Seq.toList with
        | e :: _ -> Assert.Equal("element", e.Name.LocalName)
        | [] -> Assert.Fail()

    [<Fact>]
    let ``elements2 test`` () =
        match elements2 (XName.Get("element")) xRoot |> Seq.toList with
        | e :: _ -> Assert.Equal("element", e.Name.LocalName)
        | [] -> Assert.Fail()

    [<Fact>]
    let ``firstNode test`` () =
        match firstNode xRoot with
        | Some a -> Assert.Equal("element", (a :?> XElement).Name.LocalName)
        | None -> Assert.Fail()

    [<Fact>]
    let ``lastNode test`` () =
        match lastNode xRoot with
        | Some a -> Assert.Equal("element", (a :?> XElement).Name.LocalName)
        | None -> Assert.Fail()

    [<Fact>]
    let ``nodes test`` () =
        match nodes xRoot |> Seq.toList with
        | a :: _ -> Assert.Equal("element", (a :?> XElement).Name.LocalName)
        | [] -> Assert.Fail()

    [<Fact>]
    let ``nextNode test`` () =
        match nextNode (xElement.FirstNode :?> XElement) with
        | Some a -> Assert.Equal("second", (a :?> XElement).Name.LocalName)
        | None -> Assert.Fail()

    [<Fact>]
    let ``previousNode test`` () =
        match previousNode (xElement.LastNode :?> XElement)  with
        | Some a -> Assert.Equal("first", (a :?> XElement).Name.LocalName)
        | None -> Assert.Fail()

    let unformattedNode = "<root><element /></root>"
    let formattedNode = "<root>\n  <element />\n</root>"

    [<Fact>]
    let ``toString test`` () =
        Assert.Equal(formattedNode, (toString xRoot).Replace("\r\n", "\n"))

    [<Fact>]
    let ``toString2 test`` () =
        Assert.Equal(unformattedNode, toString2 SaveOptions.DisableFormatting xRoot)

module XDocument =
    open FDocument.XDocument

    let xDecl: XDeclaration = XDeclaration("1.0", "", "")
    let xDocType: XDocumentType = XDocumentType("XML", "", "", "")
    let xElement: XElement = XElement("element")
    let cElement: obj array = [| xElement |]
    let xRoot: XElement = XElement("root", cElement)
    let cRoot: obj array = [| xRoot |]
    let cDocType: obj array = [| xDocType; xRoot |]
    let xDoc: XDocument = XDocument()
    let xDocPlusRoot: XDocument = XDocument(xRoot)
    let xDocPlusDecl: XDocument = XDocument(declaration = xDecl, content = cRoot)
    let xDocPlusDocType: XDocument = XDocument(declaration = xDecl, content = cDocType)

    [<Fact>]
    let ``if root present root returns some`` () =
        match xDocPlusRoot |> root with
        | Some e -> Assert.Equal("root", e.Name.LocalName)
        | None -> Assert.Fail()

    [<Fact>]
    let ``if no root present root returns none`` () =
        match xDoc |> root with
        | Some _ -> Assert.Fail()
        | None -> ()

    [<Fact>]
    let ``if declaration present declaration returns some`` () =
        match xDocPlusDecl |> declaration with
        | Some d -> Assert.Equal("1.0", d.Version)
        | None -> Assert.Fail()

    [<Fact>]
    let ``if no declaration present declaration returns none`` () =
        match xDocPlusRoot |> declaration with
        | Some _ -> Assert.Fail()
        | None -> ()

    [<Fact>]
    let ``if documentType present documentType returns some`` () =
        match xDocPlusDocType |> documentType with
        | Some d -> Assert.Equal("XML", d.Name)
        | None -> Assert.Fail()

    [<Fact>]
    let ``if no documentType present documentType returns none`` () =
        match xDocPlusRoot |> documentType with
        | Some _ -> Assert.Fail()
        | None -> ()

    [<Fact>]
    let ``if document valid parse returns ok`` () =
        match parse "<root />" with
        | Ok d -> Assert.Equal("root", d.Root.Name.LocalName)
        | Error e -> Assert.Fail(e.Message)

    [<Fact>]
    let ``if document invalid parse returns error`` () =
        match parse "" with
        | Ok _ -> Assert.Fail()
        | Error e -> Assert.Equal("Root element is missing.", e.Message)

    [<Fact>]
    let ``if load options none parse2 returns ok`` () =
        match parse2 "<root> </root>" LoadOptions.None with
        | Ok d -> Assert.Equal("", d.Root.Value)
        | Error e -> Assert.Fail(e.Message)

    [<Fact>]
    let ``if load options whitespaces parse2 returns ok`` () =
        match parse2 "<root> </root>" LoadOptions.PreserveWhitespace with
        | Ok d -> Assert.Equal(" ", d.Root.Value)
        | Error e -> Assert.Fail(e.Message)

    [<Fact>]
    let ``if document invalid parse2 returns error`` () =
        match parse2 "" LoadOptions.None with
        | Ok _ -> Assert.Fail()
        | Error e -> Assert.Equal("Root element is missing.", e.Message)

    [<Fact>]
    let ``if document valid load returns ok`` () =
        let temp = Path.GetTempFileName()
        File.WriteAllText(temp, "<root />")

        match load temp with
        | Ok d -> Assert.Equal("root", d.Root.Name.LocalName)
        | Error e -> Assert.Fail(e.Message)

        File.Delete(temp)

    [<Fact>]
    let ``if document invalid load returns error`` () =
        let temp = Path.GetTempFileName()
        File.WriteAllText(temp, "")

        match load temp with
        | Ok _ -> Assert.Fail()
        | Error e -> Assert.Equal("Root element is missing.", e.Message)

        File.Delete(temp)

    [<Fact>]
    let ``if load options none load2 returns ok`` () =
        let temp = Path.GetTempFileName()
        File.WriteAllText(temp, "<root> </root>")

        match load2 temp LoadOptions.None with
        | Ok d -> Assert.Equal("", d.Root.Value)
        | Error e -> Assert.Fail(e.Message)

        File.Delete(temp)

    [<Fact>]
    let ``if load options whitespaces load2 returns ok`` () =
        let temp = Path.GetTempFileName()
        File.WriteAllText(temp, "<root> </root>")

        match load2 temp LoadOptions.PreserveWhitespace with
        | Ok d -> Assert.Equal(" ", d.Root.Value)
        | Error e -> Assert.Fail(e.Message)

        File.Delete(temp)

    [<Fact>]
    let ``if document invalid load2 returns error`` () =
        let temp = Path.GetTempFileName()
        File.WriteAllText(temp, "")

        match load2 temp LoadOptions.None with
        | Ok _ -> Assert.Fail()
        | Error e -> Assert.Equal("Root element is missing.", e.Message)

        File.Delete(temp)

    let unformatted = "<?xml version=\"1.0\" encoding=\"utf-8\"?><root><element /></root>"
    let formatted = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n<root>\n  <element />\n</root>"

    [<Fact>]
    let ``save successful`` () =
        let temp = Path.GetTempFileName()

        match xDocPlusDecl |> save temp with
        | Ok _ -> Assert.Equal(formatted, File.ReadAllText(temp).Replace("\r\n", "\n"))
        | Error e -> Assert.Fail(e.Message)

        File.Delete(temp)

    [<Fact>]
    let ``save options none save2`` () =
        let temp = Path.GetTempFileName()

        match xDocPlusDecl |> save2 temp SaveOptions.None with
        | Ok _ -> Assert.Equal(formatted, File.ReadAllText(temp).Replace("\r\n", "\n"))
        | Error e -> Assert.Fail(e.Message)

        File.Delete(temp)

    [<Fact>]
    let ``save options formating save2`` () =
        let temp = Path.GetTempFileName()

        match xDocPlusDecl |> save2 temp SaveOptions.DisableFormatting with
        | Ok _ -> Assert.Equal(unformatted, File.ReadAllText(temp))
        | Error e -> Assert.Fail(e.Message)

        File.Delete(temp)

    [<Fact>]
    let ``element test`` () =
        match element (XName.Get("root")) xDocPlusRoot with
        | Some e -> Assert.Equal("root", e.Name.LocalName)
        | None -> Assert.Fail()

    [<Fact>]
    let ``elements test`` () =
        match elements xDocPlusRoot |> Seq.toList with
        | e :: _ -> Assert.Equal("root", e.Name.LocalName)
        | [] -> Assert.Fail()

    [<Fact>]
    let ``elements2 test`` () =
        match elements2 (XName.Get("root")) xDocPlusRoot |> Seq.toList with
        | e :: _ -> Assert.Equal("root", e.Name.LocalName)
        | [] -> Assert.Fail()

    [<Fact>]
    let ``firstNode test`` () =
        match firstNode xDocPlusRoot with
        | Some a -> Assert.Equal("root", (a :?> XElement).Name.LocalName)
        | None -> Assert.Fail()

    [<Fact>]
    let ``lastNode test`` () =
        match lastNode xDocPlusRoot with
        | Some a -> Assert.Equal("root", (a :?> XElement).Name.LocalName)
        | None -> Assert.Fail()

    [<Fact>]
    let ``nodes test`` () =
        match nodes xDocPlusRoot |> Seq.toList with
        | a :: _ -> Assert.Equal("root", (a :?> XElement).Name.LocalName)
        | [] -> Assert.Fail()

    let unformattedNode = "<root><element /></root>"
    let formattedNode = "<root>\n  <element />\n</root>"

    [<Fact>]
    let ``toString test`` () =
        Assert.Equal(formattedNode, (toString xDocPlusDecl).Replace("\r\n", "\n"))

    [<Fact>]
    let ``toString2 test`` () =
        Assert.Equal(unformattedNode, toString2 SaveOptions.DisableFormatting xDocPlusDecl)
