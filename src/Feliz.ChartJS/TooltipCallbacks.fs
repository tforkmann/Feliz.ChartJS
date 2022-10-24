namespace Feliz.ChartJS

module TooltipCallbacks =
    type TooltipContext =
        abstract chart: Interop.ChartJS with get
        abstract label  : string with get