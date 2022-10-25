namespace Feliz.ChartJS

open Feliz
open Fable.Core.JsInterop
open Fable.Core
open TooltipCallbacks

[<Erase>]
type option =
    static member inline responsive(resp: bool) : IOptionsProp = Interop.mkOptionsProp "responsive" resp

    static member inline maintainAspectRatio(ratio: bool) : IOptionsProp =
        Interop.mkOptionsProp "maintainAspectRatio" ratio

    static member inline scales(props: IScalesProp seq) : IOptionsProp =
        Interop.mkOptionsProp "scales" (createObj !!props)

    static member inline layout(props: ILayoutProp seq) : IOptionsProp =
        Interop.mkOptionsProp "layout" (createObj !!props)

    static member inline plugins(props: IPluginsProp seq) : IOptionsProp =
        Interop.mkOptionsProp "plugins" (createObj !!props)


[<Erase>]
type plugin =
    static member inline title(props: ITitleProp seq) : IPluginsProp =
        Interop.mkPluginsProp "title" (createObj !!props)

    static member inline legend(props: ILegendProp seq) : IPluginsProp =
        Interop.mkPluginsProp "legend" (createObj !!props)

    static member inline datalabels(props: IDataLabelsProp seq) : IPluginsProp =
        Interop.mkPluginsProp "datalabels" (createObj !!props)

    static member inline zoom(props: IZoomProp seq) : IPluginsProp =
        Interop.mkPluginsProp "zoom" (createObj !!props)
    static member inline tooltip(props: IToolTipsProp seq) : IPluginsProp =
        Interop.mkPluginsProp "tooltip" (createObj !!props)

[<Erase>]
type tooltip =
    static member inline backgroundColor(backgroundColor: string) : IToolTipsProp =
        Interop.mkToolTipsProp "backgroundColor" backgroundColor
    static member inline borderColor(borderColor: string) : IToolTipsProp =
        Interop.mkToolTipsProp "borderColor" borderColor
    static member inline caretSize(caretSize: int) : IToolTipsProp =
        Interop.mkToolTipsProp "caretSize" caretSize
    static member inline position(position: ToolTipPosition) : IToolTipsProp =
        Interop.mkToolTipsProp "position" position

    static member inline titleFont(titleFont: string) : IToolTipsProp = //TODO: Should be a font
        Interop.mkToolTipsProp "titleFont" titleFont

    static member inline titleColor(titleColor: string) : IToolTipsProp =
        Interop.mkToolTipsProp "titleColor" titleColor
    static member inline titleAlign(titleAlign: TextAlignment) : IToolTipsProp =
        Interop.mkToolTipsProp "titleAlign" titleAlign

    static member inline bodyColor(bodyColor: string) : IToolTipsProp =
        Interop.mkToolTipsProp "bodyColor" bodyColor

    static member inline bodyFontSize(bodyFontSize: int) : IToolTipsProp =
        Interop.mkToolTipsProp "bodyFontSize" bodyFontSize
    static member inline callbacks(props: IToolTipCallbackProp seq) : IToolTipsProp =
        Interop.mkToolTipsProp "callbacks" (createObj !!props)

[<Erase>]
type tooltipcallback =
    static member inline beforeTitle(toolTipItems: TooltipItem [] -> string []) : IToolTipCallbackProp = !!("beforeTitle" ==> toolTipItems)
    static member inline title(toolTipItems: TooltipItem [] -> string []) : IToolTipCallbackProp = !!("title" ==> toolTipItems)
    static member inline afterTitle(toolTipItems: TooltipItem [] -> string []) : IToolTipCallbackProp = !!("afterTitle" ==> toolTipItems)
    static member inline beforeBody(toolTipItems: TooltipItem [] -> string []) : IToolTipCallbackProp = !!("beforeBody" ==> toolTipItems)
    static member inline beforeLable(toolTipItems: TooltipItem [] -> string []) : IToolTipCallbackProp = !!("beforeLable" ==> toolTipItems)
    static member inline label(toolTipItems: TooltipItem -> string []) : IToolTipCallbackProp = !!("label" ==> toolTipItems)
    static member inline labelColor(toolTipItems: TooltipItem -> obj) : IToolTipCallbackProp = !!("labelColor" ==> toolTipItems)
    static member inline labelTextColor(toolTipItems: TooltipItem -> obj) : IToolTipCallbackProp = !!("labelTextColor" ==> toolTipItems)
    static member inline labelPointStyle(toolTipItems: TooltipItem -> obj) : IToolTipCallbackProp = !!("labelPointStyle" ==> toolTipItems)
    static member inline afterLabel(toolTipItems: TooltipItem -> string []) : IToolTipCallbackProp = !!("afterLabel" ==> toolTipItems)
    static member inline afterBody(toolTipItems: TooltipItem [] -> string []) : IToolTipCallbackProp = !!("afterBody" ==> toolTipItems)
    static member inline beforeFooter(toolTipItems: TooltipItem [] -> string []) : IToolTipCallbackProp = !!("beforeFooter" ==> toolTipItems)
    static member inline footer(toolTipItems: TooltipItem [] -> string []) : IToolTipCallbackProp = !!("footer" ==> toolTipItems)
    static member inline afterFooter(toolTipItems: TooltipItem [] -> string []) : IToolTipCallbackProp = !!("afterFooter" ==> toolTipItems)


[<Erase>]
type scale =
    static member inline x(props: IAxesProp seq) : IScalesProp =
        Interop.mkScalesProp "x" (createObj !!props)

    static member inline y(props: IAxesProp seq) : IScalesProp =
        Interop.mkScalesProp "y" (createObj !!props)

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

    static member inline title(props: ITitleProp seq) : IAxesProp =
        Interop.mkAxesProp "title" (createObj !!props)

[<Erase>]
type padding =
    static member inline bottom(bottom: int) : IPaddingProp = Interop.mkPaddingProp "bottom" bottom

[<Erase>]
type title =
    static member inline display(display: bool) : ITitleProp = Interop.mkTitleProp "display" display
    static member inline text(text: string) : ITitleProp = Interop.mkTitleProp "text" text

[<Erase>]
type legend =
    static member inline position(position: Position) : ILegendProp =
        Interop.mkLegendProp "position" position

    static member inline display(display: bool) : ILegendProp = Interop.mkLegendProp "display" display

[<Erase>]
type datalabels =
    static member inline allign(allign: Position) : IDataLabelsProp =
        Interop.mkDataLabelsProp "allign" allign

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
type font =
    static member inline size(size: int) : IFontProp = Interop.mkFontProp "allign" size

[<Erase>]
type labels =
    static member inline value props : ILabelsProp =
        Interop.mkLabelsProp "value" (createObj !!props)