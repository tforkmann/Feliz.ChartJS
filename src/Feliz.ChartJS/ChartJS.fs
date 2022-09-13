namespace Feliz.ChartJS

open Fable.Core.JsInterop
open Fable.Core
open Fable.React
open Feliz

type Event = Browser.Types.Event

[<Erase>]
type style =
    static member inline background(background: string) = Interop.mkAttr "background" background
    static member inline color(color: string) = Interop.mkAttr "color" color
    static member inline border(border: string) = Interop.mkAttr "border" border
    static member inline width(width: int) = Interop.mkAttr "width" width
    static member inline height(heigth: int) = Interop.mkAttr "heigth" heigth
    static member inline stroke(stroke: string) = Interop.mkAttr "stroke" stroke

[<Erase>]
type labelStyle =
    static member inline fill(fill: string) = Interop.mkAttr "fill" fill
    static member inline fontWeight(fontWeight: int) = Interop.mkAttr "fontWeight" fontWeight

[<StringEnum>]
type CompactType =
    | Horizontal
    | Vertical

type LineData = { lable: obj; datasets: obj }


// The !! below is used to "unsafely" expose a prop into an IChartJSProp.
[<Erase>]
type ChartJS =
    /// Creates a new ChartJS component.

    static member inline chart(props: IChartJSProp seq) =
        Interop.reactApi.createElement (Interop.chart, createObj !!props)

    static member inline line(props: ILineChartProp seq) =
        Interop.reactApi.createElement (Interop.line, createObj !!props)

    static member inline options props : ILineChartProp =
        Interop.mkLineChartProp "options" (createObj !!props)

    static member inline option props : IOptionsProp = !!(createObj !!props)

    static member inline lineData props : ILineChartProp =

        Interop.mkLineChartProp "data" (createObj !!props)

    static member inline labels props : ILineDataProp = !!(createObj !!props)



    // static member inline data(data: ILineChartProp) : ILineChartProp = !!(createObj !!props)

    // static member inline style props : IChartJSProp =
    //     Interop.mkChartJSProp "style" (createObj !!props)

    // static member inline className(className: string) : IChartJSProp =
    //     Interop.mkChartJSProp "className" className

    // static member inline cols(cols: int) : IChartJSProp = Interop.mkChartJSProp "cols" cols

    // static member inline rowHeight(rowHeight: int) : IChartJSProp =
    //     Interop.mkChartJSProp "rowHeight" rowHeight

    // static member inline compactType(compactType: CompactType) : IChartJSProp =
    //     Interop.mkChartJSProp "compactType" compactType

    // static member inline droppingItem( droppingItem:DroppingItem) : IChartJSProp =
    //     Interop.mkChartJSProp "droppingItem" droppingItem

    // static member inline width(width: int) : IChartJSProp = Interop.mkChartJSProp "width" width

    // static member inline autoSize(autoSize: bool) : IChartJSProp =
    //     Interop.mkChartJSProp "autoSize" autoSize

    // static member inline allowOverlap(allowOverlap: bool) : IChartJSProp =
    //     Interop.mkChartJSProp "allowOverlap" allowOverlap

    // static member inline isDraggable(isDraggable: bool) : IChartJSProp =
    //     Interop.mkChartJSProp "isDraggable" isDraggable
    // static member inline isDropable(isDropable: bool) : IChartJSProp =
    //     Interop.mkChartJSProp "isDropable" isDropable
    // static member inline isResizable(isResizable: bool) : IChartJSProp =
    //     Interop.mkChartJSProp "isResizable" isResizable
    // static member inline isBounded(isBounded: bool) : IChartJSProp =
    //     Interop.mkChartJSProp "isBounded" isBounded
    // static member inline useCSSTransforms(useCSSTransforms: bool) : IChartJSProp =
    //     Interop.mkChartJSProp "useCSSTransforms" useCSSTransforms
    // static member inline transformScale(transformScale: int) : IChartJSProp =
    //     Interop.mkChartJSProp "transformScale" transformScale
    // static member inline preventCollision(preventCollision: bool) : IChartJSProp =
    //     Interop.mkChartJSProp "preventCollision" preventCollision

    // TODO: This is not yet implemented in the ChartJS.
    // static member inline margin(margins: 'a array) : IChartJSProp = !!("margin" ==> margins)

    static member inline children(children: ReactElement list) =
        unbox<IChartJSProp> (prop.children children)

// static member inline onLayoutChange(handler: Layout [] -> unit) : IChartJSProp = !!("onLayoutChange" ==> handler)

