namespace Feliz.ChartJS

open Fable.Core
open Fable.Core.JsInterop

/// Chart instance methods for programmatic control
[<RequireQualifiedAccess>]
module ChartMethods =

    /// Updates the chart. This can be safely called after updating the data object.
    /// This will update all scales, legends, and then re-render the chart.
    [<Emit("$0.update($1)")>]
    let update (chart: Interop.ChartJS) (mode: string option) : unit = jsNative

    /// Updates the chart without animation
    let updateQuiet (chart: Interop.ChartJS) : unit =
        update chart (Some "none")

    /// Triggers an update of the chart. This can be safely called after updating the data object.
    [<Emit("$0.update()")>]
    let updateDefault (chart: Interop.ChartJS) : unit = jsNative

    /// Reset the chart to its state before the initial animation.
    [<Emit("$0.reset()")>]
    let reset (chart: Interop.ChartJS) : unit = jsNative

    /// Use this to destroy any chart instances that are created.
    /// This will clean up any references stored to the chart object within Chart.js.
    [<Emit("$0.destroy()")>]
    let destroy (chart: Interop.ChartJS) : unit = jsNative

    /// Use this to manually resize the canvas element.
    [<Emit("$0.resize($1, $2)")>]
    let resize (chart: Interop.ChartJS) (width: int) (height: int) : unit = jsNative

    /// Triggers a resize of the chart.
    [<Emit("$0.resize()")>]
    let resizeDefault (chart: Interop.ChartJS) : unit = jsNative

    /// Use this to stop any current animation.
    [<Emit("$0.stop()")>]
    let stop (chart: Interop.ChartJS) : unit = jsNative

    /// Will clear the chart canvas. Used extensively internally between animation frames.
    [<Emit("$0.clear()")>]
    let clear (chart: Interop.ChartJS) : unit = jsNative

    /// Returns a base 64 encoded string of the chart in its current state.
    [<Emit("$0.toBase64Image($1, $2)")>]
    let toBase64Image (chart: Interop.ChartJS) (imageType: string) (quality: float) : string = jsNative

    /// Returns a base 64 encoded PNG string of the chart.
    let toBase64ImagePng (chart: Interop.ChartJS) : string =
        toBase64Image chart "image/png" 1.0

    /// Returns a base 64 encoded JPEG string of the chart.
    let toBase64ImageJpeg (chart: Interop.ChartJS) (quality: float) : string =
        toBase64Image chart "image/jpeg" quality

    /// Returns an HTML string of a legend for that chart.
    [<Emit("$0.generateLegend()")>]
    let generateLegend (chart: Interop.ChartJS) : string = jsNative

    /// Triggers a redraw of all chart elements. Note, this does not update elements for new data.
    [<Emit("$0.render()")>]
    let render (chart: Interop.ChartJS) : unit = jsNative

    /// Sets the visibility for a given dataset.
    [<Emit("$0.setDatasetVisibility($1, $2)")>]
    let setDatasetVisibility (chart: Interop.ChartJS) (datasetIndex: int) (visible: bool) : unit = jsNative

    /// Toggles the visibility of an item in all datasets.
    [<Emit("$0.toggleDataVisibility($1)")>]
    let toggleDataVisibility (chart: Interop.ChartJS) (index: int) : unit = jsNative

    /// Returns the visibility of the item at the given index across all datasets.
    [<Emit("$0.getDataVisibility($1)")>]
    let getDataVisibility (chart: Interop.ChartJS) (index: int) : bool = jsNative

    /// Hide a dataset. This method sets the hidden property of the dataset to true and updates the chart.
    [<Emit("$0.hide($1, $2)")>]
    let hide (chart: Interop.ChartJS) (datasetIndex: int) (dataIndex: int option) : unit = jsNative

    /// Show a dataset. This method sets the hidden property of the dataset to false and updates the chart.
    [<Emit("$0.show($1, $2)")>]
    let show (chart: Interop.ChartJS) (datasetIndex: int) (dataIndex: int option) : unit = jsNative

    /// Returns true if the dataset at the given index is currently hidden.
    [<Emit("$0.isDatasetVisible($1)")>]
    let isDatasetVisible (chart: Interop.ChartJS) (datasetIndex: int) : bool = jsNative

    /// Returns the number of visible datasets.
    [<Emit("$0.getVisibleDatasetCount()")>]
    let getVisibleDatasetCount (chart: Interop.ChartJS) : int = jsNative

    /// Get the active (hovered) elements for the chart.
    [<Emit("$0.getActiveElements()")>]
    let getActiveElements (chart: Interop.ChartJS) : obj array = jsNative

    /// Set the active (hovered) elements for the chart.
    [<Emit("$0.setActiveElements($1)")>]
    let setActiveElements (chart: Interop.ChartJS) (elements: obj array) : unit = jsNative

    /// Get chart data
    [<Emit("$0.data")>]
    let getData (chart: Interop.ChartJS) : obj = jsNative

    /// Get chart options
    [<Emit("$0.options")>]
    let getOptions (chart: Interop.ChartJS) : obj = jsNative

    /// Get chart canvas element
    [<Emit("$0.canvas")>]
    let getCanvas (chart: Interop.ChartJS) : Browser.Types.HTMLCanvasElement = jsNative

    /// Get chart width
    [<Emit("$0.width")>]
    let getWidth (chart: Interop.ChartJS) : int = jsNative

    /// Get chart height
    [<Emit("$0.height")>]
    let getHeight (chart: Interop.ChartJS) : int = jsNative

    /// Get chart aspect ratio
    [<Emit("$0.aspectRatio")>]
    let getAspectRatio (chart: Interop.ChartJS) : float = jsNative
