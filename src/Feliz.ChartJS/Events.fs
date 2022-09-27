namespace Feliz.ChartJS

module Events =
    open Browser.Types
    type DoughnutClickEvent =
        abstract event: MouseEvent with get