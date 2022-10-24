namespace Feliz.ChartJS

module TooltipCallbacks =
    type TooltipItem =
        abstract chart: Interop.ChartJS with get
        abstract label  : string with get