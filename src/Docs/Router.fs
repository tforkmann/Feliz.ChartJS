module Docs.Router

open Browser.Types
open Feliz.Router
open Fable.Core.JsInterop

type Page =
    | Install
    | Use
    | LineChart
    | BubbleChart
    | BarChart
    | DoughnutChart
    | MixedChart


[<RequireQualifiedAccess>]
module Page =
    let defaultPage = Install

    let parseFromUrlSegments =
        function
        | [ "use" ] -> Use
        | [ "linechart" ] -> LineChart
        | [ "barchart" ] -> BarChart
        | [ "doughnutchart" ] -> DoughnutChart
        | [ "mixedchart" ] -> MixedChart
        | [ "bubblechart" ] -> BubbleChart
        | [] -> Install
        | _ -> defaultPage

    let noQueryString segments : string list * (string * string) list = segments, []

    let toUrlSegments =
        function
        | Install -> [] |> noQueryString
        | LineChart -> ["linechart"] |> noQueryString
        | BarChart -> ["barchart"] |> noQueryString
        | DoughnutChart -> ["doughnutchart"] |> noQueryString
        | MixedChart -> ["mixedchart"] |> noQueryString
        | BubbleChart -> ["bubblechart"] |> noQueryString
        | Use -> [ "use" ] |> noQueryString

[<RequireQualifiedAccess>]
module Router =
    let goToUrl (e: MouseEvent) =
        e.preventDefault ()
        let href: string = !!e.currentTarget?attributes?href?value
        Router.navigate href

    let navigatePage (p: Page) =
        p |> Page.toUrlSegments |> Router.navigate

[<RequireQualifiedAccess>]
module Cmd =
    let navigatePage (p: Page) = p |> Page.toUrlSegments |> Cmd.navigate
