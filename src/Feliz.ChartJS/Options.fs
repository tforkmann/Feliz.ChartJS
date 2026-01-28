namespace Feliz.ChartJS

open Feliz
open Fable.Core.JsInterop
open Fable.Core
open TooltipCallbacks
open PluginsCallbacks

[<Erase>]
type option =
    static member inline responsive(resp: bool) : IOptionsProp = Interop.mkOptionsProp "responsive" resp

    static member inline aspectRatio(aspectRatio: int) : IOptionsProp =
        Interop.mkOptionsProp "aspectRatio" aspectRatio

    static member inline aspectRatio(aspectRatio: float) : IOptionsProp =
        Interop.mkOptionsProp "aspectRatio" aspectRatio

    static member inline locale(locale: string) : IOptionsProp =
        Interop.mkOptionsProp "locale" locale

    static member inline maintainAspectRatio(ratio: bool) : IOptionsProp =
        Interop.mkOptionsProp "maintainAspectRatio" ratio

    static member inline scales(props: IScalesProp seq) : IOptionsProp =
        Interop.mkOptionsProp "scales" (createObj !!props)

    static member inline layout(props: ILayoutProp seq) : IOptionsProp =
        Interop.mkOptionsProp "layout" (createObj !!props)

    static member inline plugins(props: IPluginProp seq) : IOptionsProp =
        Interop.mkOptionsProp "plugins" (createObj !!props)

    static member inline animation(props: IAnimationProp seq) : IOptionsProp =
        Interop.mkOptionsProp "animation" (createObj !!props)

    static member inline animation(enabled: bool) : IOptionsProp =
        Interop.mkOptionsProp "animation" enabled

    static member inline animations(props: IAnimationsProp seq) : IOptionsProp =
        Interop.mkOptionsProp "animations" (createObj !!props)

    static member inline transitions(props: ITransitionProp seq) : IOptionsProp =
        Interop.mkOptionsProp "transitions" (createObj !!props)

    static member inline interaction(props: IInteractionProp seq) : IOptionsProp =
        Interop.mkOptionsProp "interaction" (createObj !!props)

    static member inline hover(props: IHoverProp seq) : IOptionsProp =
        Interop.mkOptionsProp "hover" (createObj !!props)

    static member inline elements(props: IElementsProp seq) : IOptionsProp =
        Interop.mkOptionsProp "elements" (createObj !!props)

    static member inline indexAxis(axis: string) : IOptionsProp =
        Interop.mkOptionsProp "indexAxis" axis

    static member inline devicePixelRatio(ratio: float) : IOptionsProp =
        Interop.mkOptionsProp "devicePixelRatio" ratio

    static member inline resizeDelay(delay: int) : IOptionsProp =
        Interop.mkOptionsProp "resizeDelay" delay

    static member inline onClick(handler: Browser.Types.MouseEvent -> obj array -> unit) : IOptionsProp =
        !!("onClick" ==> handler)

    static member inline onHover(handler: Browser.Types.MouseEvent -> obj array -> unit) : IOptionsProp =
        !!("onHover" ==> handler)

    static member inline onResize(handler: Interop.ChartJS -> obj -> unit) : IOptionsProp =
        !!("onResize" ==> handler)

[<Erase>]

type inlinePlugin =
    static member inline plugin(props: IInlinePluginProp seq) : IInlinePlugin = !!(createObj !!props)

[<Erase>]
type plugin =
    static member inline title(props: ITitleProp seq) : IPluginProp =
        Interop.mkPluginProp "title" (createObj !!props)

    static member inline legend(props: ILegendProp seq) : IPluginProp =
        Interop.mkPluginProp "legend" (createObj !!props)

    static member inline dataLabels(props: IDataLabelsProp seq) : IPluginProp =
        Interop.mkPluginProp "datalabels" (createObj !!props)

    static member inline zoom(props: IZoomProp seq) : IPluginProp =
        Interop.mkPluginProp "zoom" (createObj !!props)

    static member inline tooltip(props: IToolTipsProp seq) : IPluginProp =
        Interop.mkPluginProp "tooltip" (createObj !!props)

[<Erase>]
type inlinePlugins =
    static member inline id(id: string) : IInlinePluginProp = Interop.mkInlinePluginProp "id" id

    static member inline afterDatasetDraw
        (handler:
            {|
                ctx: CanvasRenderingContext
                chartArea: ChartArea
                args: obj
                options: obj
            |}
                -> unit)
        : IInlinePluginProp =
        !!("afterDatasetDraw" ==> handler)

    static member inline beforeDraw
        (handler:
            {|
                ctx: CanvasRenderingContext
                chartArea: ChartArea
                args: obj
                options: obj
            |}
                -> unit)
        : IInlinePluginProp =
        !!("beforeDraw" ==> handler)

    static member inline afterDraw
        (handler:
            {|
                ctx: CanvasRenderingContext
                chartArea: ChartArea
                args: obj
                options: obj
            |}
                -> unit)
        : IInlinePluginProp =
        !!("afterDraw" ==> handler)

    static member inline beforeInit
        (handler:
            {|
                ctx: CanvasRenderingContext
                chartArea: ChartArea
                args: obj
                options: obj
            |}
                -> unit)
        : IInlinePluginProp =
        !!("beforeInit" ==> handler)

    static member inline defaults(defaults: IDefaultsProp seq) : IInlinePluginProp =
        Interop.mkInlinePluginProp "defaults" (createObj !!defaults)

[<Erase>]
type tooltip =
    static member inline enabled(enabled: bool) : IToolTipsProp =
        Interop.mkToolTipsProp "enabled" enabled

    static member inline intersect(intersect: bool) : IToolTipsProp =
        Interop.mkToolTipsProp "intersect" intersect

    static member inline position(position: ToolTipPosition) : IToolTipsProp =
        Interop.mkToolTipsProp "position" position

    static member inline callbacks(props: IToolTipCallbackProp seq) : IToolTipsProp =
        Interop.mkToolTipsProp "callbacks" (createObj !!props)

    static member inline backgroundColor(backgroundColor: string) : IToolTipsProp =
        Interop.mkToolTipsProp "backgroundColor" backgroundColor

    static member inline titleColor(titleColor: string) : IToolTipsProp =
        Interop.mkToolTipsProp "titleColor" titleColor

    static member inline titleFont(props: IFontProp seq) : IToolTipsProp =
        Interop.mkToolTipsProp "titleFont" (createObj !!props)

    static member inline titleAlign(titleAlign: TextAlignment) : IToolTipsProp =
        Interop.mkToolTipsProp "titleAlign" titleAlign

    static member inline titleSpacing(titleSpacing: int) : IToolTipsProp =
        Interop.mkToolTipsProp "titleSpacing" titleSpacing

    static member inline titleMarginBottom(titleMarginBottom: int) : IToolTipsProp =
        Interop.mkToolTipsProp "titleMarginBottom" titleMarginBottom

    static member inline bodyColor(bodyColor: string) : IToolTipsProp =
        Interop.mkToolTipsProp "bodyColor" bodyColor

    static member inline bodyFont(props: IFontProp seq) : IToolTipsProp =
        Interop.mkToolTipsProp "bodyFont" (createObj !!props)

    static member inline bodyAlign(bodyAlign: TextAlignment) : IToolTipsProp =
        Interop.mkToolTipsProp "bodyAlign" bodyAlign

    static member inline bodySpacing(bodySpacing: int) : IToolTipsProp =
        Interop.mkToolTipsProp "bodySpacing" bodySpacing

    static member inline borderColor(borderColor: string) : IToolTipsProp =
        Interop.mkToolTipsProp "borderColor" borderColor

    static member inline borderWidth(borderWidth: int) : IToolTipsProp =
        Interop.mkToolTipsProp "borderWidth" borderWidth

    static member inline caretSize(caretSize: int) : IToolTipsProp =
        Interop.mkToolTipsProp "caretSize" caretSize

    static member inline footerFont(props: IFontProp seq) : IToolTipsProp =
        Interop.mkToolTipsProp "footerFont" (createObj !!props)

    static member inline footerAlign(props: IFontProp seq) : IToolTipsProp =
        Interop.mkToolTipsProp "footerFont" (createObj !!props)

    static member inline footerSpacing(footerSpacing: int) : IToolTipsProp =
        Interop.mkToolTipsProp "footerSpacing" footerSpacing

    static member inline footerMarginTop(footerMarginTop: int) : IToolTipsProp =
        Interop.mkToolTipsProp "footerMarginTop" footerMarginTop

    static member inline displayColors(displayColors: bool) : IToolTipsProp =
        Interop.mkToolTipsProp "displayColors" displayColors

[<Erase>]
type toolTipCallback =
    static member inline beforeTitle(toolTipItems: TooltipItem[] -> string[]) : IToolTipCallbackProp =
        !!("beforeTitle" ==> toolTipItems)

    static member inline title(toolTipItems: TooltipItem[] -> string[]) : IToolTipCallbackProp =
        !!("title" ==> toolTipItems)

    static member inline afterTitle(toolTipItems: TooltipItem[] -> string[]) : IToolTipCallbackProp =
        !!("afterTitle" ==> toolTipItems)

    static member inline beforeBody(toolTipItems: TooltipItem[] -> string[]) : IToolTipCallbackProp =
        !!("beforeBody" ==> toolTipItems)

    static member inline beforeLable(toolTipItems: TooltipItem[] -> string[]) : IToolTipCallbackProp =
        !!("beforeLable" ==> toolTipItems)

    static member inline label(toolTipItems: TooltipItem -> string[]) : IToolTipCallbackProp =
        !!("label" ==> toolTipItems)

    static member inline labelColor(toolTipItems: TooltipItem -> obj) : IToolTipCallbackProp =
        !!("labelColor" ==> toolTipItems)

    static member inline labelTextColor(toolTipItems: TooltipItem -> obj) : IToolTipCallbackProp =
        !!("labelTextColor" ==> toolTipItems)

    static member inline labelPointStyle(toolTipItems: TooltipItem -> obj) : IToolTipCallbackProp =
        !!("labelPointStyle" ==> toolTipItems)

    static member inline afterLabel(toolTipItems: TooltipItem -> string[]) : IToolTipCallbackProp =
        !!("afterLabel" ==> toolTipItems)

    static member inline afterBody(toolTipItems: TooltipItem[] -> string[]) : IToolTipCallbackProp =
        !!("afterBody" ==> toolTipItems)

    static member inline beforeFooter(toolTipItems: TooltipItem[] -> string[]) : IToolTipCallbackProp =
        !!("beforeFooter" ==> toolTipItems)

    static member inline footer(toolTipItems: TooltipItem[] -> string[]) : IToolTipCallbackProp =
        !!("footer" ==> toolTipItems)

    static member inline afterFooter(toolTipItems: TooltipItem[] -> string[]) : IToolTipCallbackProp =
        !!("afterFooter" ==> toolTipItems)


[<Erase>]
type font =
    static member inline family(family: string) : IFontProp = Interop.mkFontProp "family" family
    static member inline size(size: int) : IFontProp = Interop.mkFontProp "size" size
    static member inline style(style: string) : IFontProp = Interop.mkFontProp "style" style
    static member inline weight(weight: string) : IFontProp = Interop.mkFontProp "weight" weight

    static member inline lineHeight(lineHeight: int) : IFontProp =
        Interop.mkFontProp "lineHeight" lineHeight

[<Erase>]
type scale =
    static member inline x(props: IXProp seq) : IScalesProp =
        Interop.mkScalesProp "x" (createObj !!props)

    static member inline y(props: IYProp seq) : IScalesProp =
        Interop.mkScalesProp "y" (createObj !!props)

    static member inline xWithAxes(props: IAxesProp seq) : IScalesProp =
        Interop.mkScalesProp "x" (createObj !!props)

    static member inline yWithAxes(props: IAxesProp seq) : IScalesProp =
        Interop.mkScalesProp "y" (createObj !!props)

    static member inline yWithAxesWithID(yID,props: IAxesProp seq) : IScalesProp =
        Interop.mkScalesProp yID (createObj !!props)

    static member inline xAxes(props: IAxesProp seq) : IScalesProp =
        Interop.mkScalesProp "xAxes" (createObj !!props)

    static member inline yAxes(props: IAxesProp seq) : IScalesProp =
        Interop.mkScalesProp "yAxes" (createObj !!props)

    static member inline yLeft(props: IAxesProp seq) : IScalesProp =
        Interop.mkScalesProp "YLeft" (createObj !!props)

    static member inline yRight(props: IAxesProp seq) : IScalesProp =
        Interop.mkScalesProp "YRight" (createObj !!props)

[<Erase>]
type layout =
    static member inline padding(props: IPaddingProp seq) : ILayoutProp =
        Interop.mkLayoutProp "value" (createObj !!props)

[<Erase>]
type axes =
    static member inline stacked(stacked: bool) : IAxesProp = Interop.mkAxesProp "stacked" stacked
    static member inline position(position: Position) : IAxesProp = Interop.mkAxesProp "position" position
    static member inline reverse(reverse: bool) : IAxesProp = Interop.mkAxesProp "reverse" reverse
    static member inline ticks(handler: ITicksProperties -> unit) = Interop.mkAxesProp "ticks" handler
    static member inline min(min: int) : IAxesProp = Interop.mkAxesProp "min" min
    static member inline max(max: int) : IAxesProp = Interop.mkAxesProp "max" max
    static member inline ``type``(axesType: AxesType) : IAxesProp = Interop.mkAxesProp "type" axesType
    static member inline time(props: ITimeProp seq) : IAxesProp =  Interop.mkAxesProp "time" (createObj !!props)
    static member inline display(display: bool) : IAxesProp = Interop.mkAxesProp "display" display

    static member inline suggestedMin(suggestedMin: float) : IAxesProp =
        Interop.mkAxesProp "suggestedMin" suggestedMin

    static member inline suggestedMax(suggestedMax: float) : IAxesProp =
        Interop.mkAxesProp "suggestedMax" suggestedMax

    static member inline ticks(props: ITicksProp seq) : IAxesProp =
        Interop.mkAxesProp "ticks" (createObj !!props)

    static member inline title(props: ITitleProp seq) : IAxesProp =
        Interop.mkAxesProp "title" (createObj !!props)

    static member inline grid(props: IGridProp seq) : IAxesProp =
        Interop.mkAxesProp "grid" (createObj !!props)

    static member inline border(props: IGridProp seq) : IAxesProp =
        Interop.mkAxesProp "border" (createObj !!props)

[<Erase>]
type ticks =
    static member inline color(color: string) : ITicksProp = Interop.mkTicksProp "color" color
    static member inline stepSize(stepSize: int) : ITicksProp = Interop.mkTicksProp "stepSize" stepSize
    static member inline precision(precision: int) : ITicksProp = Interop.mkTicksProp "precision" precision

[<Erase>]
type grid =
    /// The color of the grid lines
    static member inline color(color: string) : IGridProp = Interop.mkGridProp "color" color
    /// If false, the grid lines will not be drawn
    static member inline display(display: bool) : IGridProp = Interop.mkGridProp "display" display
    /// If true, draw lines on the chart area inside the axis lines
    static member inline drawOnChartArea(drawOnChartArea: bool) : IGridProp = Interop.mkGridProp "drawOnChartArea" drawOnChartArea
    /// If true, draw lines beside the ticks
    static member inline drawTicks(drawTicks: bool) : IGridProp = Interop.mkGridProp "drawTicks" drawTicks
    /// Length in pixels that the grid lines will draw into the axis area
    static member inline tickLength(tickLength: int) : IGridProp = Interop.mkGridProp "tickLength" tickLength
    /// Stroke width of grid lines
    static member inline lineWidth(lineWidth: int) : IGridProp = Interop.mkGridProp "lineWidth" lineWidth
    /// If true, gridlines are circular (on radar and polar area charts only)
    static member inline circular(circular: bool) : IGridProp = Interop.mkGridProp "circular" circular
    /// Length and spacing of dashes on grid lines
    static member inline borderDash(borderDash: int[]) : IGridProp = Interop.mkGridProp "borderDash" borderDash
    /// Offset for line dashes
    static member inline borderDashOffset(borderDashOffset: float) : IGridProp = Interop.mkGridProp "borderDashOffset" borderDashOffset
    /// z-index of gridline layer. Values <= 0 are drawn under datasets, > 0 on top
    static member inline z(z: int) : IGridProp = Interop.mkGridProp "z" z

[<Erase>]
type time =
    static member inline tooltipFormat(format: string) : ITimeProp = Interop.mkTimeProp "tooltipFormat" format

[<Erase>]
type y =
    static member inline min(min: int) : IYProp = Interop.mkYProp "min" min
    static member inline max(max: int) : IYProp = Interop.mkYProp "max" max
    static member inline beginAtZero(beginAtZero: bool) : IYProp =
        Interop.mkYProp "beginAtZero" beginAtZero

    static member inline suggestedMin(suggestedMin: float) : IYProp =
        Interop.mkYProp "suggestedMin" suggestedMin

    static member inline suggestedMax(suggestedMax: float) : IYProp =
        Interop.mkYProp "suggestedMax" suggestedMax

[<Erase>]
type x =
    static member inline min(min: int) : IXProp = Interop.mkXProp "min" min
    static member inline max(max: int) : IXProp = Interop.mkXProp "max" max

    static member inline suggestedMin(suggestedMin: float) : IAxesProp =
        Interop.mkAxesProp "suggestedMin" suggestedMin

    static member inline suggestedMax(suggestedMax: float) : IAxesProp =
        Interop.mkAxesProp "suggestedMax" suggestedMax

[<Erase>]
type padding =
    static member inline bottom(bottom: int) : IPaddingProp = Interop.mkPaddingProp "bottom" bottom

[<Erase>]
type title =
    static member inline display(display: bool) : ITitleProp = Interop.mkTitleProp "display" display
    static member inline text(text: string) : ITitleProp = Interop.mkTitleProp "text" text
    static member inline color(color: string) : ITitleProp = Interop.mkTitleProp "color" color

    static member inline padding props : ITitleProp =
        Interop.mkTitleProp "padding" (createObj !!props)

    static member inline font props : ITitleProp =
        Interop.mkTitleProp "font" (createObj !!props)

[<Erase>]
type legend =
    static member inline position(position: Position) : ILegendProp =
        Interop.mkLegendProp "position" position

    static member inline display(display: bool) : ILegendProp = Interop.mkLegendProp "display" display

    static member inline align(align: TextAlignment) : ILegendProp =
        Interop.mkLegendProp "align" align

    static member inline maxHeight(maxHeight: int) : ILegendProp =
        Interop.mkLegendProp "maxHeight" maxHeight

    static member inline maxWidth(maxWidth: int) : ILegendProp =
        Interop.mkLegendProp "maxWidth" maxWidth

    static member inline fullSize(fullSize: bool) : ILegendProp =
        Interop.mkLegendProp "fullSize" fullSize

    static member inline reverse(reverse: bool) : ILegendProp =
        Interop.mkLegendProp "reverse" reverse

    static member inline rtl(rtl: bool) : ILegendProp =
        Interop.mkLegendProp "rtl" rtl

    static member inline labels(props: ILabelsProp seq) : ILegendProp =
        Interop.mkLegendProp "labels" (createObj !!props)

    static member inline title(props: ITitleProp seq) : ILegendProp =
        Interop.mkLegendProp "title" (createObj !!props)

    static member inline onClick(handler: Browser.Types.MouseEvent -> obj -> obj -> unit) : ILegendProp =
        !!("onClick" ==> handler)

    static member inline onHover(handler: Browser.Types.MouseEvent -> obj -> unit) : ILegendProp =
        !!("onHover" ==> handler)

    static member inline onLeave(handler: Browser.Types.MouseEvent -> obj -> unit) : ILegendProp =
        !!("onLeave" ==> handler)

[<Erase>]
type dataLabels =
    static member inline align(align: Position) : IDataLabelsProp = Interop.mkDataLabelsProp "align" align

    static member inline display(display: bool) : IDataLabelsProp =
        Interop.mkDataLabelsProp "display" display

    static member inline clamp(clamp: bool) : IDataLabelsProp = Interop.mkDataLabelsProp "clamp" clamp

    static member inline color(color: string) : IDataLabelsProp = Interop.mkDataLabelsProp "color" color

    static member inline backgroundColor(backgroundColor: string) : IDataLabelsProp =
        Interop.mkDataLabelsProp "backgroundColor" backgroundColor

    static member inline borderRadius(borderRadius: int) : IDataLabelsProp =
        Interop.mkDataLabelsProp "borderRadius" borderRadius

    static member inline font props : IDataLabelsProp =
        Interop.mkDataLabelsProp "font" (createObj !!props)

    static member inline labels props : IDataLabelsProp =
        Interop.mkDataLabelsProp "labels" (createObj !!props)

    static member inline formatter(context: IContextProperties -> ReactElement) : IDataLabelsProp =
        Interop.mkDataLabelsProp "formatter" context

[<Erase>]
type zoom =
    static member inline wheel props : IZoomProp =
        Interop.mkZoomProp "wheel" (createObj !!props)

[<Erase>]
type wheel =
    static member inline enabled(enabled: bool) : IWheelProp = Interop.mkWheelProp "enabled" enabled

[<Erase>]
type labels =
    static member inline value props : ILabelsProp =
        Interop.mkLabelsProp "value" (createObj !!props)

    static member inline color(color: string) : ILabelsProp = Interop.mkLabelsProp "color" color
    static member inline padding(padding: int) : ILabelsProp = Interop.mkLabelsProp "padding" padding

    static member inline textAlign(textAlign: TextAlignment) : ILabelsProp =
        Interop.mkLabelsProp "textAlign" textAlign



[<Erase>]
type defaults =
    static member inline color(color: string) : IDefaultsProp = Interop.mkDefaultsProp "color" color

[<Erase>]
type animation =
    static member inline duration(duration: int) : IAnimationProp =
        Interop.mkAnimationProp "duration" duration

    static member inline easing(easing: Easing) : IAnimationProp =
        Interop.mkAnimationProp "easing" easing

    static member inline delay(delay: int) : IAnimationProp =
        Interop.mkAnimationProp "delay" delay

    static member inline loop(loop: bool) : IAnimationProp =
        Interop.mkAnimationProp "loop" loop

    static member inline onProgress(handler: obj -> unit) : IAnimationProp =
        !!("onProgress" ==> handler)

    static member inline onComplete(handler: obj -> unit) : IAnimationProp =
        !!("onComplete" ==> handler)

[<Erase>]
type animations =
    static member inline tension(props: IAnimationProp seq) : IAnimationsProp =
        Interop.mkAnimationsProp "tension" (createObj !!props)

    static member inline x(props: IAnimationProp seq) : IAnimationsProp =
        Interop.mkAnimationsProp "x" (createObj !!props)

    static member inline y(props: IAnimationProp seq) : IAnimationsProp =
        Interop.mkAnimationsProp "y" (createObj !!props)

    static member inline radius(props: IAnimationProp seq) : IAnimationsProp =
        Interop.mkAnimationsProp "radius" (createObj !!props)

    static member inline colors(props: IAnimationProp seq) : IAnimationsProp =
        Interop.mkAnimationsProp "colors" (createObj !!props)

[<Erase>]
type transition =
    static member inline active(props: IAnimationProp seq) : ITransitionProp =
        Interop.mkTransitionProp "active" (createObj !!props)

    static member inline hide(props: IAnimationProp seq) : ITransitionProp =
        Interop.mkTransitionProp "hide" (createObj !!props)

    static member inline reset(props: IAnimationProp seq) : ITransitionProp =
        Interop.mkTransitionProp "reset" (createObj !!props)

    static member inline resize(props: IAnimationProp seq) : ITransitionProp =
        Interop.mkTransitionProp "resize" (createObj !!props)

    static member inline show(props: IAnimationProp seq) : ITransitionProp =
        Interop.mkTransitionProp "show" (createObj !!props)

[<Erase>]
type interaction =
    static member inline mode(mode: InteractionMode) : IInteractionProp =
        Interop.mkInteractionProp "mode" mode

    static member inline intersect(intersect: bool) : IInteractionProp =
        Interop.mkInteractionProp "intersect" intersect

    static member inline axis(axis: InteractionAxis) : IInteractionProp =
        Interop.mkInteractionProp "axis" axis

    static member inline includeInvisible(includeInvisible: bool) : IInteractionProp =
        Interop.mkInteractionProp "includeInvisible" includeInvisible

[<Erase>]
type hover =
    /// Sets which elements appear in the tooltip. See Interaction Modes for details.
    static member inline mode(mode: InteractionMode) : IHoverProp =
        Interop.mkHoverProp "mode" mode

    /// If true, the hover mode only applies when the mouse position intersects an item on the chart.
    static member inline intersect(intersect: bool) : IHoverProp =
        Interop.mkHoverProp "intersect" intersect

    /// Define which directions are used in calculating distances. Defaults to 'x' for 'index' mode and 'xy' in dataset and 'nearest' modes.
    static member inline axis(axis: InteractionAxis) : IHoverProp =
        Interop.mkHoverProp "axis" axis

    /// if true, the invisible points that are outside of the chart area will also be included when evaluating interactions.
    static member inline includeInvisible(includeInvisible: bool) : IHoverProp =
        Interop.mkHoverProp "includeInvisible" includeInvisible

[<Erase>]
type elements =
    static member inline point(props: IPointElementProp seq) : IElementsProp =
        Interop.mkElementsProp "point" (createObj !!props)

    static member inline line(props: ILineElementProp seq) : IElementsProp =
        Interop.mkElementsProp "line" (createObj !!props)

    static member inline bar(props: IBarElementProp seq) : IElementsProp =
        Interop.mkElementsProp "bar" (createObj !!props)

    static member inline arc(props: IArcElementProp seq) : IElementsProp =
        Interop.mkElementsProp "arc" (createObj !!props)

[<Erase>]
type pointElement =
    static member inline radius(radius: int) : IPointElementProp =
        Interop.mkPointElementProp "radius" radius

    static member inline pointStyle(pointStyle: PointStyle) : IPointElementProp =
        Interop.mkPointElementProp "pointStyle" pointStyle

    static member inline rotation(rotation: int) : IPointElementProp =
        Interop.mkPointElementProp "rotation" rotation

    static member inline backgroundColor(backgroundColor: string) : IPointElementProp =
        Interop.mkPointElementProp "backgroundColor" backgroundColor

    static member inline borderWidth(borderWidth: int) : IPointElementProp =
        Interop.mkPointElementProp "borderWidth" borderWidth

    static member inline borderColor(borderColor: string) : IPointElementProp =
        Interop.mkPointElementProp "borderColor" borderColor

    static member inline hitRadius(hitRadius: int) : IPointElementProp =
        Interop.mkPointElementProp "hitRadius" hitRadius

    static member inline hoverRadius(hoverRadius: int) : IPointElementProp =
        Interop.mkPointElementProp "hoverRadius" hoverRadius

    static member inline hoverBorderWidth(hoverBorderWidth: int) : IPointElementProp =
        Interop.mkPointElementProp "hoverBorderWidth" hoverBorderWidth

[<Erase>]
type lineElement =
    static member inline tension(tension: float) : ILineElementProp =
        Interop.mkLineElementProp "tension" tension

    static member inline backgroundColor(backgroundColor: string) : ILineElementProp =
        Interop.mkLineElementProp "backgroundColor" backgroundColor

    static member inline borderWidth(borderWidth: int) : ILineElementProp =
        Interop.mkLineElementProp "borderWidth" borderWidth

    static member inline borderColor(borderColor: string) : ILineElementProp =
        Interop.mkLineElementProp "borderColor" borderColor

    static member inline borderCapStyle(borderCapStyle: BorderCapStyle) : ILineElementProp =
        Interop.mkLineElementProp "borderCapStyle" borderCapStyle

    static member inline borderDash(borderDash: int[]) : ILineElementProp =
        Interop.mkLineElementProp "borderDash" borderDash

    static member inline borderDashOffset(borderDashOffset: float) : ILineElementProp =
        Interop.mkLineElementProp "borderDashOffset" borderDashOffset

    static member inline borderJoinStyle(borderJoinStyle: BorderJoinStyle) : ILineElementProp =
        Interop.mkLineElementProp "borderJoinStyle" borderJoinStyle

    static member inline capBezierPoints(capBezierPoints: bool) : ILineElementProp =
        Interop.mkLineElementProp "capBezierPoints" capBezierPoints

    static member inline cubicInterpolationMode(mode: string) : ILineElementProp =
        Interop.mkLineElementProp "cubicInterpolationMode" mode

    static member inline fill(fill: bool) : ILineElementProp =
        Interop.mkLineElementProp "fill" fill

    static member inline fill(fill: string) : ILineElementProp =
        Interop.mkLineElementProp "fill" fill

    static member inline stepped(stepped: bool) : ILineElementProp =
        Interop.mkLineElementProp "stepped" stepped

[<Erase>]
type barElement =
    static member inline backgroundColor(backgroundColor: string) : IBarElementProp =
        Interop.mkBarElementProp "backgroundColor" backgroundColor

    static member inline borderWidth(borderWidth: int) : IBarElementProp =
        Interop.mkBarElementProp "borderWidth" borderWidth

    static member inline borderColor(borderColor: string) : IBarElementProp =
        Interop.mkBarElementProp "borderColor" borderColor

    static member inline borderSkipped(borderSkipped: string) : IBarElementProp =
        Interop.mkBarElementProp "borderSkipped" borderSkipped

    static member inline borderRadius(borderRadius: int) : IBarElementProp =
        Interop.mkBarElementProp "borderRadius" borderRadius

    static member inline inflateAmount(inflateAmount: int) : IBarElementProp =
        Interop.mkBarElementProp "inflateAmount" inflateAmount

    static member inline pointStyle(pointStyle: PointStyle) : IBarElementProp =
        Interop.mkBarElementProp "pointStyle" pointStyle

    static member inline hoverBackgroundColor(hoverBackgroundColor: string) : IBarElementProp =
        Interop.mkBarElementProp "hoverBackgroundColor" hoverBackgroundColor

    static member inline hoverBorderColor(hoverBorderColor: string) : IBarElementProp =
        Interop.mkBarElementProp "hoverBorderColor" hoverBorderColor

    static member inline hoverBorderWidth(hoverBorderWidth: int) : IBarElementProp =
        Interop.mkBarElementProp "hoverBorderWidth" hoverBorderWidth

    static member inline hoverBorderRadius(hoverBorderRadius: int) : IBarElementProp =
        Interop.mkBarElementProp "hoverBorderRadius" hoverBorderRadius

[<Erase>]
type arcElement =
    static member inline angle(angle: float) : IArcElementProp =
        Interop.mkArcElementProp "angle" angle

    static member inline backgroundColor(backgroundColor: string) : IArcElementProp =
        Interop.mkArcElementProp "backgroundColor" backgroundColor

    static member inline borderAlign(borderAlign: string) : IArcElementProp =
        Interop.mkArcElementProp "borderAlign" borderAlign

    static member inline borderColor(borderColor: string) : IArcElementProp =
        Interop.mkArcElementProp "borderColor" borderColor

    static member inline borderDash(borderDash: int[]) : IArcElementProp =
        Interop.mkArcElementProp "borderDash" borderDash

    static member inline borderDashOffset(borderDashOffset: float) : IArcElementProp =
        Interop.mkArcElementProp "borderDashOffset" borderDashOffset

    static member inline borderJoinStyle(borderJoinStyle: BorderJoinStyle) : IArcElementProp =
        Interop.mkArcElementProp "borderJoinStyle" borderJoinStyle

    static member inline borderWidth(borderWidth: int) : IArcElementProp =
        Interop.mkArcElementProp "borderWidth" borderWidth

    static member inline circular(circular: bool) : IArcElementProp =
        Interop.mkArcElementProp "circular" circular

    static member inline hoverBackgroundColor(hoverBackgroundColor: string) : IArcElementProp =
        Interop.mkArcElementProp "hoverBackgroundColor" hoverBackgroundColor

    static member inline hoverBorderColor(hoverBorderColor: string) : IArcElementProp =
        Interop.mkArcElementProp "hoverBorderColor" hoverBorderColor

    static member inline hoverBorderWidth(hoverBorderWidth: int) : IArcElementProp =
        Interop.mkArcElementProp "hoverBorderWidth" hoverBorderWidth

    static member inline hoverOffset(hoverOffset: int) : IArcElementProp =
        Interop.mkArcElementProp "hoverOffset" hoverOffset
