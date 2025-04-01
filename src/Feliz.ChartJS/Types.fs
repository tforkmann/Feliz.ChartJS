namespace Feliz.ChartJS

open Fable.Core
/// This interface allows us to stop adding random props to the react chart js.
type IChartJSProp =
    interface
    end

type IOptionsProp =
    interface
    end

type IInlinePluginProp =
    interface
    end
type IInlinePlugin =
    interface
    end
type IPluginProp =
    interface
    end

type IToolTipsProp =
    interface
    end

type IToolTipCallbackProp =
    interface
    end

type IDefaultsProp =
    interface
    end

type IScalesProp =
    interface
    end

type IFontProp =
    interface
    end

type ILayoutProp =
    interface
    end

type IPaddingProp =
    interface
    end

type IAxesProp =
    interface
    end

type ITicksProp =
    interface
    end
type ITimeProp =
    interface
    end

type IYProp =
    interface
    end
type IXProp =
    interface
    end

type ILegendProp =
    interface
    end
type ITitleProp =
    interface
    end
type IDataLabelsProp =
    interface
    end

type IZoomProp =
    interface
    end

type ILabelsProp =
    interface
    end

type IDataLabelProp =
    interface
    end
type IWheelProp =
    interface
    end

type ILineChartProp =
    interface
    end

type IBarChartProp =
    interface
    end

type IBubbleChartProp =
    interface
    end

type IDoughnutChartProp =
    interface
    end

type ILineDataProp =
    interface
    end

type ILineDataSetsProp =
    interface
    end
type ILineSegmentProp =
    interface
    end

type IBarDataProp =
    interface
    end

type IBarDataSetsProp =
    interface
    end
type IBubbleDataProp =
    interface
    end

type IBubbleDataPointsProp =
    interface
    end

type IBubbleDataPointProp =
    interface
    end


type IBubbleDataSetsProp =
    interface
    end

type IDoughnutDataProp =
    interface
    end

type IDoughnutDataSetsProp =
    interface
    end

type IInteractionItemProp =
    interface
    end

[<Erase>]
type IContextProperties =
    abstract cy : float
    abstract cx : float
    abstract midAngle : float
    abstract innerRadius : float
    abstract outerRadius : float
    abstract percent : float
    abstract index : int

[<Erase>]
type ITicksProperties =
    abstract value : string
    abstract index : int
    abstract ticks : int

[<StringEnum;RequireQualifiedAccess>]
type Position =
    | Top
    | Left
    | Bottom
    | Right

[<StringEnum;RequireQualifiedAccess>]
type Mode =
    | Nearest
    | Point
    | Index
    | Dataset
    | X
    | Y
    | Intersect

[<StringEnum;RequireQualifiedAccess>]
type ToolTipPosition =
    | Nearest
    | Average

[<StringEnum;RequireQualifiedAccess>]
type TextAlignment =
    | Left
    | Right
    | Center

[<StringEnum;RequireQualifiedAccess>]
type YAxis =
    | YLeft
    | YRight

[<StringEnum;RequireQualifiedAccess>]
type AxesType =
    | Time
    | Logarithmic

type InteractionItem =
    abstract element : obj
    abstract datasetIndex : int
    abstract index : int
