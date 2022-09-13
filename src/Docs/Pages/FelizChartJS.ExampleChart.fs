module Views.ExampleGrid

open Fable.React
open Browser.Dom
open Feliz
open Feliz.Bulma
open Feliz.ChartJS
open Shared

let layouts =
    [|  ChartJS.layout [
                layout.i "a"
                layout.x 0
                layout.y 0
                layout.w 1
                layout.h 2
                layout.``static`` true
            ]
        ChartJS.layout [
            layout.i "b"
            layout.x 1
            layout.y 0
            layout.w 3
            layout.h 2
            layout.minW 2
            layout.maxW 4
        ] |]
[<ReactComponent>]
let ChartJSC () =
    ChartJS.chart [
            // ChartJS.layoutElements layouts
            // ChartJS.className "layout"
            // ChartJS.cols 24
            // ChartJS.autoSize false
            // ChartJS.isDraggable true
            // ChartJS.compactType Vertical
            // ChartJS.rowHeight 30
            // ChartJS.onLayoutChange (fun layout ->
            //     console.log layout
            //     for e in layout do
            //         console.log e.x
            //         console.log e.y
            //         console.log e.i
            //         console.log e.w
            //         console.log e.h)
            // ChartJS.width 1200
            ChartJS.children [
                Html.div [
                    prop.key "a"
                    prop.text "Texta"
                ]
                Html.div [
                    prop.key "b"
                    prop.text "Textb"
                ]
                Html.div [
                    prop.key "c"
                    prop.text "Textc"
                ]
                Html.div [
                    prop.key "d"
                    prop.text "Textd"
                ]
                Html.div [
                    prop.key "e"
                    prop.text "TextE"
                ]

            ]
        ]
let ChartJSChart =
    div [ Props.Style [ Props.CSSProp.Height 800 ] ] [
        ChartJSChart ()
    ]

let overview =
    Html.div
        [ Bulma.title.h1 [ Html.text "Feliz.ChartJS Example" ]
          Bulma.content
              [ Html.p "Here is an example how to use ChartJS"
                div [ Props.Style [ Props.CSSProp.Height 350 ] ] [
                    ChartJSChart ()
                ]
                code """
                let layouts =
                    [|  ChartJS.layout [
                                layout.i "a"
                                layout.x 0
                                layout.y 0
                                layout.w 1
                                layout.h 2
                                layout.``static`` true
                            ]
                        ChartJS.layout [
                            layout.i "b"
                            layout.x 1
                            layout.y 0
                            layout.w 3
                            layout.h 2
                            layout.minW 2
                            layout.maxW 4
                        ] |]
                [<ReactComponent>]
                let ChartJSChart () =
                    ChartJS.gridChart [
                            ChartJS.layoutElements layouts
                            ChartJS.className "layout"
                            ChartJS.cols 24
                            ChartJS.autoSize false
                            ChartJS.isDraggable true
                            ChartJS.compactType Vertical
                            ChartJS.rowHeight 30
                            ChartJS.onLayoutChange (fun layout ->
                                console.log layout
                                for e in layout do
                                    console.log e.x
                                    console.log e.y
                                    console.log e.i
                                    console.log e.w
                                    console.log e.h)
                            ChartJS.width 1200
                            ChartJS.children [
                                Html.div [
                                    prop.key "a"
                                    prop.text "Texta"
                                ]
                                Html.div [
                                    prop.key "b"
                                    prop.text "Textb"
                                ]
                                Html.div [
                                    prop.key "c"
                                    prop.text "Textc"
                                ]
                                Html.div [
                                    prop.key "d"
                                    prop.text "Textd"
                                ]
                                Html.div [
                                    prop.key "e"
                                    prop.text "TextE"
                                ]

                            ]
                        ]
                """ ]
          fixDocsView "FelizChartJS.ExampleGrid" false      ]