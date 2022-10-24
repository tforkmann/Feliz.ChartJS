namespace Feliz.ChartJS

open Fable.Core
/// This interface allows us to stop adding random props to the react chart js.
type IChartJSProp =
    interface
    end

type IOptionsProp =
    interface
    end
type IPluginsProp =
    interface
    end
type IToolTipsProp =
    interface
    end
type IScalesProp =
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
type IFontProp =
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
type IDoughnutChartProp =
    interface
    end

type ILineDataProp =
    interface
    end

type ILineDataSetsProp =
    interface
    end
type IBarDataProp =
    interface
    end

type IBarDataSetsProp =
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

[<StringEnum>]
type Position =
    | Top
    | Left
    | Bottom
    | Right
[<StringEnum>]
type YAxis =
    | YLeft
    | YRight
[<Erase>]
type InteractionItem =
    abstract element : obj
    abstract datasetIndex : int
    abstract index : int
