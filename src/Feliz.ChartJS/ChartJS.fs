namespace Feliz.ChartJS

open Fable.Core.JsInterop
open Fable.Core
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

type DroppingItem = {
    i: string
    w: int
    h: int
}

// The !! below is used to "unsafely" expose a prop into an IReactJSProp.
[<Erase>]
type ReactJS =
    /// Creates a new ReactReactJS component.

    static member inline gridChart(props: IReactJSProp seq) =
        Interop.reactApi.createElement (Interop.ReactJS, createObj !!props)

    static member inline layoutElements(layoutElements: 'a array) : IReactJSProp = !!("layout" ==> layoutElements)
    static member inline layout props : ILayoutProp = !!(createObj !!props)

    static member inline style props : IReactJSProp =
        Interop.mkReactJSProp "style" (createObj !!props)

    static member inline className(className: string) : IReactJSProp =
        Interop.mkReactJSProp "className" className

    static member inline cols(cols: int) : IReactJSProp = Interop.mkReactJSProp "cols" cols

    static member inline rowHeight(rowHeight: int) : IReactJSProp =
        Interop.mkReactJSProp "rowHeight" rowHeight

    static member inline compactType(compactType: CompactType) : IReactJSProp =
        Interop.mkReactJSProp "compactType" compactType

    static member inline droppingItem( droppingItem:DroppingItem) : IReactJSProp =
        Interop.mkReactJSProp "droppingItem" droppingItem

    static member inline width(width: int) : IReactJSProp = Interop.mkReactJSProp "width" width

    static member inline autoSize(autoSize: bool) : IReactJSProp =
        Interop.mkReactJSProp "autoSize" autoSize

    static member inline allowOverlap(allowOverlap: bool) : IReactJSProp =
        Interop.mkReactJSProp "allowOverlap" allowOverlap

    static member inline isDraggable(isDraggable: bool) : IReactJSProp =
        Interop.mkReactJSProp "isDraggable" isDraggable
    static member inline isDropable(isDropable: bool) : IReactJSProp =
        Interop.mkReactJSProp "isDropable" isDropable
    static member inline isResizable(isResizable: bool) : IReactJSProp =
        Interop.mkReactJSProp "isResizable" isResizable
    static member inline isBounded(isBounded: bool) : IReactJSProp =
        Interop.mkReactJSProp "isBounded" isBounded
    static member inline useCSSTransforms(useCSSTransforms: bool) : IReactJSProp =
        Interop.mkReactJSProp "useCSSTransforms" useCSSTransforms
    static member inline transformScale(transformScale: int) : IReactJSProp =
        Interop.mkReactJSProp "transformScale" transformScale
    static member inline preventCollision(preventCollision: bool) : IReactJSProp =
        Interop.mkReactJSProp "preventCollision" preventCollision

    // TODO: This is not yet implemented in the ReactJS.
    // static member inline margin(margins: 'a array) : IReactJSProp = !!("margin" ==> margins)

    static member inline children(children: ReactElement list) =
        unbox<IReactJSProp> (prop.children children)

    static member inline onLayoutChange(handler: Layout [] -> unit) : IReactJSProp = !!("onLayoutChange" ==> handler)